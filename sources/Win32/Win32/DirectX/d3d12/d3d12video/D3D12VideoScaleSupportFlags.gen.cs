// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_SCALE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoScaleSupportFlags
{
    /// <include file='D3D12_VIDEO_SCALE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT_FLAGS.D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_SCALE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT_FLAGS.D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY"]/*'/>

    Pow2Only = 0x1,

    /// <include file='D3D12_VIDEO_SCALE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_SCALE_SUPPORT_FLAGS.D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY"]/*'/>

    EvenDimensionsOnly = 0x2,
}
