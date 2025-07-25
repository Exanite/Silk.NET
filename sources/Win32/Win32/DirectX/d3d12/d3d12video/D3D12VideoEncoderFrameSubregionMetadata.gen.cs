// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA"]/*'/>
public partial struct D3D12VideoEncoderFrameSubregionMetadata
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.bSize"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong BSize;

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.bStartOffset"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong BStartOffset;

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_METADATA.bHeaderSize"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong BHeaderSize;
}
