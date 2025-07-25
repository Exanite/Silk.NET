// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES"]/*'/>
public unsafe partial struct D3D12BroadcastingLaunchOverrides
{
    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pLocalRootArgumentsTableIndex"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* PLocalRootArgumentsTableIndex;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pProgramEntry"]/*'/>

    [NativeTypeName("const BOOL *")]
    public MaybeBool<int>* PProgramEntry;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pNewName"]/*'/>

    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12NodeId* PNewName;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pShareInputOf"]/*'/>

    [NativeTypeName("const D3D12_NODE_ID *")]
    public D3D12NodeId* PShareInputOf;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pDispatchGrid"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* PDispatchGrid;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pMaxDispatchGrid"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* PMaxDispatchGrid;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.NumOutputOverrides"]/*'/>

    public uint NumOutputOverrides;

    /// <include file='D3D12_BROADCASTING_LAUNCH_OVERRIDES.xml' path='doc/member[@name="D3D12_BROADCASTING_LAUNCH_OVERRIDES.pOutputOverrides"]/*'/>

    [NativeTypeName("const D3D12_NODE_OUTPUT_OVERRIDES *")]
    public D3D12NodeOutputOverrides* POutputOverrides;
}
