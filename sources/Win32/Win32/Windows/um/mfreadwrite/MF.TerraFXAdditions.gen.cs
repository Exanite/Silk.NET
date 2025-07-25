// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class MF
{
    public const int SourceReaderInvalidStreamIndex = unchecked((int)0xFFFFFFFF);
    public const int SourceReaderAllStreams = unchecked((int)0xFFFFFFFE);
    public const int SourceReaderAnyStream = unchecked((int)0xFFFFFFFE);
    public const int SourceReaderFirstAudioStream = unchecked((int)0xFFFFFFFD);
    public const int SourceReaderFirstVideoStream = unchecked((int)0xFFFFFFFC);
    public const int SourceReaderMediasource = unchecked((int)0xFFFFFFFF);
    public const int SourceReaderCurrentTypeIndex = unchecked((int)0xFFFFFFFF);
    public const int SinkWriterInvalidStreamIndex = unchecked((int)0xFFFFFFFF);
    public const int SinkWriterAllStreams = unchecked((int)0xFFFFFFFE);
    public const int SinkWriterMediasink = unchecked((int)0xFFFFFFFF);
}
