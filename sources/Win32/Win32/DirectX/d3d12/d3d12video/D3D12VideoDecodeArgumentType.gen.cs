// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE"]/*'/>
public enum D3D12VideoDecodeArgumentType
{
    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS"]/*'/>

    PictureParameters = 0,

    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX"]/*'/>

    InverseQuantizationMatrix = 1,

    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL"]/*'/>

    SliceControl = 2,

    /// <include file='D3D12_VIDEO_DECODE_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_ARGUMENT_TYPE.D3D12_VIDEO_DECODE_ARGUMENT_TYPE_HUFFMAN_TABLE"]/*'/>

    HuffmanTable = 3,
}
