// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    [NativeTypeName("#define D3DMAXUSERCLIPPLANES 32")]
    public const int D3Dmaxuserclipplanes = 32;

    [NativeTypeName("#define D3DCLIPPLANE0 (1 << 0)")]
    public const int D3Dclipplane0 = (1 << 0);

    [NativeTypeName("#define D3DCLIPPLANE1 (1 << 1)")]
    public const int D3Dclipplane1 = (1 << 1);

    [NativeTypeName("#define D3DCLIPPLANE2 (1 << 2)")]
    public const int D3Dclipplane2 = (1 << 2);

    [NativeTypeName("#define D3DCLIPPLANE3 (1 << 3)")]
    public const int D3Dclipplane3 = (1 << 3);

    [NativeTypeName("#define D3DCLIPPLANE4 (1 << 4)")]
    public const int D3Dclipplane4 = (1 << 4);

    [NativeTypeName("#define D3DCLIPPLANE5 (1 << 5)")]
    public const int D3Dclipplane5 = (1 << 5);

    [NativeTypeName("#define D3DRENDERSTATE_WRAPBIAS 128UL")]
    public const uint D3DrenderstateWrapbias = 128U;

    [NativeTypeName("#define D3DWRAPCOORD_0 0x00000001L")]
    public const int D3Dwrapcoord0 = 0x00000001;

    [NativeTypeName("#define D3DWRAPCOORD_1 0x00000002L")]
    public const int D3Dwrapcoord1 = 0x00000002;

    [NativeTypeName("#define D3DWRAPCOORD_2 0x00000004L")]
    public const int D3Dwrapcoord2 = 0x00000004;

    [NativeTypeName("#define D3DWRAPCOORD_3 0x00000008L")]
    public const int D3Dwrapcoord3 = 0x00000008;

    [NativeTypeName("#define D3DDMAPSAMPLER 256")]
    public const int D3Ddmapsampler = 256;

    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER0 (D3DDMAPSAMPLER+1)")]
    public const int D3Dvertextexturesampler0 = (256 + 1);

    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER1 (D3DDMAPSAMPLER+2)")]
    public const int D3Dvertextexturesampler1 = (256 + 2);

    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER2 (D3DDMAPSAMPLER+3)")]
    public const int D3Dvertextexturesampler2 = (256 + 3);

    [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER3 (D3DDMAPSAMPLER+4)")]
    public const int D3Dvertextexturesampler3 = (256 + 4);

    [NativeTypeName("#define MAXD3DDECLUSAGE D3DDECLUSAGE_SAMPLE")]
    public const D3Ddeclusage Maxd3Ddeclusage = D3Ddeclusage.Sample;

    [NativeTypeName("#define MAXD3DDECLUSAGEINDEX 15")]
    public const int Maxd3Ddeclusageindex = 15;

    [NativeTypeName("#define MAXD3DDECLLENGTH 64")]
    public const int Maxd3Ddecllength = 64;

    [NativeTypeName("#define MAXD3DDECLMETHOD D3DDECLMETHOD_LOOKUPPRESAMPLED")]
    public const D3Ddeclmethod Maxd3Ddeclmethod = D3Ddeclmethod.Lookuppresampled;

    [NativeTypeName("#define MAXD3DDECLTYPE D3DDECLTYPE_UNUSED")]
    public const D3Ddecltype Maxd3Ddecltype = D3Ddecltype.Unused;

    [NativeTypeName("#define D3DSINCOSCONST1 -1.5500992e-006f")]
    public const float D3Dsincosconst1 = -1.5500992e-006f;

    [NativeTypeName("#define D3DSINCOSCONST2 -0.020833334f")]
    public const float D3Dsincosconst2 = -0.020833334f;

    [NativeTypeName("#define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)")]
    public const int D3Drtypecount = ((int)(D3Dresourcetype.Indexbuffer) + 1);
}
