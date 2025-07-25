// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC"]/*'/>
public enum D3D12BarrierSync
{
    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_ALL"]/*'/>

    All = 0x1,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_DRAW"]/*'/>

    Draw = 0x2,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_INDEX_INPUT"]/*'/>

    IndexInput = 0x4,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VERTEX_SHADING"]/*'/>

    VertexShading = 0x8,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_PIXEL_SHADING"]/*'/>

    PixelShading = 0x10,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_DEPTH_STENCIL"]/*'/>

    DepthStencil = 0x20,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_RENDER_TARGET"]/*'/>

    RenderTarget = 0x40,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_COMPUTE_SHADING"]/*'/>

    ComputeShading = 0x80,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_RAYTRACING"]/*'/>

    Raytracing = 0x100,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_COPY"]/*'/>

    Copy = 0x200,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_RESOLVE"]/*'/>

    Resolve = 0x400,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_EXECUTE_INDIRECT"]/*'/>

    ExecuteIndirect = 0x800,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_PREDICATION"]/*'/>

    Predication = 0x800,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_ALL_SHADING"]/*'/>

    AllShading = 0x1000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_NON_PIXEL_SHADING"]/*'/>

    NonPixelShading = 0x2000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO"]/*'/>

    EmitRaytracingAccelerationStructurePostbuildInfo = 0x4000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_CLEAR_UNORDERED_ACCESS_VIEW"]/*'/>

    ClearUnorderedAccessView = 0x8000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VIDEO_DECODE"]/*'/>

    VideoDecode = 0x100000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VIDEO_PROCESS"]/*'/>

    VideoProcess = 0x200000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VIDEO_ENCODE"]/*'/>

    VideoEncode = 0x400000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    BuildRaytracingAccelerationStructure = 0x800000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    CopyRaytracingAccelerationStructure = 0x1000000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_SPLIT"]/*'/>

    Split = unchecked((int)(0x80000000)),
}
