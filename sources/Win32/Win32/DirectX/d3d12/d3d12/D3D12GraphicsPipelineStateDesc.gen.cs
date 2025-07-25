// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC"]/*'/>
public unsafe partial struct D3D12GraphicsPipelineStateDesc
{
    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.pRootSignature"]/*'/>

    public ID3D12RootSignature PRootSignature;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.VS"]/*'/>

    public D3D12ShaderBytecode Vs;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.PS"]/*'/>

    public D3D12ShaderBytecode Ps;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.DS"]/*'/>

    public D3D12ShaderBytecode Ds;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.HS"]/*'/>

    public D3D12ShaderBytecode Hs;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.GS"]/*'/>

    public D3D12ShaderBytecode Gs;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.StreamOutput"]/*'/>

    public D3D12StreamOutputDesc StreamOutput;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.BlendState"]/*'/>

    public D3D12BlendDesc BlendState;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.SampleMask"]/*'/>

    public uint SampleMask;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.RasterizerState"]/*'/>

    public D3D12RasterizerDesc RasterizerState;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.DepthStencilState"]/*'/>

    public D3D12DepthStencilDesc DepthStencilState;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.InputLayout"]/*'/>

    public D3D12InputLayoutDesc InputLayout;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.IBStripCutValue"]/*'/>

    public D3D12IndexBufferStripCutValue IBStripCutValue;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.PrimitiveTopologyType"]/*'/>

    public D3D12PrimitiveTopologyType PrimitiveTopologyType;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.NumRenderTargets"]/*'/>

    public uint NumRenderTargets;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.RTVFormats"]/*'/>

    [NativeTypeName("DXGI_FORMAT[8]")]
    public _RTVFormats_e__FixedBuffer RTVFormats;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.DSVFormat"]/*'/>

    public DxgiFormat DSVFormat;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.SampleDesc"]/*'/>

    public DxgiSampleDesc SampleDesc;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.CachedPSO"]/*'/>

    public D3D12CachedPipelineState CachedPSO;

    /// <include file='D3D12_GRAPHICS_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_GRAPHICS_PIPELINE_STATE_DESC.Flags"]/*'/>

    public D3D12PipelineStateFlags Flags;

    /// <include file='_RTVFormats_e__FixedBuffer.xml' path='doc/member[@name="_RTVFormats_e__FixedBuffer"]/*'/>

    [InlineArray(8)]
    public partial struct _RTVFormats_e__FixedBuffer
    {
        public DxgiFormat e0;
    }
}
