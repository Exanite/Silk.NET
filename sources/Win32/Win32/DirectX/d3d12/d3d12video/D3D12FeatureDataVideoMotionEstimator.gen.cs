// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12FeatureDataVideoMotionEstimator
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.InputFormat"]/*'/>

    public DxgiFormat InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.BlockSizeFlags"]/*'/>

    public D3D12VideoMotionEstimatorSearchBlockSizeFlags BlockSizeFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.PrecisionFlags"]/*'/>

    public D3D12VideoMotionEstimatorVectorPrecisionFlags PrecisionFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR.SizeRange"]/*'/>

    public D3D12VideoSizeRange SizeRange;
}
