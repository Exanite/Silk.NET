// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12ResolveVideoMotionVectorHeapOutput
{
    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.pMotionVectorTexture2D"]/*'/>

    public ID3D12Resource PMotionVectorTexture2D;

    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.MotionVectorCoordinate"]/*'/>

    public D3D12ResourceCoordinate MotionVectorCoordinate;
}
