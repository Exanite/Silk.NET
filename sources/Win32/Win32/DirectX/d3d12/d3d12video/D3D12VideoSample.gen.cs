// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE"]/*'/>
public partial struct D3D12VideoSample
{
    /// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE.Width"]/*'/>

    public uint Width;

    /// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE.Height"]/*'/>

    public uint Height;

    /// <include file='D3D12_VIDEO_SAMPLE.xml' path='doc/member[@name="D3D12_VIDEO_SAMPLE.Format"]/*'/>

    public D3D12VideoFormat Format;
}
