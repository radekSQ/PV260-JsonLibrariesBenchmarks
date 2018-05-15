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
    public class FastJsonSerialize : JsonBenchmarkBase
    {
        [Benchmark]
        public string fastJSON_Serialize()
        {
            return JSON.ToJSON(JsonSampleRoot);
        }
    }
}
