// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoEncoderAv1FrameTypeFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_KEY_FRAME"]/*'/>

    KeyFrame = (1 << D3D12VideoEncoderAv1FrameType.KeyFrame),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTER_FRAME"]/*'/>

    InterFrame = (1 << D3D12VideoEncoderAv1FrameType.InterFrame),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTRA_ONLY_FRAME"]/*'/>

    IntraOnlyFrame = (1 << D3D12VideoEncoderAv1FrameType.IntraOnlyFrame),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_SWITCH_FRAME"]/*'/>

    SwitchFrame = (1 << D3D12VideoEncoderAv1FrameType.SwitchFrame),
}
