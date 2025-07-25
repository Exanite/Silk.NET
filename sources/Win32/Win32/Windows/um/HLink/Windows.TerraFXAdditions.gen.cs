// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public const int HltbDockedleft = 0;
    public const int HltbDockedtop = 1;
    public const int HltbDockedright = 2;
    public const int HltbDockedbottom = 3;
    public const int HltbFloating = 4;
    public const int HlbwifHasframewndinfo = 0x1;
    public const int HlbwifHasdocwndinfo = 0x2;
    public const int HlbwifFramewndmaximized = 0x4;
    public const int HlbwifDocwndmaximized = 0x8;
    public const int HlbwifHaswebtoolbarinfo = 0x10;
    public const int HlbwifWebtoolbarhidden = 0x20;
    public const int HlidInvalid = 0;
    public const int HlidPrevious = unchecked((int)(0xffffffff));
    public const int HlidNext = unchecked((int)(0xfffffffe));
    public const int HlidCurrent = unchecked((int)(0xfffffffd));
    public const int HlidStackbottom = unchecked((int)(0xfffffffc));
    public const int HlidStacktop = unchecked((int)(0xfffffffb));
    public const int HlqfIsvalid = 0x1;
    public const int HlqfIscurrent = 0x2;
}
