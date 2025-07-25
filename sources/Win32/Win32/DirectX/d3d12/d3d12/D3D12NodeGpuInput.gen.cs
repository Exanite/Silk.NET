// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_NODE_GPU_INPUT"]/*'/>
public partial struct D3D12NodeGpuInput
{
    /// <include file='D3D12_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_NODE_GPU_INPUT.EntrypointIndex"]/*'/>

    public uint EntrypointIndex;

    /// <include file='D3D12_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_NODE_GPU_INPUT.NumRecords"]/*'/>

    public uint NumRecords;

    /// <include file='D3D12_NODE_GPU_INPUT.xml' path='doc/member[@name="D3D12_NODE_GPU_INPUT.Records"]/*'/>

    public D3D12GpuVirtualAddressAndStride Records;
}
