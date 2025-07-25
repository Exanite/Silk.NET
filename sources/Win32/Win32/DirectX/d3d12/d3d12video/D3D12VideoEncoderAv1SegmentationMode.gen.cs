// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE"]/*'/>
public enum D3D12VideoEncoderAv1SegmentationMode
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_DISABLED"]/*'/>

    Disabled = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_Q"]/*'/>

    AltQ = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_Y_V"]/*'/>

    AltLfYV = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_Y_H"]/*'/>

    AltLfYH = 3,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_U"]/*'/>

    AltLfU = 4,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_LF_V"]/*'/>

    AltLfV = 5,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_REF_FRAME"]/*'/>

    AltRefFrame = 6,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_SKIP"]/*'/>

    AltSkip = 7,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_ALT_GLOBALMV"]/*'/>

    AltGlobalmv = 8,
}
