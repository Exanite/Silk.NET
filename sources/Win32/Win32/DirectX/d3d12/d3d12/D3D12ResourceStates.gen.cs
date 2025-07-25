// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES"]/*'/>
[Flags]
public enum D3D12ResourceStates
{
    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COMMON"]/*'/>

    Common = 0,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER"]/*'/>

    VertexAndConstantBuffer = 0x1,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_INDEX_BUFFER"]/*'/>

    IndexBuffer = 0x2,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RENDER_TARGET"]/*'/>

    RenderTarget = 0x4,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_UNORDERED_ACCESS"]/*'/>

    UnorderedAccess = 0x8,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_DEPTH_WRITE"]/*'/>

    DepthWrite = 0x10,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_DEPTH_READ"]/*'/>

    DepthRead = 0x20,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE"]/*'/>

    NonPixelShaderResource = 0x40,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_PIXEL_SHADER_RESOURCE"]/*'/>

    PixelShaderResource = 0x80,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_STREAM_OUT"]/*'/>

    StreamOut = 0x100,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_INDIRECT_ARGUMENT"]/*'/>

    IndirectArgument = 0x200,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COPY_DEST"]/*'/>

    CopyDest = 0x400,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COPY_SOURCE"]/*'/>

    CopySource = 0x800,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESOLVE_DEST"]/*'/>

    ResolveDest = 0x1000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESOLVE_SOURCE"]/*'/>

    ResolveSource = 0x2000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    RaytracingAccelerationStructure = 0x400000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_SHADING_RATE_SOURCE"]/*'/>

    ShadingRateSource = 0x1000000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_8000"]/*'/>

    ReservedInternal8000 = 0x8000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_4000"]/*'/>

    ReservedInternal4000 = 0x4000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_100000"]/*'/>

    ReservedInternal100000 = 0x100000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_40000000"]/*'/>

    ReservedInternal40000000 = 0x40000000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_RESERVED_INTERNAL_80000000"]/*'/>

    ReservedInternal80000000 = unchecked((int)(0x80000000)),

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_GENERIC_READ"]/*'/>

    GenericRead = (((((0x1 | 0x2) | 0x40) | 0x80) | 0x200) | 0x800),

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_ALL_SHADER_RESOURCE"]/*'/>

    AllShaderResource = (0x40 | 0x80),

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_PRESENT"]/*'/>

    Present = 0,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_PREDICATION"]/*'/>

    Predication = 0x200,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_DECODE_READ"]/*'/>

    VideoDecodeRead = 0x10000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_DECODE_WRITE"]/*'/>

    VideoDecodeWrite = 0x20000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_PROCESS_READ"]/*'/>

    VideoProcessRead = 0x40000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_PROCESS_WRITE"]/*'/>

    VideoProcessWrite = 0x80000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_ENCODE_READ"]/*'/>

    VideoEncodeRead = 0x200000,

    /// <include file='D3D12_RESOURCE_STATES.xml' path='doc/member[@name="D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_VIDEO_ENCODE_WRITE"]/*'/>

    VideoEncodeWrite = 0x800000,
}
