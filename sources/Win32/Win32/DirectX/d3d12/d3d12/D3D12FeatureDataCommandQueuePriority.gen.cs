// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY"]/*'/>
public partial struct D3D12FeatureDataCommandQueuePriority
{
    /// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.CommandListType"]/*'/>

    public D3D12CommandListType CommandListType;

    /// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.Priority"]/*'/>

    public uint Priority;

    /// <include file='D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.xml' path='doc/member[@name="D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY.PriorityForTypeIsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> PriorityForTypeIsSupported;
}
