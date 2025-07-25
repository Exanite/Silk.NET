// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS"]/*'/>
public enum D3D12VideoEncoderAv1InterpolationFilters
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP"]/*'/>

    Eighttap = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SMOOTH"]/*'/>

    EighttapSmooth = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_EIGHTTAP_SHARP"]/*'/>

    EighttapSharp = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_BILINEAR"]/*'/>

    Bilinear = 3,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_SWITCHABLE"]/*'/>

    Switchable = 4,
}
