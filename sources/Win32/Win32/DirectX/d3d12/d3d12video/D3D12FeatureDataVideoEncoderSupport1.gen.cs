// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1"]/*'/>
public unsafe partial struct D3D12FeatureDataVideoEncoderSupport1
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.Codec"]/*'/>

    public D3D12VideoEncoderCodec Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.InputFormat"]/*'/>

    public DxgiFormat InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.CodecConfiguration"]/*'/>

    public D3D12VideoEncoderCodecConfiguration CodecConfiguration;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.CodecGopSequence"]/*'/>

    public D3D12VideoEncoderSequenceGopStructure CodecGopSequence;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.RateControl"]/*'/>

    public D3D12VideoEncoderRateControl RateControl;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.IntraRefresh"]/*'/>

    public D3D12VideoEncoderIntraRefreshMode IntraRefresh;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.SubregionFrameEncoding"]/*'/>

    public D3D12VideoEncoderFrameSubregionLayoutMode SubregionFrameEncoding;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.ResolutionsListCount"]/*'/>

    public uint ResolutionsListCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.pResolutionList"]/*'/>

    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12VideoEncoderPictureResolutionDesc* PResolutionList;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.MaxReferenceFramesInDPB"]/*'/>

    public uint MaxReferenceFramesInDPB;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.ValidationFlags"]/*'/>

    public D3D12VideoEncoderValidationFlags ValidationFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.SupportFlags"]/*'/>

    public D3D12VideoEncoderSupportFlags SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.SuggestedProfile"]/*'/>

    public D3D12VideoEncoderProfileDesc SuggestedProfile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.SuggestedLevel"]/*'/>

    public D3D12VideoEncoderLevelSetting SuggestedLevel;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.pResolutionDependentSupport"]/*'/>

    public D3D12FeatureDataVideoEncoderResolutionSupportLimits* PResolutionDependentSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.SubregionFrameEncodingData"]/*'/>

    public D3D12VideoEncoderPictureControlSubregionsLayoutData SubregionFrameEncodingData;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT1.MaxQualityVsSpeed"]/*'/>

    public uint MaxQualityVsSpeed;
}
