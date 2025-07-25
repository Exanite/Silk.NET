// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS"]/*'/>
public enum D3D12VideoEncoderRateControlFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP"]/*'/>

    EnableDeltaQp = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS"]/*'/>

    EnableFrameAnalysis = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE"]/*'/>

    EnableQpRange = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP"]/*'/>

    EnableInitialQp = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE"]/*'/>

    EnableMaxFrameSize = 0x10,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES"]/*'/>

    EnableVbvSizes = 0x20,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_EXTENSION1_SUPPORT"]/*'/>

    EnableExtension1Support = 0x40,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QUALITY_VS_SPEED"]/*'/>

    EnableQualityVsSpeed = 0x80,
}
