// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS"]/*'/>
public partial struct D3D12FeatureDataVideoEncoderResourceRequirements
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.Codec"]/*'/>

    public D3D12VideoEncoderCodec Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.Profile"]/*'/>

    public D3D12VideoEncoderProfileDesc Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.InputFormat"]/*'/>

    public DxgiFormat InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.PictureTargetResolution"]/*'/>

    public D3D12VideoEncoderPictureResolutionDesc PictureTargetResolution;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.IsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.CompressedBitstreamBufferAccessAlignment"]/*'/>

    public uint CompressedBitstreamBufferAccessAlignment;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.EncoderMetadataBufferAccessAlignment"]/*'/>

    public uint EncoderMetadataBufferAccessAlignment;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.MaxEncoderOutputMetadataBufferSize"]/*'/>

    public uint MaxEncoderOutputMetadataBufferSize;
}
