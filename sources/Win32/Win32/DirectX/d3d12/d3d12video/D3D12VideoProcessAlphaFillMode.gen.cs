// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE"]/*'/>
public enum D3D12VideoProcessAlphaFillMode
{
    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE"]/*'/>

    Opaque = 0,

    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND"]/*'/>

    Background = 1,

    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION"]/*'/>

    Destination = 2,

    /// <include file='D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE.D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM"]/*'/>

    SourceStream = 3,
}
