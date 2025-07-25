// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE"]/*'/>
public enum D3D12VideoEncoderAv1SegmentationBlockSize
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_4x4"]/*'/>

    SIZE4X4 = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_8x8"]/*'/>

    SIZE8X8 = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_16x16"]/*'/>

    SIZE16X16 = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_32x32"]/*'/>

    SIZE32X32 = 3,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE.D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE_64x64"]/*'/>

    SIZE64X64 = 4,
}
