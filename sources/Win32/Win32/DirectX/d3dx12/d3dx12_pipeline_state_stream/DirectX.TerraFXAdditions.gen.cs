// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static HResult D3DX12ParsePipelineStream(
        [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC &")]
            in D3D12PipelineStateStreamDesc Desc,
        ID3DX12PipelineParserCallbacks pCallbacks
    )
    {
        if (pCallbacks.LpVtbl == null)
        {
            return E_INVALIDARG;
        }
        if (Desc.SizeInBytes == 0 || Desc.PPipelineStateSubobjectStream == null)
        {
            pCallbacks.ErrorBadInputParameter(1); // first parameter issue
            return E_INVALIDARG;
        }
        bool* SubobjectSeen = stackalloc bool[(int)(D3D12PipelineStateSubobjectType.MaxValid)];
        for (
            nuint CurOffset = 0, SizeOfSubobject = 0;
            CurOffset < Desc.SizeInBytes;
            CurOffset += SizeOfSubobject
        )
        {
            byte* pStream = (byte*)(Desc.PPipelineStateSubobjectStream) + CurOffset;
            D3D12PipelineStateSubobjectType SubobjectType = *(D3D12PipelineStateSubobjectType*)(
                pStream
            );
            if ((SubobjectType < 0) || (SubobjectType >= D3D12PipelineStateSubobjectType.MaxValid))
            {
                pCallbacks.ErrorUnknownSubobject((uint)(SubobjectType));
                return E_INVALIDARG;
            }
            if (SubobjectSeen[(int)(D3DX12GetBaseSubobjectType(SubobjectType))])
            {
                pCallbacks.ErrorDuplicateSubobject(SubobjectType);
                return E_INVALIDARG; // disallow subobject duplicates in a stream
            }
            SubobjectSeen[(int)(SubobjectType)] = true;
            switch (SubobjectType)
            {
                case D3D12PipelineStateSubobjectType.RootSignature:
                {
                    pCallbacks.RootSignatureCb(
                        ((Cd3Dx12PipelineStateStreamRootSignature*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamRootSignature));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Vs:
                {
                    pCallbacks.VSCb(
                        &((Cd3Dx12PipelineStateStreamVs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamVs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Ps:
                {
                    pCallbacks.PSCb(
                        &((Cd3Dx12PipelineStateStreamPs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamPs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Ds:
                {
                    pCallbacks.DSCb(
                        &((Cd3Dx12PipelineStateStreamDs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamDs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Hs:
                {
                    pCallbacks.HSCb(
                        &((Cd3Dx12PipelineStateStreamHs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamHs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Gs:
                {
                    pCallbacks.GSCb(
                        &((Cd3Dx12PipelineStateStreamGs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamGs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Cs:
                {
                    pCallbacks.CSCb(
                        &((Cd3Dx12PipelineStateStreamCs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamCs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.As:
                {
                    pCallbacks.ASCb(
                        &((Cd3Dx12PipelineStateStreamAs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamAs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Ms:
                {
                    pCallbacks.MSCb(
                        &((Cd3Dx12PipelineStateStreamMs*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamMs));
                    break;
                }
                case D3D12PipelineStateSubobjectType.StreamOutput:
                {
                    pCallbacks.StreamOutputCb(
                        &((Cd3Dx12PipelineStateStreamStreamOutput*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamStreamOutput));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Blend:
                {
                    pCallbacks.BlendStateCb(
                        &((Cd3Dx12PipelineStateStreamBlendDesc*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamBlendDesc));
                    break;
                }
                case D3D12PipelineStateSubobjectType.SampleMask:
                {
                    pCallbacks.SampleMaskCb(
                        ((Cd3Dx12PipelineStateStreamSampleMask*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamSampleMask));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Rasterizer:
                {
                    pCallbacks.RasterizerStateCb(
                        &((Cd3Dx12PipelineStateStreamRasterizer*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamRasterizer));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Rasterizer1:
                {
                    pCallbacks.RasterizerState1Cb(
                        &((Cd3Dx12PipelineStateStreamRasterizer1*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamRasterizer1));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Rasterizer2:
                {
                    pCallbacks.RasterizerState2Cb(
                        &((Cd3Dx12PipelineStateStreamRasterizer2*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamRasterizer2));
                    break;
                }
                case D3D12PipelineStateSubobjectType.DepthStencil:
                {
                    pCallbacks.DepthStencilStateCb(
                        &((Cd3Dx12PipelineStateStreamDepthStencil*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamDepthStencil));
                    break;
                }
                case D3D12PipelineStateSubobjectType.DepthStencil1:
                {
                    pCallbacks.DepthStencilState1Cb(
                        &((Cd3Dx12PipelineStateStreamDepthStencil1*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamDepthStencil1));
                    break;
                }
                case D3D12PipelineStateSubobjectType.DepthStencil2:
                {
                    pCallbacks.DepthStencilState2Cb(
                        &((Cd3Dx12PipelineStateStreamDepthStencil2*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamDepthStencil2));
                    break;
                }
                case D3D12PipelineStateSubobjectType.InputLayout:
                {
                    pCallbacks.InputLayoutCb(
                        &((Cd3Dx12PipelineStateStreamInputLayout*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamInputLayout));
                    break;
                }
                case D3D12PipelineStateSubobjectType.IbStripCutValue:
                {
                    pCallbacks.IBStripCutValueCb(
                        ((Cd3Dx12PipelineStateStreamIbStripCutValue*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamIbStripCutValue));
                    break;
                }
                case D3D12PipelineStateSubobjectType.PrimitiveTopology:
                {
                    pCallbacks.PrimitiveTopologyTypeCb(
                        ((Cd3Dx12PipelineStateStreamPrimitiveTopology*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamPrimitiveTopology));
                    break;
                }
                case D3D12PipelineStateSubobjectType.RenderTargetFormats:
                {
                    pCallbacks.RTVFormatsCb(
                        &((Cd3Dx12PipelineStateStreamRenderTargetFormats*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamRenderTargetFormats));
                    break;
                }
                case D3D12PipelineStateSubobjectType.DepthStencilFormat:
                {
                    pCallbacks.DSVFormatCb(
                        ((Cd3Dx12PipelineStateStreamDepthStencilFormat*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamDepthStencilFormat));
                    break;
                }
                case D3D12PipelineStateSubobjectType.SampleDesc:
                {
                    pCallbacks.SampleDescCb(
                        &((Cd3Dx12PipelineStateStreamSampleDesc*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamSampleDesc));
                    break;
                }
                case D3D12PipelineStateSubobjectType.NodeMask:
                {
                    pCallbacks.NodeMaskCb(
                        ((Cd3Dx12PipelineStateStreamNodeMask*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamNodeMask));
                    break;
                }
                case D3D12PipelineStateSubobjectType.CachedPso:
                {
                    pCallbacks.CachedPSOCb(
                        &((Cd3Dx12PipelineStateStreamCachedPso*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamCachedPso));
                    break;
                }
                case D3D12PipelineStateSubobjectType.Flags:
                {
                    pCallbacks.FlagsCb(
                        ((Cd3Dx12PipelineStateStreamFlags*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamFlags));
                    break;
                }
                case D3D12PipelineStateSubobjectType.ViewInstancing:
                {
                    pCallbacks.ViewInstancingCb(
                        &((Cd3Dx12PipelineStateStreamViewInstancing*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(Cd3Dx12PipelineStateStreamViewInstancing));
                    break;
                }
                default:
                {
                    pCallbacks.ErrorUnknownSubobject((uint)(SubobjectType));
                    return E_INVALIDARG;
                }
            }
        }
        return S_OK;
    }
}
