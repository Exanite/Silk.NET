// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE"]/*'/>
public enum D3D12VideoEncoderMotionEstimationPrecisionMode
{
    /// <include file='D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_MAXIMUM"]/*'/>

    Maximum = 0,

    /// <include file='D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_FULL_PIXEL"]/*'/>

    FullPixel = 1,

    /// <include file='D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_HALF_PIXEL"]/*'/>

    HalfPixel = 2,

    /// <include file='D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_QUARTER_PIXEL"]/*'/>

    QuarterPixel = 3,

    /// <include file='D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE.D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_EIGHTH_PIXEL"]/*'/>

    EighthPixel = 4,
}
