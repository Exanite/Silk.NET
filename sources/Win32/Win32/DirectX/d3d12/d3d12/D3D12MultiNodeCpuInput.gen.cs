// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MULTI_NODE_CPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_CPU_INPUT"]/*'/>
public unsafe partial struct D3D12MultiNodeCpuInput
{
    /// <include file='D3D12_MULTI_NODE_CPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_CPU_INPUT.NumNodeInputs"]/*'/>

    public uint NumNodeInputs;

    /// <include file='D3D12_MULTI_NODE_CPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_CPU_INPUT.pNodeInputs"]/*'/>

    [NativeTypeName("const D3D12_NODE_CPU_INPUT *")]
    public D3D12NodeCpuInput* PNodeInputs;

    /// <include file='D3D12_MULTI_NODE_CPU_INPUT.xml' path='doc/member[@name="D3D12_MULTI_NODE_CPU_INPUT.NodeInputStrideInBytes"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong NodeInputStrideInBytes;
}
