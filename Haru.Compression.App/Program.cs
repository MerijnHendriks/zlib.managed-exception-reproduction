using System.Linq;
using Elskom.Generic.Libs;
using Haru.Compression;

namespace Haru.Compression.App
{
    class Program
    {
        static void Main()
        {
            var result = Zlib.Deflate(ExampleData.Inflated, ZlibCompression.Level6);

            if (!result.SequenceEqual(ExampleData.Result))
            {
                throw new NotPackableException("Compression Failed.");
            }
        }
    }
}