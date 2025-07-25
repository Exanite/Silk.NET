// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12CpuDescriptorHandle : IEquatable<D3D12CpuDescriptorHandle>
{
    public static D3D12CpuDescriptorHandle DEFAULT => default;

    public D3D12_CPU_DESCRIPTOR_HANDLE(
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE &")] in D3D12CpuDescriptorHandle other,
        int offsetScaledByIncrementSize
    )
    {
        InitOffsetted(in other, offsetScaledByIncrementSize);
    }

    public D3D12_CPU_DESCRIPTOR_HANDLE(
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE &")] in D3D12CpuDescriptorHandle other,
        int offsetInDescriptors,
        uint descriptorIncrementSize
    )
    {
        InitOffsetted(in other, offsetInDescriptors, descriptorIncrementSize);
    }

    public static bool operator ==(D3D12CpuDescriptorHandle left, D3D12CpuDescriptorHandle right) =>
        left.Ptr == right.Ptr;

    public static bool operator !=(D3D12CpuDescriptorHandle left, D3D12CpuDescriptorHandle right) =>
        left.Ptr != right.Ptr;

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12CpuDescriptorHandle other) && Equals(other);

    public readonly bool Equals(D3D12CpuDescriptorHandle other) => this == other;

    public override readonly int GetHashCode() => Ptr.GetHashCode();

    public void InitOffsetted(
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE &")] in D3D12CpuDescriptorHandle @base,
        int offsetScaledByIncrementSize
    )
    {
        InitOffsetted(ref this, @base, offsetScaledByIncrementSize);
    }

    public void InitOffsetted(
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE &")] in D3D12CpuDescriptorHandle @base,
        int offsetInDescriptors,
        uint descriptorIncrementSize
    )
    {
        InitOffsetted(ref this, @base, offsetInDescriptors, descriptorIncrementSize);
    }

    public static void InitOffsetted(
        [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE &")] ref D3D12CpuDescriptorHandle handle,
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE &")] in D3D12CpuDescriptorHandle @base,
        int offsetScaledByIncrementSize
    )
    {
        handle.Ptr = unchecked((nuint)((long)(@base.Ptr) + (long)(offsetScaledByIncrementSize)));
    }

    public static void InitOffsetted(
        [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE &")] ref D3D12CpuDescriptorHandle handle,
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE &")] in D3D12CpuDescriptorHandle @base,
        int offsetInDescriptors,
        uint descriptorIncrementSize
    )
    {
        handle.Ptr = unchecked(
            (nuint)(
                (long)(@base.Ptr) + (long)(offsetInDescriptors) * (long)(descriptorIncrementSize)
            )
        );
    }

    [UnscopedRef]
    [return: NativeTypeName("CD3DX12_CPU_DESCRIPTOR_HANDLE &")]
    public ref D3D12CpuDescriptorHandle Offset(
        int offsetInDescriptors,
        uint descriptorIncrementSize
    )
    {
        Ptr = unchecked(
            (nuint)((long)(Ptr) + (long)(offsetInDescriptors) * (long)(descriptorIncrementSize))
        );
        return ref this;
    }

    [UnscopedRef]
    [return: NativeTypeName("CD3DX12_CPU_DESCRIPTOR_HANDLE &")]
    public ref D3D12CpuDescriptorHandle Offset(int offsetScaledByIncrementSize)
    {
        Ptr = unchecked((nuint)((long)(Ptr) + (long)(offsetScaledByIncrementSize)));
        return ref this;
    }
}
