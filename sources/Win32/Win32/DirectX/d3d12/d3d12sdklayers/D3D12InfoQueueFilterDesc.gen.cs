// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC"]/*'/>
public unsafe partial struct D3D12InfoQueueFilterDesc
{
    /// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC.NumCategories"]/*'/>

    public uint NumCategories;

    /// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC.pCategoryList"]/*'/>

    public D3D12MessageCategory* PCategoryList;

    /// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC.NumSeverities"]/*'/>

    public uint NumSeverities;

    /// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC.pSeverityList"]/*'/>

    public D3D12MessageSeverity* PSeverityList;

    /// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC.NumIDs"]/*'/>

    public uint NumIDs;

    /// <include file='D3D12_INFO_QUEUE_FILTER_DESC.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER_DESC.pIDList"]/*'/>

    public D3D12MessageId* PIDList;
}
