// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT"]/*'/>
public partial struct D3D12FeatureDataVideoProcessSupport
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputSample"]/*'/>

    public D3D12VideoSample InputSample;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputFieldType"]/*'/>

    public D3D12VideoFieldType InputFieldType;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputStereoFormat"]/*'/>

    public D3D12VideoFrameStereoFormat InputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputFrameRate"]/*'/>

    public DxgiRational InputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputFormat"]/*'/>

    public D3D12VideoFormat OutputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputStereoFormat"]/*'/>

    public D3D12VideoFrameStereoFormat OutputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputFrameRate"]/*'/>

    public DxgiRational OutputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.SupportFlags"]/*'/>

    public D3D12VideoProcessSupportFlags SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.ScaleSupport"]/*'/>

    public D3D12VideoScaleSupport ScaleSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FeatureSupport"]/*'/>

    public D3D12VideoProcessFeatureFlags FeatureSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.DeinterlaceSupport"]/*'/>

    public D3D12VideoProcessDeinterlaceFlags DeinterlaceSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.AutoProcessingSupport"]/*'/>

    public D3D12VideoProcessAutoProcessingFlags AutoProcessingSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FilterSupport"]/*'/>

    public D3D12VideoProcessFilterFlags FilterSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FilterRangeSupport"]/*'/>

    [NativeTypeName("D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
    public _FilterRangeSupport_e__FixedBuffer FilterRangeSupport;

    /// <include file='_FilterRangeSupport_e__FixedBuffer.xml' path='doc/member[@name="_FilterRangeSupport_e__FixedBuffer"]/*'/>

    [InlineArray(32)]
    public partial struct _FilterRangeSupport_e__FixedBuffer
    {
        public D3D12VideoProcessFilterRange e0;
    }
}
