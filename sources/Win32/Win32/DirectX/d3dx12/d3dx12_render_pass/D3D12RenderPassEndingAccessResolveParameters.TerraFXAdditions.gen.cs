// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12RenderPassEndingAccessResolveParameters
    : IEquatable<D3D12RenderPassEndingAccessResolveParameters>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")]
            in D3D12RenderPassEndingAccessResolveParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")]
            in D3D12RenderPassEndingAccessResolveParameters b
    )
    {
        if (a.PSrcResource != b.PSrcResource)
        {
            return false;
        }
        if (a.PDstResource != b.PDstResource)
        {
            return false;
        }
        if (a.SubresourceCount != b.SubresourceCount)
        {
            return false;
        }
        if (a.Format != b.Format)
        {
            return false;
        }
        if (a.ResolveMode != b.ResolveMode)
        {
            return false;
        }
        if (a.PreserveResolveSource != b.PreserveResolveSource)
        {
            return false;
        }
        return true;
    }

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")]
            in D3D12RenderPassEndingAccessResolveParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS &")]
            in D3D12RenderPassEndingAccessResolveParameters b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12RenderPassEndingAccessResolveParameters other) && Equals(other);

    public readonly bool Equals(D3D12RenderPassEndingAccessResolveParameters other) =>
        this == other;

    public override readonly int GetHashCode() =>
        HashCode.Combine(
            (nuint)(PSrcResource),
            (nuint)(PDstResource),
            SubresourceCount,
            Format,
            ResolveMode,
            PreserveResolveSource
        );
}
