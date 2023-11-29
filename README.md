# zlib.managed-exception-reproduction

Reproduction repo for an issue caused by deflation in zlib.managed

## Requirements

- dotnet 8.0

## Issue

```
System.InvalidOperationException: Operation is not valid due to the current state of the object.
  Stack Trace:
   at Elskom.Generic.Libs.Deflate.Compress(ZlibStream stream, ZlibFlushStrategy flush) in .\Haru.Compression\zlib.managed\Deflate.cs:line 416
   at Elskom.Generic.Libs.ZlibStream.Deflate(ZlibFlushStrategy flush) in .\Haru.Compression\zlib.managed\ZlibStream.cs:line 371
   at Elskom.Generic.Libs.ZlibStream.Finish() in .\Haru.Compression\zlib.managed\ZlibStream.cs:line 286
   at Haru.Compression.Zlib.Deflate(Byte[] data, ZlibCompression level) in .\Haru.Compression\Zlib.cs:line 17
   at Haru.Compression.Tests.ZlibTest.TestDeflate() in .\Haru.Compression.Tests\ZlibTest.cs:line 15
```

## Expected behaviour

`ZlibStream` to deflate the data without issues.

## Ways to reproduce

1. `dotnet test`
2. `dotnet run`

The project is set-up for debugging in VSCode and VS2022.

## 3rdparty

### zlib.managed

- project: [link](https://github.com/Elskom/zlib.managed)
- commit: `d1fa75f`

Changes:

- Removed dependency on `IDisposableGenerator`
  - `ZlibStream`: added `KeepOpen`
  - `ZlibStream`: added `Close()`
  - `ZlibStream`: removed `IDisposableGenerator` attributes
