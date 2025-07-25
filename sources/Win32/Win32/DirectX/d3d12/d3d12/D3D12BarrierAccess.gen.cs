// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS"]/*'/>
public enum D3D12BarrierAccess
{
    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_COMMON"]/*'/>

    Common = 0,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VERTEX_BUFFER"]/*'/>

    VertexBuffer = 0x1,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_CONSTANT_BUFFER"]/*'/>

    ConstantBuffer = 0x2,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_INDEX_BUFFER"]/*'/>

    IndexBuffer = 0x4,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_RENDER_TARGET"]/*'/>

    RenderTarget = 0x8,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_UNORDERED_ACCESS"]/*'/>

    UnorderedAccess = 0x10,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_DEPTH_STENCIL_WRITE"]/*'/>

    DepthStencilWrite = 0x20,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_DEPTH_STENCIL_READ"]/*'/>

    DepthStencilRead = 0x40,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_SHADER_RESOURCE"]/*'/>

    ShaderResource = 0x80,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_STREAM_OUTPUT"]/*'/>

    StreamOutput = 0x100,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_INDIRECT_ARGUMENT"]/*'/>

    IndirectArgument = 0x200,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_PREDICATION"]/*'/>

    Predication = 0x200,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_COPY_DEST"]/*'/>

    CopyDest = 0x400,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_COPY_SOURCE"]/*'/>

    CopySource = 0x800,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_RESOLVE_DEST"]/*'/>

    ResolveDest = 0x1000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_RESOLVE_SOURCE"]/*'/>

    ResolveSource = 0x2000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_READ"]/*'/>

    RaytracingAccelerationStructureRead = 0x4000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_WRITE"]/*'/>

    RaytracingAccelerationStructureWrite = 0x8000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_SHADING_RATE_SOURCE"]/*'/>

    ShadingRateSource = 0x10000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VIDEO_DECODE_READ"]/*'/>

    VideoDecodeRead = 0x20000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VIDEO_DECODE_WRITE"]/*'/>

    VideoDecodeWrite = 0x40000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VIDEO_PROCESS_READ"]/*'/>

    VideoProcessRead = 0x80000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VIDEO_PROCESS_WRITE"]/*'/>

    VideoProcessWrite = 0x100000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VIDEO_ENCODE_READ"]/*'/>

    VideoEncodeRead = 0x200000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_VIDEO_ENCODE_WRITE"]/*'/>

    VideoEncodeWrite = 0x400000,

    /// <include file='D3D12_BARRIER_ACCESS.xml' path='doc/member[@name="D3D12_BARRIER_ACCESS.D3D12_BARRIER_ACCESS_NO_ACCESS"]/*'/>

    NoAccess = unchecked((int)(0x80000000)),
}
