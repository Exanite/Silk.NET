// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE"]/*'/>
public enum D3D12VideoEncoderCodecConfigurationHevcCusize
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_8x8"]/*'/>

    Cusize8X8 = 0,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_16x16"]/*'/>

    Cusize16X16 = 1,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_32x32"]/*'/>

    Cusize32X32 = 2,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_64x64"]/*'/>

    Cusize64X64 = 3,
}
