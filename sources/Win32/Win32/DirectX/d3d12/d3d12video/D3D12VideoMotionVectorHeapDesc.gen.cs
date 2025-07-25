// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12VideoMotionVectorHeapDesc
{
    /// <include file='D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.InputFormat"]/*'/>

    public DxgiFormat InputFormat;

    /// <include file='D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.BlockSize"]/*'/>

    public D3D12VideoMotionEstimatorSearchBlockSize BlockSize;

    /// <include file='D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.Precision"]/*'/>

    public D3D12VideoMotionEstimatorVectorPrecision Precision;

    /// <include file='D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC.SizeRange"]/*'/>

    public D3D12VideoSizeRange SizeRange;
}
