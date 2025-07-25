// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL"]/*'/>
public partial struct D3D12FeatureDataVideoEncoderProfileLevel
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.Codec"]/*'/>

    public D3D12VideoEncoderCodec Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.Profile"]/*'/>

    public D3D12VideoEncoderProfileDesc Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.IsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.MinSupportedLevel"]/*'/>

    public D3D12VideoEncoderLevelSetting MinSupportedLevel;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_PROFILE_LEVEL.MaxSupportedLevel"]/*'/>

    public D3D12VideoEncoderLevelSetting MaxSupportedLevel;
}
