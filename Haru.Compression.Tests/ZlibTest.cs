using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elskom.Generic.Libs;
using Haru.Compression;

namespace Haru.Compression.Tests
{
    [TestClass]
    public class ZlibTest
    {
        [TestMethod]
        public void TestDeflate()
        {
            var data = Zlib.Deflate(ExampleData.Inflated, ZlibCompression.Level6);
            var result = data.SequenceEqual(ExampleData.Result);
            Assert.IsTrue(result);
        }
    }
}