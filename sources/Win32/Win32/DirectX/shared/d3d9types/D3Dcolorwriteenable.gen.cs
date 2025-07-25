// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3Dcolorwriteenable
{
    [NativeTypeName("#define D3DCOLORWRITEENABLE_RED (1L<<0)")]
    public const int Red = (1 << 0);

    [NativeTypeName("#define D3DCOLORWRITEENABLE_GREEN (1L<<1)")]
    public const int Green = (1 << 1);

    [NativeTypeName("#define D3DCOLORWRITEENABLE_BLUE (1L<<2)")]
    public const int Blue = (1 << 2);

    [NativeTypeName("#define D3DCOLORWRITEENABLE_ALPHA (1L<<3)")]
    public const int Alpha = (1 << 3);
}
