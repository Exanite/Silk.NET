// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS"]/*'/>
[Flags]
public enum D3D12RaytracingInstanceFlags
{
    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE"]/*'/>

    TriangleCullDisable = 0x1,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE"]/*'/>

    TriangleFrontCounterclockwise = 0x2,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE"]/*'/>

    ForceOpaque = 0x4,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE"]/*'/>

    ForceNonOpaque = 0x8,
}
