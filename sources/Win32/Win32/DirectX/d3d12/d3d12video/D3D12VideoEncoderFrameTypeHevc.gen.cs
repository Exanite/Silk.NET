// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC"]/*'/>
public enum D3D12VideoEncoderFrameTypeHevc
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME"]/*'/>

    IFrame = 0,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME"]/*'/>

    PFrame = 1,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME"]/*'/>

    BFrame = 2,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC.D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME"]/*'/>

    IdrFrame = 3,
}
