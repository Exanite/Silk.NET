// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE"]/*'/>
public enum D3D12QueryType
{
    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_OCCLUSION"]/*'/>

    Occlusion = 0,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_BINARY_OCCLUSION"]/*'/>

    BinaryOcclusion = 1,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_TIMESTAMP"]/*'/>

    Timestamp = 2,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_PIPELINE_STATISTICS"]/*'/>

    PipelineStatistics = 3,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0"]/*'/>

    SoStatisticsStream0 = 4,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1"]/*'/>

    SoStatisticsStream1 = 5,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2"]/*'/>

    SoStatisticsStream2 = 6,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3"]/*'/>

    SoStatisticsStream3 = 7,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS"]/*'/>

    VideoDecodeStatistics = 8,

    /// <include file='D3D12_QUERY_TYPE.xml' path='doc/member[@name="D3D12_QUERY_TYPE.D3D12_QUERY_TYPE_PIPELINE_STATISTICS1"]/*'/>

    PipelineStatistics1 = 10,
}
