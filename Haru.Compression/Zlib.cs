using System.IO;
using Elskom.Generic.Libs;

namespace Haru.Compression
{
    public class Zlib
    {
        public static byte[] Deflate(byte[] data, ZlibCompression level)
        {
            using var msout = new MemoryStream();
            using var msin = new MemoryStream(data);
            using var zs = new ZlibStream(msout, level, true);

            msin.CopyTo(zs);
            zs.Flush();
            zs.Finish();

            return msout.ToArray();
        }
    }
}