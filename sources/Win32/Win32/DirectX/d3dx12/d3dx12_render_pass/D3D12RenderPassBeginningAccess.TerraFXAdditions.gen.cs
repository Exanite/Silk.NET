// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12RenderPassBeginningAccess : IEquatable<D3D12RenderPassBeginningAccess>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")]
            in D3D12RenderPassBeginningAccess a,
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")]
            in D3D12RenderPassBeginningAccess b
    )
    {
        if (a.Type != b.Type)
        {
            return false;
        }
        switch (a.Type)
        {
            case D3D12RenderPassBeginningAccessType.Clear:
            {
                if (a.Anonymous.Clear != b.Anonymous.Clear)
                {
                    return false;
                }
                break;
            }
            case D3D12RenderPassBeginningAccessType.PreserveLocalRender:
            case D3D12RenderPassBeginningAccessType.PreserveLocalSrv:
            case D3D12RenderPassBeginningAccessType.PreserveLocalUav:
            {
                if (a.Anonymous.PreserveLocal != b.Anonymous.PreserveLocal)
                {
                    return false;
                }
                break;
            }
        }
        return true;
    }

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")]
            in D3D12RenderPassBeginningAccess a,
        [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS &")]
            in D3D12RenderPassBeginningAccess b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12RenderPassBeginningAccess other) && Equals(other);

    public readonly bool Equals(D3D12RenderPassBeginningAccess other) => this == other;

    public override readonly int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Type);
        switch (Type)
        {
            case D3D12RenderPassBeginningAccessType.Clear:
            {
                hashCode.Add(Anonymous.Clear);
                break;
            }
            case D3D12RenderPassBeginningAccessType.PreserveLocalRender:
            case D3D12RenderPassBeginningAccessType.PreserveLocalSrv:
            case D3D12RenderPassBeginningAccessType.PreserveLocalUav:
            {
                hashCode.Add(Anonymous.PreserveLocal);
                break;
            }
        }
        return hashCode.ToHashCode();
    }
}
