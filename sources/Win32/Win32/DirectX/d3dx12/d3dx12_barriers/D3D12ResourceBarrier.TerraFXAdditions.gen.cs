// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_barriers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER"]/*'/>
[NativeTypeName("struct CD3DX12_RESOURCE_BARRIER : D3D12_RESOURCE_BARRIER")]
[NativeInheritance("D3D12_RESOURCE_BARRIER")]
public unsafe partial struct D3D12ResourceBarrier
{
    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12ResourceBarrier InitAliasing(
        ID3D12Resource pResourceBefore,
        ID3D12Resource pResourceAfter
    )
    {
        Unsafe.SkipInit(out D3D12ResourceBarrier result);
        result.Type = D3D12ResourceBarrierType.Aliasing;
        result.Flags = D3D12ResourceBarrierFlags.None;
        result.Aliasing.PResourceBefore = pResourceBefore;
        result.Aliasing.PResourceAfter = pResourceAfter;
        return result;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12ResourceBarrier InitTransition(
        ID3D12Resource pResource,
        D3D12ResourceStates stateBefore,
        D3D12ResourceStates stateAfter,
        uint subresource = (0xffffffff),
        D3D12ResourceBarrierFlags flags = D3D12ResourceBarrierFlags.None
    )
    {
        Unsafe.SkipInit(out D3D12ResourceBarrier result);
        result.Type = D3D12ResourceBarrierType.Transition;
        result.Flags = flags;
        result.Anonymous.Transition.PResource = pResource;
        result.Anonymous.Transition.StateBefore = stateBefore;
        result.Anonymous.Transition.StateAfter = stateAfter;
        result.Anonymous.Transition.Subresource = subresource;
        return result;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12ResourceBarrier InitUAV(ID3D12Resource pResource)
    {
        Unsafe.SkipInit(out D3D12ResourceBarrier result);
        result.Type = D3D12ResourceBarrierType.Uav;
        result.Flags = D3D12ResourceBarrierFlags.None;
        result.Anonymous.UAV.PResource = pResource;
        return result;
    }
}
