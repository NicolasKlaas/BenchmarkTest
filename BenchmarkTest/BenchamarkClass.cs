using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest
{
    public class BenchamarkClass
    {
        public async Task<bool> DidObjectChangeAsync(string fontFamily, string glyph, int size, string color, CompareToThisClass compareTo)
        {
            if (fontFamily != compareTo.FontFamily)
                return true;

            if (glyph != compareTo.Glyph)
                return true;

            if (size != compareTo.Size)
                return true;

            if (color != compareTo.Color)
                return true;

            return false;
        }

        public Task<bool> DidObjectChangeWithoutAsync(string fontFamily, string glyph, int size, string color, CompareToThisClass compareTo)
        {
            if (fontFamily != compareTo.FontFamily)
                return Task.FromResult(true);

            if (glyph != compareTo.Glyph)
                return Task.FromResult(true);

            if (size != compareTo.Size)
                return Task.FromResult(true);

            if (color != compareTo.Color)
                return Task.FromResult(true);

            return Task.FromResult(false);
        }

    }
}
