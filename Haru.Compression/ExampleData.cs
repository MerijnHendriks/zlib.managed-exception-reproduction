namespace Haru.Compression
{
    public class ExampleData
    {
        public static readonly byte[] Inflated = new byte[]
        {
            0x7B, 0x22, 0x65, 0x72, 0x72, 0x22, 0x3A, 0x30, 0x2C, 0x22,
            0x65, 0x72, 0x72, 0x6D, 0x73, 0x67, 0x22, 0x3A, 0x6E, 0x75,
            0x6C, 0x6C, 0x2C, 0x22, 0x64, 0x61, 0x74, 0x61, 0x22, 0x3A,
            0x7B, 0x22, 0x75, 0x74, 0x63, 0x5F, 0x74, 0x69, 0x6D, 0x65,
            0x22, 0x3A, 0x31, 0x36, 0x39, 0x32, 0x32, 0x39, 0x30, 0x31,
            0x33, 0x39, 0x2E, 0x31, 0x34, 0x35, 0x31, 0x7D, 0x7D
        };

        public static readonly byte[] Result = new byte[]
        {
            // [0x78, 0x9C]: [zlib, level 6]
            0x78, 0x9C, 0xAB, 0x56, 0x4A, 0x2D, 0x2A, 0x52, 0xB2, 0x32,
            0xD0, 0x1,  0xD1, 0xB9, 0xC5, 0xE9, 0x4A, 0x56, 0x79, 0xA5,
            0x39, 0x39, 0x3A, 0x4A, 0x29, 0x89, 0x25, 0x89, 0x4A, 0x56,
            0xD5, 0x4A, 0xA5, 0x25, 0xC9, 0xF1, 0x25, 0x99, 0xB9, 0xA9,
            0x4A, 0x56, 0x86, 0x66, 0x96, 0x46, 0x46, 0x96, 0x6,  0x86,
            0xC6, 0x96, 0x7A, 0x86, 0x26, 0xA6, 0x86, 0xB5, 0xB5, 0x0,
            0x36, 0x12, 0x11, 0xFC
        };
    }
}