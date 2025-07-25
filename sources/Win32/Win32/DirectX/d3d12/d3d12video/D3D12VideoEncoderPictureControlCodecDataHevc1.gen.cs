// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1"]/*'/>
public unsafe partial struct D3D12VideoEncoderPictureControlCodecDataHevc1
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.Flags"]/*'/>

    public D3D12VideoEncoderPictureControlCodecDataHevcFlags Flags;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.FrameType"]/*'/>

    public D3D12VideoEncoderFrameTypeHevc FrameType;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.slice_pic_parameter_set_id"]/*'/>

    public uint SlicePicParameterSetId;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.PictureOrderCountNumber"]/*'/>

    public uint PictureOrderCountNumber;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.TemporalLayerIndex"]/*'/>

    public uint TemporalLayerIndex;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.List0ReferenceFramesCount"]/*'/>

    public uint List0ReferenceFramesCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.pList0ReferenceFrames"]/*'/>

    public uint* PList0ReferenceFrames;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.List1ReferenceFramesCount"]/*'/>

    public uint List1ReferenceFramesCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.pList1ReferenceFrames"]/*'/>

    public uint* PList1ReferenceFrames;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.ReferenceFramesReconPictureDescriptorsCount"]/*'/>

    public uint ReferenceFramesReconPictureDescriptorsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.pReferenceFramesReconPictureDescriptors"]/*'/>

    public D3D12VideoEncoderReferencePictureDescriptorHevc* PReferenceFramesReconPictureDescriptors;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.List0RefPicModificationsCount"]/*'/>

    public uint List0RefPicModificationsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.pList0RefPicModifications"]/*'/>

    public uint* PList0RefPicModifications;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.List1RefPicModificationsCount"]/*'/>

    public uint List1RefPicModificationsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.pList1RefPicModifications"]/*'/>

    public uint* PList1RefPicModifications;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.QPMapValuesCount"]/*'/>

    public uint QPMapValuesCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.pRateControlQPMap"]/*'/>

    [NativeTypeName("INT8 *")]
    public sbyte* PRateControlQPMap;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.diff_cu_chroma_qp_offset_depth"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte DiffCuChromaQpOffsetDepth;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.log2_sao_offset_scale_luma"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte Log2SaoOffsetScaleLuma;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.log2_sao_offset_scale_chroma"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte Log2SaoOffsetScaleChroma;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.log2_max_transform_skip_block_size_minus2"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte Log2MaxTransformSkipBlockSizeMinus2;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.chroma_qp_offset_list_len_minus1"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte ChromaQpOffsetListLenMinus1;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.cb_qp_offset_list"]/*'/>

    [NativeTypeName("CHAR[6]")]
    public _cb_qp_offset_list_e__FixedBuffer CbQpOffsetList;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC1.cr_qp_offset_list"]/*'/>

    [NativeTypeName("CHAR[6]")]
    public _cr_qp_offset_list_e__FixedBuffer CrQpOffsetList;

    /// <include file='_cb_qp_offset_list_e__FixedBuffer.xml' path='doc/member[@name="_cb_qp_offset_list_e__FixedBuffer"]/*'/>

    [InlineArray(6)]
    public partial struct _cb_qp_offset_list_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_cr_qp_offset_list_e__FixedBuffer.xml' path='doc/member[@name="_cr_qp_offset_list_e__FixedBuffer"]/*'/>

    [InlineArray(6)]
    public partial struct _cr_qp_offset_list_e__FixedBuffer
    {
        public sbyte e0;
    }
}
