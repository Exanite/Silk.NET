// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION"]/*'/>
public enum D3D12VideoProcessOrientation
{
    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT"]/*'/>

    Default = 0,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL"]/*'/>

    FlipHorizontal = 1,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90"]/*'/>

    Clockwise90 = 2,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL"]/*'/>

    Clockwise90FlipHorizontal = 3,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180"]/*'/>

    Clockwise180 = 4,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL"]/*'/>

    FlipVertical = 5,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270"]/*'/>

    Clockwise270 = 6,

    /// <include file='D3D12_VIDEO_PROCESS_ORIENTATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ORIENTATION.D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL"]/*'/>

    Clockwise270FlipHorizontal = 7,
}
