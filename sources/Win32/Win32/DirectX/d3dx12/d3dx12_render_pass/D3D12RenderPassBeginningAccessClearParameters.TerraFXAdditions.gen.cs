// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12RenderPassBeginningAccessClearParameters
    : IEquatable<D3D12RenderPassBeginningAccessClearParameters>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessClearParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessClearParameters b
    ) => a.ClearValue == b.ClearValue;

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessClearParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessClearParameters b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12RenderPassBeginningAccessClearParameters other) && Equals(other);

    public readonly bool Equals(D3D12RenderPassBeginningAccessClearParameters other) =>
        this == other;

    public override readonly int GetHashCode() => ClearValue.GetHashCode();
}
