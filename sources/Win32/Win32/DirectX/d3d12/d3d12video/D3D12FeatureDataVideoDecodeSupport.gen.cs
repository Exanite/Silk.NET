// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT"]/*'/>
public partial struct D3D12FeatureDataVideoDecodeSupport
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.Configuration"]/*'/>

    public D3D12VideoDecodeConfiguration Configuration;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.Width"]/*'/>

    public uint Width;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.Height"]/*'/>

    public uint Height;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.DecodeFormat"]/*'/>

    public DxgiFormat DecodeFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.FrameRate"]/*'/>

    public DxgiRational FrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.BitRate"]/*'/>

    public uint BitRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.SupportFlags"]/*'/>

    public D3D12VideoDecodeSupportFlags SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.ConfigurationFlags"]/*'/>

    public D3D12VideoDecodeConfigurationFlags ConfigurationFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.DecodeTier"]/*'/>

    public D3D12VideoDecodeTier DecodeTier;
}
