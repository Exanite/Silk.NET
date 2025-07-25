// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER"]/*'/>
public enum D3D12VideoProcessFilter
{
    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS"]/*'/>

    Brightness = 0,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_CONTRAST"]/*'/>

    Contrast = 1,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_HUE"]/*'/>

    Hue = 2,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_SATURATION"]/*'/>

    Saturation = 3,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION"]/*'/>

    NoiseReduction = 4,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT"]/*'/>

    EdgeEnhancement = 5,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING"]/*'/>

    AnamorphicScaling = 6,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER.D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT"]/*'/>

    StereoAdjustment = 7,
}
