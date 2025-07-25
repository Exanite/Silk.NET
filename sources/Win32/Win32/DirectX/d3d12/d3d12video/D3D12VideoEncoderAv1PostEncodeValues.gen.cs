// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES"]/*'/>
public partial struct D3D12VideoEncoderAv1PostEncodeValues
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.CompoundPredictionType"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong CompoundPredictionType;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.LoopFilter"]/*'/>

    public D3D12VideoEncoderCodecAv1LoopFilterConfig LoopFilter;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.LoopFilterDelta"]/*'/>

    public D3D12VideoEncoderCodecAv1LoopFilterDeltaConfig LoopFilterDelta;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.Quantization"]/*'/>

    public D3D12VideoEncoderCodecAv1QuantizationConfig Quantization;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.QuantizationDelta"]/*'/>

    public D3D12VideoEncoderCodecAv1QuantizationDeltaConfig QuantizationDelta;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.CDEF"]/*'/>

    public D3D12VideoEncoderAv1CdefConfig Cdef;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.SegmentationConfig"]/*'/>

    public D3D12VideoEncoderAv1SegmentationConfig SegmentationConfig;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.PrimaryRefFrame"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong PrimaryRefFrame;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES.ReferenceIndices"]/*'/>

    [NativeTypeName("UINT64[7]")]
    public _ReferenceIndices_e__FixedBuffer ReferenceIndices;

    /// <include file='_ReferenceIndices_e__FixedBuffer.xml' path='doc/member[@name="_ReferenceIndices_e__FixedBuffer"]/*'/>

    [InlineArray(7)]
    public partial struct _ReferenceIndices_e__FixedBuffer
    {
        public ulong e0;
    }
}
