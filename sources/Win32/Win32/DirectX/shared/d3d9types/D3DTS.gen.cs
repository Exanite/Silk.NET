// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3Dts
{
    [NativeTypeName("#define D3DTS_WORLD D3DTS_WORLDMATRIX(0)")]
    public const D3Dtransformstatetype World = (D3Dtransformstatetype)(0 + 256);

    [NativeTypeName("#define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)")]
    public const D3Dtransformstatetype World1 = (D3Dtransformstatetype)(1 + 256);

    [NativeTypeName("#define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)")]
    public const D3Dtransformstatetype World2 = (D3Dtransformstatetype)(2 + 256);

    [NativeTypeName("#define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)")]
    public const D3Dtransformstatetype World3 = (D3Dtransformstatetype)(3 + 256);
}
