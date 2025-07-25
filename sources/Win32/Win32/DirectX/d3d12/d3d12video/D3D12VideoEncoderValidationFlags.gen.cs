// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS"]/*'/>
public enum D3D12VideoEncoderValidationFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_NOT_SUPPORTED"]/*'/>

    CodecNotSupported = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INPUT_FORMAT_NOT_SUPPORTED"]/*'/>

    InputFormatNotSupported = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_CODEC_CONFIGURATION_NOT_SUPPORTED"]/*'/>

    CodecConfigurationNotSupported = 0x10,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_MODE_NOT_SUPPORTED"]/*'/>

    RateControlModeNotSupported = 0x20,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RATE_CONTROL_CONFIGURATION_NOT_SUPPORTED"]/*'/>

    RateControlConfigurationNotSupported = 0x40,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_INTRA_REFRESH_MODE_NOT_SUPPORTED"]/*'/>

    IntraRefreshModeNotSupported = 0x80,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_MODE_NOT_SUPPORTED"]/*'/>

    SubregionLayoutModeNotSupported = 0x100,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_RESOLUTION_NOT_SUPPORTED_IN_LIST"]/*'/>

    ResolutionNotSupportedInList = 0x200,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_GOP_STRUCTURE_NOT_SUPPORTED"]/*'/>

    GopStructureNotSupported = 0x800,

    /// <include file='D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_VALIDATION_FLAGS.D3D12_VIDEO_ENCODER_VALIDATION_FLAG_SUBREGION_LAYOUT_DATA_NOT_SUPPORTED"]/*'/>

    SubregionLayoutDataNotSupported = 0x1000,
}
