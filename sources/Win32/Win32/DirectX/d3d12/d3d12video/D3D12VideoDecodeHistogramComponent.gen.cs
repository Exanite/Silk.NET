// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT"]/*'/>
public enum D3D12VideoDecodeHistogramComponent
{
    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y"]/*'/>

    Y = 0,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U"]/*'/>

    U = 1,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V"]/*'/>

    V = 2,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R"]/*'/>

    R = 0,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G"]/*'/>

    G = 1,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B"]/*'/>

    B = 2,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A"]/*'/>

    A = 3,
}
