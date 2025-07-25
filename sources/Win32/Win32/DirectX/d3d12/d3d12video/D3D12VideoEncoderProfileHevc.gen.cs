// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC"]/*'/>
public enum D3D12VideoEncoderProfileHevc
{
    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN"]/*'/>

    Main = 0,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10"]/*'/>

    Main10 = 1,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12"]/*'/>

    Main12 = 2,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_422"]/*'/>

    Main10X422 = 3,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_422"]/*'/>

    Main12X422 = 4,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN_444"]/*'/>

    Main444 = 5,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_444"]/*'/>

    Main10X444 = 6,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_444"]/*'/>

    Main12X444 = 7,

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_HEVC.D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN16_444"]/*'/>

    Main16X444 = 8,
}
