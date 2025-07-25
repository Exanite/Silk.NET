// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC"]/*'/>
public partial struct D3D12VideoProcessInputStreamDesc
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.ColorSpace"]/*'/>

    public DxgiColorSpaceType ColorSpace;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.SourceAspectRatio"]/*'/>

    public DxgiRational SourceAspectRatio;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.DestinationAspectRatio"]/*'/>

    public DxgiRational DestinationAspectRatio;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.FrameRate"]/*'/>

    public DxgiRational FrameRate;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.SourceSizeRange"]/*'/>

    public D3D12VideoSizeRange SourceSizeRange;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.DestinationSizeRange"]/*'/>

    public D3D12VideoSizeRange DestinationSizeRange;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.EnableOrientation"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> EnableOrientation;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.FilterFlags"]/*'/>

    public D3D12VideoProcessFilterFlags FilterFlags;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.StereoFormat"]/*'/>

    public D3D12VideoFrameStereoFormat StereoFormat;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.FieldType"]/*'/>

    public D3D12VideoFieldType FieldType;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.DeinterlaceMode"]/*'/>

    public D3D12VideoProcessDeinterlaceFlags DeinterlaceMode;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.EnableAlphaBlending"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> EnableAlphaBlending;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.LumaKey"]/*'/>

    public D3D12VideoProcessLumaKey LumaKey;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.NumPastFrames"]/*'/>

    public uint NumPastFrames;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.NumFutureFrames"]/*'/>

    public uint NumFutureFrames;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.EnableAutoProcessing"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> EnableAutoProcessing;
}
