using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;

namespace JsonBenchmark
{
    [ClrJob(isBaseline: true)]
    [RPlotExporter, RankColumn]
    [HtmlExporter]
    public class JsonDeserializersBenchmarkStream : JsonBenchmarkBase
    {
        [Benchmark]
        public Root NewtonsoftJson_DeserializeStream()
        {
            using (var file = File.OpenRead(Path.Combine(AppContext.BaseDirectory, "TestFiles", "chucknorris.json")))
            {
                using (var stream = new StreamReader(file))
                {
                    using (JsonReader reader = new JsonTextReader(stream))
                    {
                        var serializer = new JsonSerializer();
                        
                        return serializer.Deserialize<Root>(reader);
                    }
                }    
            }
        }
    }
}
