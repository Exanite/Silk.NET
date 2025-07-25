// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC"]/*'/>
public partial struct D3D12VideoEncoderCodecConfigurationHevc
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.ConfigurationFlags"]/*'/>

    public D3D12VideoEncoderCodecConfigurationHevcFlags ConfigurationFlags;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.MinLumaCodingUnitSize"]/*'/>

    public D3D12VideoEncoderCodecConfigurationHevcCusize MinLumaCodingUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.MaxLumaCodingUnitSize"]/*'/>

    public D3D12VideoEncoderCodecConfigurationHevcCusize MaxLumaCodingUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.MinLumaTransformUnitSize"]/*'/>

    public D3D12VideoEncoderCodecConfigurationHevcTusize MinLumaTransformUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.MaxLumaTransformUnitSize"]/*'/>

    public D3D12VideoEncoderCodecConfigurationHevcTusize MaxLumaTransformUnitSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.max_transform_hierarchy_depth_inter"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte MaxTransformHierarchyDepthInter;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC.max_transform_hierarchy_depth_intra"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte MaxTransformHierarchyDepthIntra;
}
