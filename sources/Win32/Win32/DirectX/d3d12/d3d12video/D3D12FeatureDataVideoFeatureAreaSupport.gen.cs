// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT"]/*'/>
public partial struct D3D12FeatureDataVideoFeatureAreaSupport
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.VideoDecodeSupport"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> VideoDecodeSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.VideoProcessSupport"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> VideoProcessSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.VideoEncodeSupport"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> VideoEncodeSupport;
}
