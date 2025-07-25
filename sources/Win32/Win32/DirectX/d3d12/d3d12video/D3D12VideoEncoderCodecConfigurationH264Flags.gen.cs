// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS"]/*'/>
public enum D3D12VideoEncoderCodecConfigurationH264Flags
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION"]/*'/>

    UseConstrainedIntraprediction = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM"]/*'/>

    USEAdaptive8X8Transform = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING"]/*'/>

    EnableCabacEncoding = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES"]/*'/>

    AllowRequestIntraConstrainedSlices = 0x8,
}
