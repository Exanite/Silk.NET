// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT2.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2"]/*'/>
public unsafe partial struct D3D12DredPageFaultOutput2
{
    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT2.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2.PageFaultVA"]/*'/>

    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong PageFaultVA;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT2.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2.pHeadExistingAllocationNode"]/*'/>

    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE1 *")]
    public D3D12DredAllocationNode1* PHeadExistingAllocationNode;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT2.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2.pHeadRecentFreedAllocationNode"]/*'/>

    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE1 *")]
    public D3D12DredAllocationNode1* PHeadRecentFreedAllocationNode;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT2.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT2.PageFaultFlags"]/*'/>

    public D3D12DredPageFaultFlags PageFaultFlags;
}
