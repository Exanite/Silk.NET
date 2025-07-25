// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264"]/*'/>
public unsafe partial struct D3D12VideoEncoderPictureControlCodecDataH264
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.Flags"]/*'/>

    public D3D12VideoEncoderPictureControlCodecDataH264Flags Flags;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.FrameType"]/*'/>

    public D3D12VideoEncoderFrameTypeH264 FrameType;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pic_parameter_set_id"]/*'/>

    public uint PicParameterSetId;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.idr_pic_id"]/*'/>

    public uint IdrPicId;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.PictureOrderCountNumber"]/*'/>

    public uint PictureOrderCountNumber;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.FrameDecodingOrderNumber"]/*'/>

    public uint FrameDecodingOrderNumber;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.TemporalLayerIndex"]/*'/>

    public uint TemporalLayerIndex;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.List0ReferenceFramesCount"]/*'/>

    public uint List0ReferenceFramesCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pList0ReferenceFrames"]/*'/>

    public uint* PList0ReferenceFrames;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.List1ReferenceFramesCount"]/*'/>

    public uint List1ReferenceFramesCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pList1ReferenceFrames"]/*'/>

    public uint* PList1ReferenceFrames;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.ReferenceFramesReconPictureDescriptorsCount"]/*'/>

    public uint ReferenceFramesReconPictureDescriptorsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pReferenceFramesReconPictureDescriptors"]/*'/>

    public D3D12VideoEncoderReferencePictureDescriptorH264* PReferenceFramesReconPictureDescriptors;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.adaptive_ref_pic_marking_mode_flag"]/*'/>

    [NativeTypeName("UCHAR")]
    public byte AdaptiveRefPicMarkingModeFlag;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.RefPicMarkingOperationsCommandsCount"]/*'/>

    public uint RefPicMarkingOperationsCommandsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pRefPicMarkingOperationsCommands"]/*'/>

    public D3D12VideoEncoderPictureControlCodecDataH264ReferencePictureMarkingOperation* PRefPicMarkingOperationsCommands;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.List0RefPicModificationsCount"]/*'/>

    public uint List0RefPicModificationsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pList0RefPicModifications"]/*'/>

    public D3D12VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* PList0RefPicModifications;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.List1RefPicModificationsCount"]/*'/>

    public uint List1RefPicModificationsCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pList1RefPicModifications"]/*'/>

    public D3D12VideoEncoderPictureControlCodecDataH264ReferencePictureListModificationOperation* PList1RefPicModifications;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.QPMapValuesCount"]/*'/>

    public uint QPMapValuesCount;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264.pRateControlQPMap"]/*'/>

    [NativeTypeName("INT8 *")]
    public sbyte* PRateControlQPMap;
}
