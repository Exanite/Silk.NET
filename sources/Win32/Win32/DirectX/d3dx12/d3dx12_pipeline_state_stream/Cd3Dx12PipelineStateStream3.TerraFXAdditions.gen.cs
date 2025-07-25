// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

// Use CD3DX12_PIPELINE_STATE_STREAM3 for D3D12_DEPTH_STENCIL_DESC2 when CheckFeatureSupport returns true for Options14::IndependentFrontAndBackStencilSupported is true
public unsafe struct Cd3Dx12PipelineStateStream3
{
    public Cd3Dx12PipelineStateStreamFlags Flags;
    public Cd3Dx12PipelineStateStreamNodeMask NodeMask;
    public Cd3Dx12PipelineStateStreamRootSignature PRootSignature;
    public Cd3Dx12PipelineStateStreamInputLayout InputLayout;
    public Cd3Dx12PipelineStateStreamIbStripCutValue IBStripCutValue;
    public Cd3Dx12PipelineStateStreamPrimitiveTopology PrimitiveTopologyType;
    public Cd3Dx12PipelineStateStreamVs Vs;
    public Cd3Dx12PipelineStateStreamGs Gs;
    public Cd3Dx12PipelineStateStreamStreamOutput StreamOutput;
    public Cd3Dx12PipelineStateStreamHs Hs;
    public Cd3Dx12PipelineStateStreamDs Ds;
    public Cd3Dx12PipelineStateStreamPs Ps;
    public Cd3Dx12PipelineStateStreamAs As;
    public Cd3Dx12PipelineStateStreamMs Ms;
    public Cd3Dx12PipelineStateStreamCs Cs;
    public Cd3Dx12PipelineStateStreamBlendDesc BlendState;
    public Cd3Dx12PipelineStateStreamDepthStencil2 DepthStencilState;
    public Cd3Dx12PipelineStateStreamDepthStencilFormat DSVFormat;
    public Cd3Dx12PipelineStateStreamRasterizer RasterizerState;
    public Cd3Dx12PipelineStateStreamRenderTargetFormats RTVFormats;
    public Cd3Dx12PipelineStateStreamSampleDesc SampleDesc;
    public Cd3Dx12PipelineStateStreamSampleMask SampleMask;
    public Cd3Dx12PipelineStateStreamCachedPso CachedPSO;
    public Cd3Dx12PipelineStateStreamViewInstancing ViewInstancingDesc;

    // Mesh and amplification shaders must be set manually, since they do not have representation in D3D12_GRAPHICS_PIPELINE_STATE_DESC
    public CD3DX12_PIPELINE_STATE_STREAM3(
        [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC &")]
            in D3D12GraphicsPipelineStateDesc Desc
    )
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        PRootSignature = Desc.PRootSignature;
        InputLayout = Desc.InputLayout;
        IBStripCutValue = Desc.IBStripCutValue;
        PrimitiveTopologyType = Desc.PrimitiveTopologyType;
        Vs = Desc.Vs;
        Gs = Desc.Gs;
        StreamOutput = Desc.StreamOutput;
        Hs = Desc.Hs;
        Ds = Desc.Ds;
        Ps = Desc.Ps;
        BlendState = Desc.BlendState;
        DepthStencilState = new D3D12DepthStencilDesc2(Desc.DepthStencilState);
        DSVFormat = Desc.DSVFormat;
        RasterizerState = Desc.RasterizerState;
        fixed (DxgiFormat* pFormats = &Desc.RTVFormats[0])
        {
            RTVFormats = new D3D12RtFormatArray(pFormats, Desc.NumRenderTargets);
        }
        SampleDesc = Desc.SampleDesc;
        SampleMask = Desc.SampleMask;
        CachedPSO = Desc.CachedPSO;
        ViewInstancingDesc = D3D12ViewInstancingDesc.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM3(
        [NativeTypeName("const D3DX12_MESH_SHADER_PIPELINE_STATE_DESC &")]
            in D3DX12_MESH_SHADER_PIPELINE_STATE_DESC Desc
    )
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        PRootSignature = Desc.pRootSignature;
        PrimitiveTopologyType = Desc.PrimitiveTopologyType;
        Ps = Desc.PS;
        As = Desc.AS;
        Ms = Desc.MS;
        BlendState = Desc.BlendState;
        DepthStencilState = new D3D12_DEPTH_STENCIL_DESC2(Desc.DepthStencilState);
        DSVFormat = Desc.DSVFormat;
        RasterizerState = Desc.RasterizerState;
        fixed (DxgiFormat* pFormats = &Desc.RTVFormats[0])
        {
            RTVFormats = new D3D12_RT_FORMAT_ARRAY(pFormats, Desc.NumRenderTargets);
        }
        SampleDesc = Desc.SampleDesc;
        SampleMask = Desc.SampleMask;
        CachedPSO = Desc.CachedPSO;
        ViewInstancingDesc = D3D12ViewInstancingDesc.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM3(
        [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC &")]
            in D3D12ComputePipelineStateDesc Desc
    )
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        PRootSignature = Desc.PRootSignature;
        Cs = Desc.Cs;
        CachedPSO = Desc.CachedPSO;
        DepthStencilState.pssInner.DepthEnable = false;
    }

    public readonly D3D12ComputePipelineStateDesc ComputeDescV0() =>
        new D3D12ComputePipelineStateDesc
        {
            Flags = Flags,
            NodeMask = NodeMask,
            PRootSignature = PRootSignature,
            Cs = Cs,
            CachedPSO = CachedPSO,
        };

    public readonly D3D12GraphicsPipelineStateDesc GraphicsDescV0()
    {
        D3D12GraphicsPipelineStateDesc D = new D3D12GraphicsPipelineStateDesc
        {
            Flags = Flags,
            NodeMask = NodeMask,
            PRootSignature = PRootSignature,
            InputLayout = InputLayout,
            IBStripCutValue = IBStripCutValue,
            PrimitiveTopologyType = PrimitiveTopologyType,
            Vs = Vs,
            Gs = Gs,
            StreamOutput = StreamOutput,
            Hs = Hs,
            Ds = Ds,
            Ps = Ps,
            BlendState = BlendState,
            DepthStencilState = (D3D12DepthStencilDesc)(DepthStencilState.pssInner),
            DSVFormat = DSVFormat,
            RasterizerState = RasterizerState,
            NumRenderTargets = RTVFormats.pssInner.NumRenderTargets,
            SampleDesc = SampleDesc,
            SampleMask = SampleMask,
            CachedPSO = CachedPSO,
        };
        fixed (DxgiFormat* pFormat = &RTVFormats.pssInner.RTFormats[0])
        {
            NativeMemory.Copy(pFormat, &D.RTVFormats[0], 8 * sizeof(DxgiFormat));
        }
        return D;
    }
}
