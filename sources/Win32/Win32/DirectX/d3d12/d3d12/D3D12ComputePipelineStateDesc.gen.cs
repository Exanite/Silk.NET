// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC"]/*'/>
public unsafe partial struct D3D12ComputePipelineStateDesc
{
    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.pRootSignature"]/*'/>

    public ID3D12RootSignature PRootSignature;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.CS"]/*'/>

    public D3D12ShaderBytecode Cs;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.CachedPSO"]/*'/>

    public D3D12CachedPipelineState CachedPSO;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.Flags"]/*'/>

    public D3D12PipelineStateFlags Flags;
}
