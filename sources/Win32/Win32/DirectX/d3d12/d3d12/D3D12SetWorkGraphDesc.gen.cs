// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC"]/*'/>
public partial struct D3D12SetWorkGraphDesc
{
    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.ProgramIdentifier"]/*'/>

    public D3D12ProgramIdentifier ProgramIdentifier;

    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.Flags"]/*'/>

    public D3D12SetWorkGraphFlags Flags;

    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.BackingMemory"]/*'/>

    public D3D12GpuVirtualAddressRange BackingMemory;

    /// <include file='D3D12_SET_WORK_GRAPH_DESC.xml' path='doc/member[@name="D3D12_SET_WORK_GRAPH_DESC.NodeLocalRootArgumentsTable"]/*'/>

    public D3D12GpuVirtualAddressRangeAndStride NodeLocalRootArgumentsTable;
}
