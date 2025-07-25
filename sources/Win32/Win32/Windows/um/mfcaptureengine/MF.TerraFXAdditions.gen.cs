// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class MF
{
    public const int CaptureEnginePreferredSourceStreamForVideoPreview = unchecked((int)0xFFFFFFFA);
    public const int CaptureEnginePreferredSourceStreamForVideoRecord = unchecked((int)0xFFFFFFF9);
    public const int CaptureEnginePreferredSourceStreamForPhoto = unchecked((int)0xFFFFFFF8);
    public const int CaptureEnginePreferredSourceStreamForAudio = unchecked((int)0xFFFFFFF7);
    public const int CaptureEngineMediasource = unchecked((int)0xFFFFFFFF);
}
