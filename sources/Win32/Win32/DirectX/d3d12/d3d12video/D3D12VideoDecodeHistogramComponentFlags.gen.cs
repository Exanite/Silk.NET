// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoDecodeHistogramComponentFlags
{
    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_Y"]/*'/>

    Y = (1 << D3D12VideoDecodeHistogramComponent.Y),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_U"]/*'/>

    U = (1 << D3D12VideoDecodeHistogramComponent.U),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_V"]/*'/>

    V = (1 << D3D12VideoDecodeHistogramComponent.V),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_R"]/*'/>

    R = (1 << D3D12VideoDecodeHistogramComponent.R),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_G"]/*'/>

    G = (1 << D3D12VideoDecodeHistogramComponent.G),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_B"]/*'/>

    B = (1 << D3D12VideoDecodeHistogramComponent.B),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_A"]/*'/>

    A = (1 << D3D12VideoDecodeHistogramComponent.A),
}
