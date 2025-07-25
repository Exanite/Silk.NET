// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE"]/*'/>
public enum D3D12DescriptorHeapType
{
    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV"]/*'/>

    CbvSrvUav = 0,

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER"]/*'/>

    Sampler = (CbvSrvUav + 1),

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_RTV"]/*'/>

    Rtv = (Sampler + 1),

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_DSV"]/*'/>

    Dsv = (Rtv + 1),

    /// <include file='D3D12_DESCRIPTOR_HEAP_TYPE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_TYPE.D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES"]/*'/>

    NumTypes = (Dsv + 1),
}
