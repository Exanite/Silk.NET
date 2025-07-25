// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe struct Cd3Dx12PipelineMeshStateStream
{
    public Cd3Dx12PipelineStateStreamFlags Flags;
    public Cd3Dx12PipelineStateStreamNodeMask NodeMask;
    public Cd3Dx12PipelineStateStreamRootSignature PRootSignature;
    public Cd3Dx12PipelineStateStreamPs Ps;
    public Cd3Dx12PipelineStateStreamAs As;
    public Cd3Dx12PipelineStateStreamMs Ms;
    public Cd3Dx12PipelineStateStreamBlendDesc BlendState;
    public Cd3Dx12PipelineStateStreamDepthStencil1 DepthStencilState;
    public Cd3Dx12PipelineStateStreamDepthStencilFormat DSVFormat;
    public Cd3Dx12PipelineStateStreamRasterizer RasterizerState;
    public Cd3Dx12PipelineStateStreamRenderTargetFormats RTVFormats;
    public Cd3Dx12PipelineStateStreamSampleDesc SampleDesc;
    public Cd3Dx12PipelineStateStreamSampleMask SampleMask;
    public Cd3Dx12PipelineStateStreamCachedPso CachedPSO;
    public Cd3Dx12PipelineStateStreamViewInstancing ViewInstancingDesc;

    public CD3DX12_PIPELINE_MESH_STATE_STREAM(
        [NativeTypeName("const D3DX12_MESH_SHADER_PIPELINE_STATE_DESC &")]
            in D3DX12_MESH_SHADER_PIPELINE_STATE_DESC Desc
    )
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        PRootSignature = Desc.pRootSignature;
        Ps = Desc.PS;
        As = Desc.AS;
        Ms = Desc.MS;
        BlendState = Desc.BlendState;
        DepthStencilState = new D3D12_DEPTH_STENCIL_DESC1(Desc.DepthStencilState);
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

    public readonly D3DX12_MESH_SHADER_PIPELINE_STATE_DESC MeshShaderDescV0()
    {
        D3DX12_MESH_SHADER_PIPELINE_STATE_DESC D = new D3DX12_MESH_SHADER_PIPELINE_STATE_DESC
        {
            Flags = Flags,
            NodeMask = NodeMask,
            pRootSignature = PRootSignature,
            PS = Ps,
            AS = As,
            MS = Ms,
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
