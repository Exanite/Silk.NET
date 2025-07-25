// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE"]/*'/>
public enum D3D12StateSubobjectType
{
    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG"]/*'/>

    StateObjectConfig = 0,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE"]/*'/>

    GlobalRootSignature = 1,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE"]/*'/>

    LocalRootSignature = 2,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK"]/*'/>

    NodeMask = 3,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY"]/*'/>

    DxilLibrary = 5,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION"]/*'/>

    ExistingCollection = 6,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*'/>

    SubobjectToExportsAssociation = 7,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*'/>

    DxilSubobjectToExportsAssociation = 8,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG"]/*'/>

    RaytracingShaderConfig = 9,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG"]/*'/>

    RaytracingPipelineConfig = 10,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP"]/*'/>

    HitGroup = 11,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1"]/*'/>

    RaytracingPipelineConfig1 = 12,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_WORK_GRAPH"]/*'/>

    WorkGraph = 13,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT"]/*'/>

    StreamOutput = 14,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_BLEND"]/*'/>

    Blend = 15,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_SAMPLE_MASK"]/*'/>

    SampleMask = 16,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RASTERIZER"]/*'/>

    Rasterizer = 17,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL"]/*'/>

    DepthStencil = 18,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT"]/*'/>

    InputLayout = 19,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE"]/*'/>

    IbStripCutValue = 20,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY"]/*'/>

    PrimitiveTopology = 21,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS"]/*'/>

    RenderTargetFormats = 22,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT"]/*'/>

    DepthStencilFormat = 23,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_SAMPLE_DESC"]/*'/>

    SampleDesc = 24,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_FLAGS"]/*'/>

    Flags = 26,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1"]/*'/>

    DepthStencil1 = 27,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING"]/*'/>

    ViewInstancing = 28,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_GENERIC_PROGRAM"]/*'/>

    GenericProgram = 29,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2"]/*'/>

    DepthStencil2 = 30,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID"]/*'/>

    MaxValid = (DepthStencil2 + 1),
}
