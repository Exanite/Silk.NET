// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR"]/*'/>
public partial struct D3D12VideoEncoderAv1ReferencePictureDescriptor
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.ReconstructedPictureResourceIndex"]/*'/>

    public uint ReconstructedPictureResourceIndex;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.TemporalLayerIndexPlus1"]/*'/>

    public uint TemporalLayerIndexPlus1;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.SpatialLayerIndexPlus1"]/*'/>

    public uint SpatialLayerIndexPlus1;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.FrameType"]/*'/>

    public D3D12VideoEncoderAv1FrameType FrameType;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.WarpedMotionInfo"]/*'/>

    public D3D12VideoEncoderAv1ReferencePictureWarpedMotionInfo WarpedMotionInfo;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.OrderHint"]/*'/>

    public uint OrderHint;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR.PictureIndex"]/*'/>

    public uint PictureIndex;
}
