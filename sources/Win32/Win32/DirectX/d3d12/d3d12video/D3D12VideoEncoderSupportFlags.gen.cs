// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS"]/*'/>
public enum D3D12VideoEncoderSupportFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_GENERAL_SUPPORT_OK"]/*'/>

    GeneralSupportOk = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_RECONFIGURATION_AVAILABLE"]/*'/>

    RateControlReconfigurationAvailable = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RESOLUTION_RECONFIGURATION_AVAILABLE"]/*'/>

    ResolutionReconfigurationAvailable = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_VBV_SIZE_CONFIG_AVAILABLE"]/*'/>

    RateControlVbvSizeConfigAvailable = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_FRAME_ANALYSIS_AVAILABLE"]/*'/>

    RateControlFrameAnalysisAvailable = 0x10,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RECONSTRUCTED_FRAMES_REQUIRE_TEXTURE_ARRAYS"]/*'/>

    ReconstructedFramesRequireTextureArrays = 0x20,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_DELTA_QP_AVAILABLE"]/*'/>

    RateControlDeltaQpAvailable = 0x40,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SUBREGION_LAYOUT_RECONFIGURATION_AVAILABLE"]/*'/>

    SubregionLayoutReconfigurationAvailable = 0x80,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_ADJUSTABLE_QP_RANGE_AVAILABLE"]/*'/>

    RateControlAdjustableQpRangeAvailable = 0x100,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_INITIAL_QP_AVAILABLE"]/*'/>

    RateControlInitialQpAvailable = 0x200,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_MAX_FRAME_SIZE_AVAILABLE"]/*'/>

    RateControlMaxFrameSizeAvailable = 0x400,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SEQUENCE_GOP_RECONFIGURATION_AVAILABLE"]/*'/>

    SequenceGopReconfigurationAvailable = 0x800,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_MOTION_ESTIMATION_PRECISION_MODE_LIMIT_AVAILABLE"]/*'/>

    MotionEstimationPrecisionModeLimitAvailable = 0x1000,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_EXTENSION1_SUPPORT"]/*'/>

    RateControlExtension1Support = 0x2000,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_QUALITY_VS_SPEED_AVAILABLE"]/*'/>

    RateControlQualityVsSpeedAvailable = 0x4000,

    /// <include file='D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_SUPPORT_FLAG_READABLE_RECONSTRUCTED_PICTURE_LAYOUT_AVAILABLE"]/*'/>

    ReadableReconstructedPictureLayoutAvailable = 0x8000,
}
