// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12FeatureDataVideoMotionEstimatorSize
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.InputFormat"]/*'/>

    public DxgiFormat InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.BlockSize"]/*'/>

    public D3D12VideoMotionEstimatorSearchBlockSize BlockSize;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.Precision"]/*'/>

    public D3D12VideoMotionEstimatorVectorPrecision Precision;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.SizeRange"]/*'/>

    public D3D12VideoSizeRange SizeRange;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.Protected"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Protected;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionVectorHeapMemoryPoolL0Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MotionVectorHeapMemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionVectorHeapMemoryPoolL1Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MotionVectorHeapMemoryPoolL1Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionEstimatorMemoryPoolL0Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MotionEstimatorMemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionEstimatorMemoryPoolL1Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MotionEstimatorMemoryPoolL1Size;
}
