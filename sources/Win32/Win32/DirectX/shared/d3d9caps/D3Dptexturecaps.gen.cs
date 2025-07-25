// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3Dptexturecaps
{
    [NativeTypeName("#define D3DPTEXTURECAPS_PERSPECTIVE 0x00000001L")]
    public const int Perspective = 0x00000001;

    [NativeTypeName("#define D3DPTEXTURECAPS_POW2 0x00000002L")]
    public const int Pow2 = 0x00000002;

    [NativeTypeName("#define D3DPTEXTURECAPS_ALPHA 0x00000004L")]
    public const int Alpha = 0x00000004;

    [NativeTypeName("#define D3DPTEXTURECAPS_SQUAREONLY 0x00000020L")]
    public const int Squareonly = 0x00000020;

    [NativeTypeName("#define D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE 0x00000040L")]
    public const int Texrepeatnotscaledbysize = 0x00000040;

    [NativeTypeName("#define D3DPTEXTURECAPS_ALPHAPALETTE 0x00000080L")]
    public const int Alphapalette = 0x00000080;

    [NativeTypeName("#define D3DPTEXTURECAPS_NONPOW2CONDITIONAL 0x00000100L")]
    public const int Nonpow2Conditional = 0x00000100;

    [NativeTypeName("#define D3DPTEXTURECAPS_PROJECTED 0x00000400L")]
    public const int Projected = 0x00000400;

    [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP 0x00000800L")]
    public const int Cubemap = 0x00000800;

    [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP 0x00002000L")]
    public const int Volumemap = 0x00002000;

    [NativeTypeName("#define D3DPTEXTURECAPS_MIPMAP 0x00004000L")]
    public const int Mipmap = 0x00004000;

    [NativeTypeName("#define D3DPTEXTURECAPS_MIPVOLUMEMAP 0x00008000L")]
    public const int Mipvolumemap = 0x00008000;

    [NativeTypeName("#define D3DPTEXTURECAPS_MIPCUBEMAP 0x00010000L")]
    public const int Mipcubemap = 0x00010000;

    [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP_POW2 0x00020000L")]
    public const int CubemapPow2 = 0x00020000;

    [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP_POW2 0x00040000L")]
    public const int VolumemapPow2 = 0x00040000;

    [NativeTypeName("#define D3DPTEXTURECAPS_NOPROJECTEDBUMPENV 0x00200000L")]
    public const int Noprojectedbumpenv = 0x00200000;
}
