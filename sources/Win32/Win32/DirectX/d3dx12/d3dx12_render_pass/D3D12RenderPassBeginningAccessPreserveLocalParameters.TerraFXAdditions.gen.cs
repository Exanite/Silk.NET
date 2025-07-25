// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12RenderPassBeginningAccessPreserveLocalParameters
    : IEquatable<D3D12RenderPassBeginningAccessPreserveLocalParameters>,
        IEquatable<D3D12RenderPassEndingAccessPreserveLocalParameters>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessPreserveLocalParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessPreserveLocalParameters b
    ) => (a.AdditionalWidth == b.AdditionalWidth) && (a.AdditionalHeight == b.AdditionalHeight);

    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessPreserveLocalParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassEndingAccessPreserveLocalParameters b
    ) => (a.AdditionalWidth == b.AdditionalWidth) && (a.AdditionalHeight == b.AdditionalHeight);

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessPreserveLocalParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessPreserveLocalParameters b
    ) => !(a == b);

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassBeginningAccessPreserveLocalParameters a,
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS &")]
            in D3D12RenderPassEndingAccessPreserveLocalParameters b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj is D3D12RenderPassBeginningAccessPreserveLocalParameters other1)
        {
            return Equals(other1);
        }
        else if (obj is D3D12RenderPassEndingAccessPreserveLocalParameters other2)
        {
            return Equals(other2);
        }
        else
        {
            return false;
        }
    }

    public readonly bool Equals(D3D12RenderPassBeginningAccessPreserveLocalParameters other) =>
        this == other;

    public readonly bool Equals(D3D12RenderPassEndingAccessPreserveLocalParameters other) =>
        this == other;

    public override readonly int GetHashCode() =>
        HashCode.Combine(AdditionalWidth, AdditionalHeight);
}
