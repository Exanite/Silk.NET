// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA"]/*'/>
public unsafe partial struct D3D12VideoEncoderPictureControlSubregionsLayoutData
{
    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA.DataSize"]/*'/>

    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_d3d12video_L7631_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSlicesPartition_H264"]/*'/>

    [UnscopedRef]
    public ref D3D12VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartition_H264
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSlicesPartition_H264; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSlicesPartition_HEVC"]/*'/>

    [UnscopedRef]
    public ref D3D12VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartition_HEVC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSlicesPartition_HEVC; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pTilesPartition_AV1"]/*'/>

    [UnscopedRef]
    public ref D3D12VideoEncoderAv1PictureControlSubregionsLayoutDataTiles* pTilesPartition_AV1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pTilesPartition_AV1; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSlicesPartition_H264"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName(
            "const D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES *"
        )]
        public D3D12VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartition_H264;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSlicesPartition_HEVC"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName(
            "const D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES *"
        )]
        public D3D12VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartition_HEVC;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pTilesPartition_AV1"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName(
            "const D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES *"
        )]
        public D3D12VideoEncoderAv1PictureControlSubregionsLayoutDataTiles* pTilesPartition_AV1;
    }
}
