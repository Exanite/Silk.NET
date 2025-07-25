// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES"]/*'/>
[Flags]
public enum D3D12GraphicsStates
{
    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS"]/*'/>

    IaVertexBuffers = (1 << 0),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER"]/*'/>

    IaIndexBuffer = (1 << 1),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY"]/*'/>

    IaPrimitiveTopology = (1 << 2),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP"]/*'/>

    DescriptorHeap = (1 << 3),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE"]/*'/>

    GraphicsRootSignature = (1 << 4),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE"]/*'/>

    ComputeRootSignature = (1 << 5),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_RS_VIEWPORTS"]/*'/>

    RsViewports = (1 << 6),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS"]/*'/>

    RsScissorRects = (1 << 7),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_PREDICATION"]/*'/>

    Predication = (1 << 8),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS"]/*'/>

    OmRenderTargets = (1 << 9),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_STENCIL_REF"]/*'/>

    OmStencilRef = (1 << 10),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR"]/*'/>

    OmBlendFactor = (1 << 11),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_PIPELINE_STATE"]/*'/>

    PipelineState = (1 << 12),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_SO_TARGETS"]/*'/>

    SoTargets = (1 << 13),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS"]/*'/>

    OmDepthBounds = (1 << 14),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS"]/*'/>

    SamplePositions = (1 << 15),

    /// <include file='D3D12_GRAPHICS_STATES.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES.D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK"]/*'/>

    ViewInstanceMask = (1 << 16),
}
