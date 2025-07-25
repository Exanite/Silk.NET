// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_H264"]/*'/>
public enum D3D12VideoEncoderFrameTypeH264
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_I_FRAME"]/*'/>

    IFrame = 0,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_P_FRAME"]/*'/>

    PFrame = 1,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_B_FRAME"]/*'/>

    BFrame = 2,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_H264.D3D12_VIDEO_ENCODER_FRAME_TYPE_H264_IDR_FRAME"]/*'/>

    IdrFrame = 3,
}
