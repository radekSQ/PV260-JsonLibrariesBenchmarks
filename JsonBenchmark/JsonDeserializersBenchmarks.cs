﻿using BenchmarkDotNet.Attributes;
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
    public class JsonDeserializersBenchmarks : JsonBenchmarkBase
    {
        [Benchmark]
        public Root NewtonsoftJson_Deserialize()
        {
            JsonSampleRoot = JsonConvert.DeserializeObject<Root>(JsonSampleString);
            return JsonSampleRoot;
        }
    }
}
