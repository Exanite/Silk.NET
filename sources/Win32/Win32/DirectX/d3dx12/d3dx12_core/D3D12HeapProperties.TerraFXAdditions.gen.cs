// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12HeapProperties : IEquatable<D3D12HeapProperties>
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Equals"]/*'/>

    public static bool operator ==(
        [NativeTypeName("const D3D12_HEAP_PROPERTIES &")] in D3D12HeapProperties l,
        [NativeTypeName("const D3D12_HEAP_PROPERTIES &")] in D3D12HeapProperties r
    ) =>
        (l.Type == r.Type)
        && (l.CPUPageProperty == r.CPUPageProperty)
        && (l.MemoryPoolPreference == r.MemoryPoolPreference)
        && (l.CreationNodeMask == r.CreationNodeMask)
        && (l.VisibleNodeMask == r.VisibleNodeMask);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.NotEquals"]/*'/>

    public static bool operator !=(
        [NativeTypeName("const D3D12_HEAP_PROPERTIES &")] in D3D12HeapProperties l,
        [NativeTypeName("const D3D12_HEAP_PROPERTIES &")] in D3D12HeapProperties r
    ) => !(l == r);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12HeapProperties other) && Equals(other);

    public readonly bool Equals(D3D12HeapProperties other) => (this == other);

    public override readonly int GetHashCode() =>
        HashCode.Combine(
            Type,
            CPUPageProperty,
            MemoryPoolPreference,
            CreationNodeMask,
            VisibleNodeMask
        );
}
