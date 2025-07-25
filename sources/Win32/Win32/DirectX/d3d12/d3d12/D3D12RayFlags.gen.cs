// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS"]/*'/>
[Flags]
public enum D3D12RayFlags
{
    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_FORCE_OPAQUE"]/*'/>

    ForceOpaque = 0x1,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_FORCE_NON_OPAQUE"]/*'/>

    ForceNonOpaque = 0x2,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH"]/*'/>

    AcceptFirstHitAndEndSearch = 0x4,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER"]/*'/>

    SkipClosestHitShader = 0x8,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES"]/*'/>

    CullBackFacingTriangles = 0x10,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES"]/*'/>

    CullFrontFacingTriangles = 0x20,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_OPAQUE"]/*'/>

    CullOpaque = 0x40,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_CULL_NON_OPAQUE"]/*'/>

    CullNonOpaque = 0x80,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_SKIP_TRIANGLES"]/*'/>

    SkipTriangles = 0x100,

    /// <include file='D3D12_RAY_FLAGS.xml' path='doc/member[@name="D3D12_RAY_FLAGS.D3D12_RAY_FLAG_SKIP_PROCEDURAL_PRIMITIVES"]/*'/>

    SkipProceduralPrimitives = 0x200,
}
