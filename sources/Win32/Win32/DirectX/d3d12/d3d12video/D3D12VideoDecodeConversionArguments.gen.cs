// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS"]/*'/>
public unsafe partial struct D3D12VideoDecodeConversionArguments
{
    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.Enable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Enable;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.pReferenceTexture2D"]/*'/>

    public ID3D12Resource PReferenceTexture2D;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.ReferenceSubresource"]/*'/>

    public uint ReferenceSubresource;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.OutputColorSpace"]/*'/>

    public DxgiColorSpaceType OutputColorSpace;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.DecodeColorSpace"]/*'/>

    public DxgiColorSpaceType DecodeColorSpace;
}
