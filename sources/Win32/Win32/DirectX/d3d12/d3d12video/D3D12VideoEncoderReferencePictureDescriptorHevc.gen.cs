// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC"]/*'/>
public partial struct D3D12VideoEncoderReferencePictureDescriptorHevc
{
    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.ReconstructedPictureResourceIndex"]/*'/>

    public uint ReconstructedPictureResourceIndex;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.IsRefUsedByCurrentPic"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> IsRefUsedByCurrentPic;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.IsLongTermReference"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> IsLongTermReference;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.PictureOrderCountNumber"]/*'/>

    public uint PictureOrderCountNumber;

    /// <include file='D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC.TemporalLayerIndex"]/*'/>

    public uint TemporalLayerIndex;
}
