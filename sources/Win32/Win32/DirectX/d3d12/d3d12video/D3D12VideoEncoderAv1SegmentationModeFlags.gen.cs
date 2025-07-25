// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoEncoderAv1SegmentationModeFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_DISABLED"]/*'/>

    Disabled = (1 << D3D12VideoEncoderAv1SegmentationMode.Disabled),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_Q"]/*'/>

    AltQ = (1 << D3D12VideoEncoderAv1SegmentationMode.AltQ),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_V"]/*'/>

    AltLfYV = (1 << D3D12VideoEncoderAv1SegmentationMode.AltLfYV),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_H"]/*'/>

    AltLfYH = (1 << D3D12VideoEncoderAv1SegmentationMode.AltLfYH),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_U"]/*'/>

    AltLfU = (1 << D3D12VideoEncoderAv1SegmentationMode.AltLfU),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_V"]/*'/>

    AltLfV = (1 << D3D12VideoEncoderAv1SegmentationMode.AltLfV),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_REF_FRAME"]/*'/>

    RefFrame = (1 << D3D12VideoEncoderAv1SegmentationMode.AltRefFrame),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_SKIP"]/*'/>

    AltSkip = (1 << D3D12VideoEncoderAv1SegmentationMode.AltSkip),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_GLOBALMV"]/*'/>

    AltGlobalmv = (1 << D3D12VideoEncoderAv1SegmentationMode.AltGlobalmv),
}
