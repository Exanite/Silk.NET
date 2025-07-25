// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE"]/*'/>
public enum D3D12VideoEncoderAv1FrameType
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_KEY_FRAME"]/*'/>

    KeyFrame = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTER_FRAME"]/*'/>

    InterFrame = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTRA_ONLY_FRAME"]/*'/>

    IntraOnlyFrame = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE.D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_SWITCH_FRAME"]/*'/>

    SwitchFrame = 3,
}
