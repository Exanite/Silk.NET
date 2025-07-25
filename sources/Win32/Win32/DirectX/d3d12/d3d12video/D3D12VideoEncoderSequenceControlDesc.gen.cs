// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC"]/*'/>
public partial struct D3D12VideoEncoderSequenceControlDesc
{
    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.Flags"]/*'/>

    public D3D12VideoEncoderSequenceControlFlags Flags;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.IntraRefreshConfig"]/*'/>

    public D3D12VideoEncoderIntraRefresh IntraRefreshConfig;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.RateControl"]/*'/>

    public D3D12VideoEncoderRateControl RateControl;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.PictureTargetResolution"]/*'/>

    public D3D12VideoEncoderPictureResolutionDesc PictureTargetResolution;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.SelectedLayoutMode"]/*'/>

    public D3D12VideoEncoderFrameSubregionLayoutMode SelectedLayoutMode;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.FrameSubregionsLayoutData"]/*'/>

    public D3D12VideoEncoderPictureControlSubregionsLayoutData FrameSubregionsLayoutData;

    /// <include file='D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC.CodecGopSequence"]/*'/>

    public D3D12VideoEncoderSequenceGopStructure CodecGopSequence;
}
