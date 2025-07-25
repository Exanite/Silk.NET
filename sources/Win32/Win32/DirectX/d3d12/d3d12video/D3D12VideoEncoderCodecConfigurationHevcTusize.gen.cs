// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE"]/*'/>
public enum D3D12VideoEncoderCodecConfigurationHevcTusize
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_4x4"]/*'/>

    Tusize4X4 = 0,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_8x8"]/*'/>

    Tusize8X8 = 1,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_16x16"]/*'/>

    Tusize16X16 = 2,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_32x32"]/*'/>

    Tusize32X32 = 3,
}
