// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Hbmmenu
{
    [NativeTypeName("#define HBMMENU_CALLBACK ((HBITMAP) -1)")]
    public static Hbitmap HBMMENU_CALLBACK => ((Hbitmap)(-1));

    [NativeTypeName("#define HBMMENU_SYSTEM ((HBITMAP)  1)")]
    public static Hbitmap HBMMENU_SYSTEM => ((Hbitmap)(1));

    [NativeTypeName("#define HBMMENU_MBAR_RESTORE ((HBITMAP)  2)")]
    public static Hbitmap HBMMENU_MBAR_RESTORE => ((Hbitmap)(2));

    [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE ((HBITMAP)  3)")]
    public static Hbitmap HBMMENU_MBAR_MINIMIZE => ((Hbitmap)(3));

    [NativeTypeName("#define HBMMENU_MBAR_CLOSE ((HBITMAP)  5)")]
    public static Hbitmap HBMMENU_MBAR_CLOSE => ((Hbitmap)(5));

    [NativeTypeName("#define HBMMENU_MBAR_CLOSE_D ((HBITMAP)  6)")]
    public static Hbitmap HBMMENU_MBAR_CLOSE_D => ((Hbitmap)(6));

    [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE_D ((HBITMAP)  7)")]
    public static Hbitmap HBMMENU_MBAR_MINIMIZE_D => ((Hbitmap)(7));

    [NativeTypeName("#define HBMMENU_POPUP_CLOSE ((HBITMAP)  8)")]
    public static Hbitmap HBMMENU_POPUP_CLOSE => ((Hbitmap)(8));

    [NativeTypeName("#define HBMMENU_POPUP_RESTORE ((HBITMAP)  9)")]
    public static Hbitmap HBMMENU_POPUP_RESTORE => ((Hbitmap)(9));

    [NativeTypeName("#define HBMMENU_POPUP_MAXIMIZE ((HBITMAP) 10)")]
    public static Hbitmap HBMMENU_POPUP_MAXIMIZE => ((Hbitmap)(10));

    [NativeTypeName("#define HBMMENU_POPUP_MINIMIZE ((HBITMAP) 11)")]
    public static Hbitmap HBMMENU_POPUP_MINIMIZE => ((Hbitmap)(11));
}
