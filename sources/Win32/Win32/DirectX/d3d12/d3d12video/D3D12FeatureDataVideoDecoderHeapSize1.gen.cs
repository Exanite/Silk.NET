// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1"]/*'/>
public partial struct D3D12FeatureDataVideoDecoderHeapSize1
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.VideoDecoderHeapDesc"]/*'/>

    public D3D12VideoDecoderHeapDesc VideoDecoderHeapDesc;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.Protected"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Protected;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.MemoryPoolL0Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1.MemoryPoolL1Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
