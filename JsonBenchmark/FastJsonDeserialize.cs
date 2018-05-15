using System;
using System.IO;
using System.Runtime.Serialization.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using JsonBenchmark.TestDTOs;
using fastJSON;

namespace JsonBenchmark
{
    [ClrJob(isBaseline: true)]
    [RPlotExporter, RankColumn]
    [HtmlExporter]
    public class FastJsonDeserialize : JsonBenchmarkBase
    {
        [Benchmark]
        public Root fastJSON_Deserialize()
        {
            return JSON.ToObject<Root>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "TestFiles", "chucknorris.json")));
        }
    }
}
