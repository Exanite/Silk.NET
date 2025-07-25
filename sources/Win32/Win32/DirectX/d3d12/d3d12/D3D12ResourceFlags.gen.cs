// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS"]/*'/>
[Flags]
public enum D3D12ResourceFlags
{
    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET"]/*'/>

    AllowRenderTarget = 0x1,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_DEPTH_STENCIL"]/*'/>

    AllowDepthStencil = 0x2,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_UNORDERED_ACCESS"]/*'/>

    AllowUnorderedAccess = 0x4,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_DENY_SHADER_RESOURCE"]/*'/>

    DenyShaderResource = 0x8,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_CROSS_ADAPTER"]/*'/>

    AllowCrossAdapter = 0x10,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_ALLOW_SIMULTANEOUS_ACCESS"]/*'/>

    AllowSimultaneousAccess = 0x20,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_VIDEO_DECODE_REFERENCE_ONLY"]/*'/>

    VideoDecodeReferenceOnly = 0x40,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_VIDEO_ENCODE_REFERENCE_ONLY"]/*'/>

    VideoEncodeReferenceOnly = 0x80,

    /// <include file='D3D12_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D12_RESOURCE_FLAGS.D3D12_RESOURCE_FLAG_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    RaytracingAccelerationStructure = 0x100,
}
