// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoEncoderAv1InterpolationFiltersFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP"]/*'/>

    Eighttap = (1 << D3D12VideoEncoderAv1InterpolationFilters.Eighttap),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SMOOTH"]/*'/>

    EighttapSmooth = (1 << D3D12VideoEncoderAv1InterpolationFilters.EighttapSmooth),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SHARP"]/*'/>

    EighttapSharp = (1 << D3D12VideoEncoderAv1InterpolationFilters.EighttapSharp),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_BILINEAR"]/*'/>

    Bilinear = (1 << D3D12VideoEncoderAv1InterpolationFilters.Bilinear),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS.D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_SWITCHABLE"]/*'/>

    Switchable = (1 << D3D12VideoEncoderAv1InterpolationFilters.Switchable),
}
