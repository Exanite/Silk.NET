// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE"]/*'/>
public enum D3D12QueryHeapType
{
    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_OCCLUSION"]/*'/>

    Occlusion = 0,

    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_TIMESTAMP"]/*'/>

    Timestamp = 1,

    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS"]/*'/>

    PipelineStatistics = 2,

    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_SO_STATISTICS"]/*'/>

    SoStatistics = 3,

    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS"]/*'/>

    VideoDecodeStatistics = 4,

    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP"]/*'/>

    CopyQueueTimestamp = 5,

    /// <include file='D3D12_QUERY_HEAP_TYPE.xml' path='doc/member[@name="D3D12_QUERY_HEAP_TYPE.D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1"]/*'/>

    PipelineStatistics1 = 7,
}
