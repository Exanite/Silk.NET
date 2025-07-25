// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12SubresourceFootprint
{
    public D3D12_SUBRESOURCE_FOOTPRINT(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12ResourceDesc resDesc,
        uint rowPitch
    )
    {
        Format = resDesc.Format;
        Width = (uint)(resDesc.Width);
        Height = resDesc.Height;
        Depth = (
            resDesc.Dimension == D3D12ResourceDimension.Texture3D ? resDesc.DepthOrArraySize : 1U
        );
        RowPitch = rowPitch;
    }
}
