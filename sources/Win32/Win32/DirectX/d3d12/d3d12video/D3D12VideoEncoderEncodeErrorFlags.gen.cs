// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS"]/*'/>
public enum D3D12VideoEncoderEncodeErrorFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR"]/*'/>

    NoError = 0,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED"]/*'/>

    CodecPictureControlNotSupported = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED"]/*'/>

    SubregionLayoutConfigurationNotSupported = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES"]/*'/>

    InvalidReferencePictures = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED"]/*'/>

    ReconfigurationRequestNotSupported = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS.D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE"]/*'/>

    InvalidMetadataBufferSource = 0x10,
}
