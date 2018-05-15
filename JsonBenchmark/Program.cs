using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace JsonBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<JsonDeserializersBenchmarks>();
            BenchmarkRunner.Run<JsonDeserializersBenchmarks2>();
            BenchmarkRunner.Run<JsonSerializersBenchmarks>();
            BenchmarkRunner.Run<JsonDeserializersBenchmarkStream>();
            BenchmarkRunner.Run<FastJsonDeserialize>();
            BenchmarkRunner.Run<FastJsonSerialize>();
            Console.ReadKey();
        }
    }
}
