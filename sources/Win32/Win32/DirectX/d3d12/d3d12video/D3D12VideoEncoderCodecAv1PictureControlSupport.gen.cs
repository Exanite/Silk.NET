// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT"]/*'/>
public partial struct D3D12VideoEncoderCodecAv1PictureControlSupport
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.PredictionMode"]/*'/>

    public D3D12VideoEncoderAv1CompPredictionType PredictionMode;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.MaxUniqueReferencesPerFrame"]/*'/>

    public uint MaxUniqueReferencesPerFrame;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.SupportedFrameTypes"]/*'/>

    public D3D12VideoEncoderAv1FrameTypeFlags SupportedFrameTypes;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT.SupportedReferenceWarpedMotionFlags"]/*'/>

    public D3D12VideoEncoderAv1ReferenceWarpedMotionTransformationFlags SupportedReferenceWarpedMotionFlags;
}
