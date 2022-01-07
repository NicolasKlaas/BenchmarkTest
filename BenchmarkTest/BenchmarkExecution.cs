using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkExecution
    {

        private static readonly BenchamarkClass benchamarkClass = new BenchamarkClass();


        [Benchmark(Baseline = true)]
        public async Task RunBenchmarkTaskAsync()
        {
            var _compareToThisClass = new CompareToThisClass { FontFamily = "otherFont1", Glyph = "otherGlyph1", Size = 15, Color = "otherColor1" };

            await benchamarkClass.DidObjectChangeAsync("fonttest1", "glyphtest1", 20, "colortest1", _compareToThisClass);
        }

        [Benchmark]
        public async Task RunBenchmarkTaskWithoutAsync()
        {
            var _compareToThisClass = new CompareToThisClass { FontFamily = "otherFont1", Glyph = "otherGlyph1", Size = 15, Color = "otherColor1" };

            await benchamarkClass.DidObjectChangeWithoutAsync("fonttest1", "glyphtest1", 20, "colortest1", _compareToThisClass);
        }
    }
}
