// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT"]/*'/>
public enum D3D12VideoFrameStereoFormat
{
    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_MONO"]/*'/>

    Mono = 1,

    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_HORIZONTAL"]/*'/>

    Horizontal = 2,

    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_VERTICAL"]/*'/>

    Vertical = 3,

    /// <include file='D3D12_VIDEO_FRAME_STEREO_FORMAT.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_STEREO_FORMAT.D3D12_VIDEO_FRAME_STEREO_FORMAT_SEPARATE"]/*'/>

    Separate = 4,
}
