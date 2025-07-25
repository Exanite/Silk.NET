// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT"]/*'/>
public unsafe partial struct D3D12DredPageFaultOutput
{
    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT.PageFaultVA"]/*'/>

    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong PageFaultVA;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT.pHeadExistingAllocationNode"]/*'/>

    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE *")]
    public D3D12DredAllocationNode* PHeadExistingAllocationNode;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT.pHeadRecentFreedAllocationNode"]/*'/>

    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE *")]
    public D3D12DredAllocationNode* PHeadRecentFreedAllocationNode;
}
