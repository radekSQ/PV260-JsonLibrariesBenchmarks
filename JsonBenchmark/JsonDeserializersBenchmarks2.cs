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
    public class JsonDeserializersBenchmarks2 : JsonBenchmarkBase
    {
        [Benchmark]
        public Root NewtonsoftJson_Deserialize2()
        {
            return JsonConvert.DeserializeObject<Root>(JsonSampleString2);
        }
    }
}
