// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO"]/*'/>
public partial struct D3D12FeatureDataVideoProcessReferenceInfo
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.DeinterlaceMode"]/*'/>

    public D3D12VideoProcessDeinterlaceFlags DeinterlaceMode;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.Filters"]/*'/>

    public D3D12VideoProcessFilterFlags Filters;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.FeatureSupport"]/*'/>

    public D3D12VideoProcessFeatureFlags FeatureSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.InputFrameRate"]/*'/>

    public DxgiRational InputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.OutputFrameRate"]/*'/>

    public DxgiRational OutputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.EnableAutoProcessing"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> EnableAutoProcessing;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.PastFrames"]/*'/>

    public uint PastFrames;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.FutureFrames"]/*'/>

    public uint FutureFrames;
}
