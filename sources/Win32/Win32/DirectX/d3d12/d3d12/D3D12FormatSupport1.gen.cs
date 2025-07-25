// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1"]/*'/>
[Flags]
public enum D3D12FormatSupport1
{
    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_BUFFER"]/*'/>

    Buffer = 0x1,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER"]/*'/>

    IaVertexBuffer = 0x2,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER"]/*'/>

    IaIndexBuffer = 0x4,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SO_BUFFER"]/*'/>

    SoBuffer = 0x8,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURE1D"]/*'/>

    Texture1D = 0x10,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURE2D"]/*'/>

    Texture2D = 0x20,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURE3D"]/*'/>

    Texture3D = 0x40,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURECUBE"]/*'/>

    Texturecube = 0x80,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_LOAD"]/*'/>

    ShaderLoad = 0x100,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE"]/*'/>

    ShaderSample = 0x200,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON"]/*'/>

    ShaderSampleComparison = 0x400,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT"]/*'/>

    ShaderSampleMonoText = 0x800,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MIP"]/*'/>

    Mip = 0x1000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_RENDER_TARGET"]/*'/>

    RenderTarget = 0x4000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_BLENDABLE"]/*'/>

    Blendable = 0x8000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL"]/*'/>

    DepthStencil = 0x10000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE"]/*'/>

    MultisampleResolve = 0x40000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_DISPLAY"]/*'/>

    Display = 0x80000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT"]/*'/>

    CastWithinBitLayout = 0x100000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET"]/*'/>

    MultisampleRendertarget = 0x200000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD"]/*'/>

    MultisampleLoad = 0x400000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_GATHER"]/*'/>

    ShaderGather = 0x800000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST"]/*'/>

    BackBufferCast = 0x1000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW"]/*'/>

    TypedUnorderedAccessView = 0x2000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON"]/*'/>

    ShaderGatherComparison = 0x4000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT"]/*'/>

    DecoderOutput = 0x8000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT"]/*'/>

    VideoProcessorOutput = 0x10000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT"]/*'/>

    VideoProcessorInput = 0x20000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER"]/*'/>

    VideoEncoder = 0x40000000,
}
