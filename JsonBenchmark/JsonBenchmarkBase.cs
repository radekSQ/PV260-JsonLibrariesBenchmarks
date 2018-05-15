using System;
using System.IO;
using JsonBenchmark.TestDTOs;

namespace JsonBenchmark
{
    public abstract class JsonBenchmarkBase
    {
        private const string TestFilesFolder = "TestFiles";
        protected string JsonSampleString;
        protected string JsonSampleString2;
        public Root JsonSampleRoot;

        protected JsonBenchmarkBase()
        {
            JsonSampleString = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "chucknorris.json"));
            JsonSampleString2 = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "testdata2.json"));
        }
    }
}
