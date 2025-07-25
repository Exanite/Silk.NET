// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE"]/*'/>
public partial struct D3D12FeatureDataVideoEncoderIntraRefreshMode
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.Codec"]/*'/>

    public D3D12VideoEncoderCodec Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.Profile"]/*'/>

    public D3D12VideoEncoderProfileDesc Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.Level"]/*'/>

    public D3D12VideoEncoderLevelSetting Level;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.IntraRefreshMode"]/*'/>

    public D3D12VideoEncoderIntraRefreshMode IntraRefreshMode;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INTRA_REFRESH_MODE.IsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> IsSupported;
}
