// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE"]/*'/>
public enum D3D12VideoEncoderFrameSubregionLayoutMode
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME"]/*'/>

    FullFrame = 0,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION"]/*'/>

    BytesPerSubregion = 1,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED"]/*'/>

    SquareUnitsPerSubregionRowUnaligned = 2,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION"]/*'/>

    UniformPartitioningRowsPerSubregion = 3,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME"]/*'/>

    UniformPartitioningSubregionsPerFrame = 4,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_GRID_PARTITION"]/*'/>

    UniformGridPartition = 5,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_CONFIGURABLE_GRID_PARTITION"]/*'/>

    ConfigurableGridPartition = 6,
}
