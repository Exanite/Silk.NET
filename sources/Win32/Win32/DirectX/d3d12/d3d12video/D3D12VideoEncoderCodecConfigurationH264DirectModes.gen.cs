// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES"]/*'/>
public enum D3D12VideoEncoderCodecConfigurationH264DirectModes
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_DISABLED"]/*'/>

    Disabled = 0,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_TEMPORAL"]/*'/>

    Temporal = 1,

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES.D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_SPATIAL"]/*'/>

    Spatial = 2,
}
