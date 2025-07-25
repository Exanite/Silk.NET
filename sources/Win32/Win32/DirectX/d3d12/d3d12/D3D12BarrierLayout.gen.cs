// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT"]/*'/>
public enum D3D12BarrierLayout
{
    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_UNDEFINED"]/*'/>

    Undefined = unchecked((int)(0xffffffff)),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMMON"]/*'/>

    Common = 0,

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_PRESENT"]/*'/>

    Present = 0,

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_GENERIC_READ"]/*'/>

    GenericRead = (Present + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_RENDER_TARGET"]/*'/>

    RenderTarget = (GenericRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_UNORDERED_ACCESS"]/*'/>

    UnorderedAccess = (RenderTarget + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_WRITE"]/*'/>

    DepthStencilWrite = (UnorderedAccess + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DEPTH_STENCIL_READ"]/*'/>

    DepthStencilRead = (DepthStencilWrite + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_SHADER_RESOURCE"]/*'/>

    ShaderResource = (DepthStencilRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COPY_SOURCE"]/*'/>

    CopySource = (ShaderResource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COPY_DEST"]/*'/>

    CopyDest = (CopySource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_RESOLVE_SOURCE"]/*'/>

    ResolveSource = (CopyDest + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_RESOLVE_DEST"]/*'/>

    ResolveDest = (ResolveSource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_SHADING_RATE_SOURCE"]/*'/>

    ShadingRateSource = (ResolveDest + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_DECODE_READ"]/*'/>

    VideoDecodeRead = (ShadingRateSource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_DECODE_WRITE"]/*'/>

    VideoDecodeWrite = (VideoDecodeRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_READ"]/*'/>

    VideoProcessRead = (VideoDecodeWrite + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_PROCESS_WRITE"]/*'/>

    VideoProcessWrite = (VideoProcessRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ"]/*'/>

    VideoEncodeRead = (VideoProcessWrite + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE"]/*'/>

    VideoEncodeWrite = (VideoEncodeRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COMMON"]/*'/>

    DirectQueueCommon = (VideoEncodeWrite + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_GENERIC_READ"]/*'/>

    DirectQueueGenericRead = (DirectQueueCommon + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_UNORDERED_ACCESS"]/*'/>

    DirectQueueUnorderedAccess = (DirectQueueGenericRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_SHADER_RESOURCE"]/*'/>

    DirectQueueShaderResource = (DirectQueueUnorderedAccess + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_SOURCE"]/*'/>

    DirectQueueCopySource = (DirectQueueShaderResource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_DIRECT_QUEUE_COPY_DEST"]/*'/>

    DirectQueueCopyDest = (DirectQueueCopySource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COMMON"]/*'/>

    ComputeQueueCommon = (DirectQueueCopyDest + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_GENERIC_READ"]/*'/>

    ComputeQueueGenericRead = (ComputeQueueCommon + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_UNORDERED_ACCESS"]/*'/>

    ComputeQueueUnorderedAccess = (ComputeQueueGenericRead + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_SHADER_RESOURCE"]/*'/>

    ComputeQueueShaderResource = (ComputeQueueUnorderedAccess + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_SOURCE"]/*'/>

    ComputeQueueCopySource = (ComputeQueueShaderResource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_COMPUTE_QUEUE_COPY_DEST"]/*'/>

    ComputeQueueCopyDest = (ComputeQueueCopySource + 1),

    /// <include file='D3D12_BARRIER_LAYOUT.xml' path='doc/member[@name="D3D12_BARRIER_LAYOUT.D3D12_BARRIER_LAYOUT_VIDEO_QUEUE_COMMON"]/*'/>

    VideoQueueCommon = (ComputeQueueCopyDest + 1),
}
