// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12TextureCopyLocation
{
    public D3D12_TEXTURE_COPY_LOCATION(
        ID3D12Resource pRes,
        [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT &")]
            in D3D12PlacedSubresourceFootprint Footprint
    )
    {
        PResource = pRes;
        Type = D3D12TextureCopyType.PlacedFootprint;
        Anonymous.PlacedFootprint = Footprint;
    }
}
