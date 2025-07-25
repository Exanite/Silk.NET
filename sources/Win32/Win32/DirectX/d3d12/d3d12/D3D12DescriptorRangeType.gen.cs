// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DESCRIPTOR_RANGE_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_TYPE"]/*'/>
public enum D3D12DescriptorRangeType
{
    /// <include file='D3D12_DESCRIPTOR_RANGE_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_TYPE.D3D12_DESCRIPTOR_RANGE_TYPE_SRV"]/*'/>

    Srv = 0,

    /// <include file='D3D12_DESCRIPTOR_RANGE_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_TYPE.D3D12_DESCRIPTOR_RANGE_TYPE_UAV"]/*'/>

    Uav = (Srv + 1),

    /// <include file='D3D12_DESCRIPTOR_RANGE_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_TYPE.D3D12_DESCRIPTOR_RANGE_TYPE_CBV"]/*'/>

    Cbv = (Uav + 1),

    /// <include file='D3D12_DESCRIPTOR_RANGE_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE_TYPE.D3D12_DESCRIPTOR_RANGE_TYPE_SAMPLER"]/*'/>

    Sampler = (Cbv + 1),
}
