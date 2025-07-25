// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT"]/*'/>
public partial struct D3D12VideoEncoderAv1CodecConfigurationSupport
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedFeatureFlags"]/*'/>

    public D3D12VideoEncoderAv1FeatureFlags SupportedFeatureFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.RequiredFeatureFlags"]/*'/>

    public D3D12VideoEncoderAv1FeatureFlags RequiredFeatureFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedInterpolationFilters"]/*'/>

    public D3D12VideoEncoderAv1InterpolationFiltersFlags SupportedInterpolationFilters;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedRestorationParams"]/*'/>

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS[3][3]")]
    public _SupportedRestorationParams_e__FixedBuffer SupportedRestorationParams;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedSegmentationModes"]/*'/>

    public D3D12VideoEncoderAv1SegmentationModeFlags SupportedSegmentationModes;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SupportedTxModes"]/*'/>

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS[4]")]
    public _SupportedTxModes_e__FixedBuffer SupportedTxModes;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.SegmentationBlockSize"]/*'/>

    public D3D12VideoEncoderAv1SegmentationBlockSize SegmentationBlockSize;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.PostEncodeValuesFlags"]/*'/>

    public D3D12VideoEncoderAv1PostEncodeValuesFlags PostEncodeValuesFlags;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.MaxTemporalLayers"]/*'/>

    public uint MaxTemporalLayers;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT.MaxSpatialLayers"]/*'/>

    public uint MaxSpatialLayers;

    /// <include file='_SupportedRestorationParams_e__FixedBuffer.xml' path='doc/member[@name="_SupportedRestorationParams_e__FixedBuffer"]/*'/>

    [InlineArray(3 * 3)]
    public partial struct _SupportedRestorationParams_e__FixedBuffer
    {
        public D3D12VideoEncoderAv1RestorationSupportFlags e0_0;
    }

    /// <include file='_SupportedTxModes_e__FixedBuffer.xml' path='doc/member[@name="_SupportedTxModes_e__FixedBuffer"]/*'/>

    [InlineArray(4)]
    public partial struct _SupportedTxModes_e__FixedBuffer
    {
        public D3D12VideoEncoderAv1TxModeFlags e0;
    }
}
