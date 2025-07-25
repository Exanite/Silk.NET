// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12TextureBarrier
{
    public D3D12_TEXTURE_BARRIER(
        D3D12BarrierSync syncBefore,
        D3D12BarrierSync syncAfter,
        D3D12BarrierAccess accessBefore,
        D3D12BarrierAccess accessAfter,
        D3D12BarrierLayout layoutBefore,
        D3D12BarrierLayout layoutAfter,
        ID3D12Resource pRes,
        [NativeTypeName("const D3D12_BARRIER_SUBRESOURCE_RANGE &")]
            in D3D12BarrierSubresourceRange subresources,
        D3D12TextureBarrierFlags flag = D3D12TextureBarrierFlags.None
    )
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
        LayoutBefore = layoutBefore;
        LayoutAfter = layoutAfter;
        PResource = pRes;
        Subresources = subresources;
        Flags = flag;
    }
}
