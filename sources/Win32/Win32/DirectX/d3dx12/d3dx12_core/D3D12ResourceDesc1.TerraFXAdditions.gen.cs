// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12ResourceDesc1 : IEquatable<D3D12ResourceDesc1>
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Equals"]/*'/>

    public static bool operator ==(
        [NativeTypeName("const D3D12_RESOURCE_DESC1 &")] in D3D12ResourceDesc1 l,
        [NativeTypeName("const D3D12_RESOURCE_DESC1 &")] in D3D12ResourceDesc1 r
    ) =>
        (l.Dimension == r.Dimension)
        && (l.Alignment == r.Alignment)
        && (l.Width == r.Width)
        && (l.Height == r.Height)
        && (l.DepthOrArraySize == r.DepthOrArraySize)
        && (l.MipLevels == r.MipLevels)
        && (l.Format == r.Format)
        && (l.SampleDesc.Count == r.SampleDesc.Count)
        && (l.SampleDesc.Quality == r.SampleDesc.Quality)
        && (l.Layout == r.Layout)
        && (l.Flags == r.Flags)
        && (l.SamplerFeedbackMipRegion.Width == r.SamplerFeedbackMipRegion.Width)
        && (l.SamplerFeedbackMipRegion.Height == r.SamplerFeedbackMipRegion.Height)
        && (l.SamplerFeedbackMipRegion.Depth == r.SamplerFeedbackMipRegion.Depth);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.NotEquals"]/*'/>

    public static bool operator !=(
        [NativeTypeName("const D3D12_RESOURCE_DESC1 &")] in D3D12ResourceDesc1 l,
        [NativeTypeName("const D3D12_RESOURCE_DESC1 &")] in D3D12ResourceDesc1 r
    ) => !(l == r);

    public D3D12_RESOURCE_DESC1(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12ResourceDesc o
    )
    {
        Dimension = o.Dimension;
        Alignment = o.Alignment;
        Width = o.Width;
        Height = o.Height;
        DepthOrArraySize = o.DepthOrArraySize;
        MipLevels = o.MipLevels;
        Format = o.Format;
        SampleDesc = o.SampleDesc;
        Layout = o.Layout;
        Flags = o.Flags;
        SamplerFeedbackMipRegion = new D3D12MipRegion { };
    }

    [return: NativeTypeName("UINT16")]
    public readonly ushort ArraySize()
    {
        return (Dimension != D3D12ResourceDimension.Texture3D ? DepthOrArraySize : (ushort)(1));
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC1")]
    public static D3D12ResourceDesc1 Buffer(
        [NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")]
            in D3D12ResourceAllocationInfo resAllocInfo,
        D3D12ResourceFlags flags = D3D12ResourceFlags.None
    )
    {
        return new D3D12ResourceDesc1(
            D3D12ResourceDimension.Buffer,
            resAllocInfo.Alignment,
            resAllocInfo.SizeInBytes,
            1,
            1,
            1,
            DxgiFormat.FormatUnknown,
            1,
            0,
            D3D12TextureLayout.LayoutRowMajor,
            flags,
            0,
            0,
            0
        );
    }

    [return: NativeTypeName("UINT16")]
    public readonly ushort Depth()
    {
        return (Dimension == D3D12ResourceDimension.Texture3D ? DepthOrArraySize : (ushort)(1));
    }

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12ResourceDesc1 other) && Equals(other);

    public readonly bool Equals(D3D12ResourceDesc1 other) => (this == other);

    public override readonly int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Dimension);
        hashCode.Add(Alignment);
        hashCode.Add(Width);
        hashCode.Add(Height);
        hashCode.Add(DepthOrArraySize);
        hashCode.Add(MipLevels);
        hashCode.Add(Format);
        hashCode.Add(SampleDesc.Count);
        hashCode.Add(SampleDesc.Quality);
        hashCode.Add(Layout);
        hashCode.Add(Flags);
        hashCode.Add(SamplerFeedbackMipRegion.Width);
        hashCode.Add(SamplerFeedbackMipRegion.Height);
        hashCode.Add(SamplerFeedbackMipRegion.Depth);
        return hashCode.ToHashCode();
    }
}
