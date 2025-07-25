// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1"]/*'/>
public unsafe partial struct D3D12VideoDecodeConversionArguments1
{
    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.Enable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Enable;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.pReferenceTexture2D"]/*'/>

    public ID3D12Resource PReferenceTexture2D;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.ReferenceSubresource"]/*'/>

    public uint ReferenceSubresource;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.OutputColorSpace"]/*'/>

    public DxgiColorSpaceType OutputColorSpace;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.DecodeColorSpace"]/*'/>

    public DxgiColorSpaceType DecodeColorSpace;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.OutputWidth"]/*'/>

    public uint OutputWidth;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1.OutputHeight"]/*'/>

    public uint OutputHeight;
}
