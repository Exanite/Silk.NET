// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12RenderPassRenderTargetDesc : IEquatable<D3D12RenderPassRenderTargetDesc>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12RenderPassRenderTargetDesc a,
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12RenderPassRenderTargetDesc b
    )
    {
        if (a.CpuDescriptor.Ptr != b.CpuDescriptor.Ptr)
        {
            return false;
        }
        if (a.BeginningAccess != b.BeginningAccess)
        {
            return false;
        }
        if (a.EndingAccess != b.EndingAccess)
        {
            return false;
        }
        return true;
    }

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12RenderPassRenderTargetDesc a,
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12RenderPassRenderTargetDesc b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12RenderPassRenderTargetDesc other) && Equals(other);

    public readonly bool Equals(D3D12RenderPassRenderTargetDesc other) => this == other;

    public override readonly int GetHashCode() =>
        HashCode.Combine(CpuDescriptor.Ptr, BeginningAccess, EndingAccess);
}
