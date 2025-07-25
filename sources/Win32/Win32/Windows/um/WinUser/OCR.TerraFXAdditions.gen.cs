// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class OCR
{
    public const int Normal = 32512;
    public const int Ibeam = 32513;
    public const int Wait = 32514;
    public const int Cross = 32515;
    public const int Up = 32516;

    [Obsolete("use OCR_SIZEALL")]
    public const int Size = 32640;

    [Obsolete("use OCR_NORMAL")]
    public const int Icon = 32641;
    public const int Sizenwse = 32642;
    public const int Sizenesw = 32643;
    public const int Sizewe = 32644;
    public const int Sizens = 32645;
    public const int Sizeall = 32646;

    [Obsolete("use OIC_WINLOGO")]
    public const int Icocur = 32647;
    public const int No = 32648;
    public const int Hand = 32649;
    public const int Appstarting = 32650;
}
