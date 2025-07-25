// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    public const int AdviseNone = 0;
    public const int AdviseClipping = 0x1;
    public const int AdvisePalette = 0x2;
    public const int AdviseColorkey = 0x4;
    public const int AdvisePosition = 0x8;
    public const int AdviseDisplayChange = 0x10;
}
