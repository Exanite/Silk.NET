// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES"]/*'/>
public unsafe partial struct D3D12NodeOutputOverrides
{
    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.OutputIndex"]/*'/>

    public uint OutputIndex;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pNewName"]/*'/>

    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12NodeId* PNewName;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pAllowSparseNodes"]/*'/>

    [NativeTypeName("const BOOL *")]
    public MaybeBool<int>* PAllowSparseNodes;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pMaxRecords"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* PMaxRecords;

    /// <include file='D3D12_NODE_OUTPUT_OVERRIDES.xml' path='doc/member[@name="D3D12_NODE_OUTPUT_OVERRIDES.pMaxRecordsSharedWithOutputIndex"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* PMaxRecordsSharedWithOutputIndex;
}
