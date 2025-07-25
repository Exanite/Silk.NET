// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC"]/*'/>
public unsafe partial struct D3D12VideoEncoderHeapDesc
{
    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.Flags"]/*'/>

    public D3D12VideoEncoderHeapFlags Flags;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.EncodeCodec"]/*'/>

    public D3D12VideoEncoderCodec EncodeCodec;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.EncodeProfile"]/*'/>

    public D3D12VideoEncoderProfileDesc EncodeProfile;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.EncodeLevel"]/*'/>

    public D3D12VideoEncoderLevelSetting EncodeLevel;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.ResolutionsListCount"]/*'/>

    public uint ResolutionsListCount;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC.pResolutionList"]/*'/>

    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12VideoEncoderPictureResolutionDesc* PResolutionList;
}
