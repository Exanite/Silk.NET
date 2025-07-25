// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS"]/*'/>
public enum D3D12VideoEncoderSequenceControlFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RESOLUTION_CHANGE"]/*'/>

    ResolutionChange = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RATE_CONTROL_CHANGE"]/*'/>

    RateControlChange = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_SUBREGION_LAYOUT_CHANGE"]/*'/>

    SubregionLayoutChange = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_REQUEST_INTRA_REFRESH"]/*'/>

    RequestIntraRefresh = 0x8,

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS.D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_GOP_SEQUENCE_CHANGE"]/*'/>

    GopSequenceChange = 0x10,
}
