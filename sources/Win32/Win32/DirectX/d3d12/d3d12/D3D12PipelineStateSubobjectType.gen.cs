// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE"]/*'/>
public enum D3D12PipelineStateSubobjectType
{
    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE"]/*'/>

    RootSignature = 0,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS"]/*'/>

    Vs = (RootSignature + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS"]/*'/>

    Ps = (Vs + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS"]/*'/>

    Ds = (Ps + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS"]/*'/>

    Hs = (Ds + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS"]/*'/>

    Gs = (Hs + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS"]/*'/>

    Cs = (Gs + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT"]/*'/>

    StreamOutput = (Cs + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND"]/*'/>

    Blend = (StreamOutput + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK"]/*'/>

    SampleMask = (Blend + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER"]/*'/>

    Rasterizer = (SampleMask + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL"]/*'/>

    DepthStencil = (Rasterizer + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT"]/*'/>

    InputLayout = (DepthStencil + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE"]/*'/>

    IbStripCutValue = (InputLayout + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY"]/*'/>

    PrimitiveTopology = (IbStripCutValue + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS"]/*'/>

    RenderTargetFormats = (PrimitiveTopology + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT"]/*'/>

    DepthStencilFormat = (RenderTargetFormats + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC"]/*'/>

    SampleDesc = (DepthStencilFormat + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK"]/*'/>

    NodeMask = (SampleDesc + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO"]/*'/>

    CachedPso = (NodeMask + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS"]/*'/>

    Flags = (CachedPso + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1"]/*'/>

    DepthStencil1 = (Flags + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING"]/*'/>

    ViewInstancing = (DepthStencil1 + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS"]/*'/>

    As = 24,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS"]/*'/>

    Ms = 25,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2"]/*'/>

    DepthStencil2 = 26,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1"]/*'/>

    Rasterizer1 = 27,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2"]/*'/>

    Rasterizer2 = 28,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID"]/*'/>

    MaxValid = (Rasterizer2 + 1),
}
