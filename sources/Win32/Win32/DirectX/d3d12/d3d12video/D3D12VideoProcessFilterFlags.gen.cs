// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoProcessFilterFlags
{
    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS"]/*'/>

    Brightness = (1 << D3D12VideoProcessFilter.Brightness),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST"]/*'/>

    Contrast = (1 << D3D12VideoProcessFilter.Contrast),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE"]/*'/>

    Hue = (1 << D3D12VideoProcessFilter.Hue),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION"]/*'/>

    Saturation = (1 << D3D12VideoProcessFilter.Saturation),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION"]/*'/>

    NoiseReduction = (1 << D3D12VideoProcessFilter.NoiseReduction),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT"]/*'/>

    EdgeEnhancement = (1 << D3D12VideoProcessFilter.EdgeEnhancement),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING"]/*'/>

    AnamorphicScaling = (1 << D3D12VideoProcessFilter.AnamorphicScaling),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT"]/*'/>

    StereoAdjustment = (1 << D3D12VideoProcessFilter.StereoAdjustment),
}
