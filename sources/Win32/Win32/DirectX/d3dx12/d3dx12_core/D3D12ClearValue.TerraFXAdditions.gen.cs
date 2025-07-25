// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12ClearValue : IEquatable<D3D12ClearValue>
{
    public D3D12_CLEAR_VALUE(DxgiFormat format, [NativeTypeName("const FLOAT[4]")] float* color)
    {
        Unsafe.SkipInit(out this);
        Format = format;
        Anonymous.Color[0] = color[0];
        Anonymous.Color[1] = color[1];
        Anonymous.Color[2] = color[2];
        Anonymous.Color[3] = color[3];
    }

    public D3D12_CLEAR_VALUE(DxgiFormat format, float depth, [NativeTypeName("UINT8")] byte stencil)
    {
        Format = format;
        Anonymous.DepthStencil.Depth = depth;
        Anonymous.DepthStencil.Stencil = stencil;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Equals"]/*'/>

    public static bool operator ==(
        [NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12ClearValue a,
        [NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12ClearValue b
    )
    {
        if (a.Format != b.Format)
        {
            return false;
        }
        if (
            (a.Format == DxgiFormat.FormatD24UnormS8Uint)
            || (a.Format == DxgiFormat.FormatD16Unorm)
            || (a.Format == DxgiFormat.FormatD32Float)
            || (a.Format == DxgiFormat.FormatD32FloatS8X24Uint)
        )
        {
            return (a.Anonymous.DepthStencil.Depth == b.Anonymous.DepthStencil.Depth)
                && (a.Anonymous.DepthStencil.Stencil == b.Anonymous.DepthStencil.Stencil);
        }
        else
        {
            return (a.Anonymous.Color[0] == b.Anonymous.Color[0])
                && (a.Anonymous.Color[1] == b.Anonymous.Color[1])
                && (a.Anonymous.Color[2] == b.Anonymous.Color[2])
                && (a.Anonymous.Color[3] == b.Anonymous.Color[3]);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.NotEquals"]/*'/>

    public static bool operator !=(
        [NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12ClearValue l,
        [NativeTypeName("const D3D12_CLEAR_VALUE &")] in D3D12ClearValue r
    ) => !(l == r);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12ClearValue other) && Equals(other);

    public readonly bool Equals(D3D12ClearValue other) => (this == other);

    public override readonly int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Format);
        if (
            (Format == DxgiFormat.FormatD24UnormS8Uint)
            || (Format == DxgiFormat.FormatD16Unorm)
            || (Format == DxgiFormat.FormatD32Float)
            || (Format == DxgiFormat.FormatD32FloatS8X24Uint)
        )
        {
            hashCode.Add(Anonymous.DepthStencil.Depth);
            hashCode.Add(Anonymous.DepthStencil.Stencil);
        }
        else
        {
            hashCode.Add(Anonymous.Color[0]);
            hashCode.Add(Anonymous.Color[1]);
            hashCode.Add(Anonymous.Color[2]);
            hashCode.Add(Anonymous.Color[3]);
        }
        return hashCode.ToHashCode();
    }
}
