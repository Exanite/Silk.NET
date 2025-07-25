// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_SCALE_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT"]/*'/>
public partial struct D3D12VideoScaleSupport
{
    /// <include file='D3D12_VIDEO_SCALE_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT.OutputSizeRange"]/*'/>

    public D3D12VideoSizeRange OutputSizeRange;

    /// <include file='D3D12_VIDEO_SCALE_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT.Flags"]/*'/>

    public D3D12VideoScaleSupportFlags Flags;
}
