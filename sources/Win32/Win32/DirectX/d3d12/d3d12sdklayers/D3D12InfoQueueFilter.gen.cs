// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER"]/*'/>
public partial struct D3D12InfoQueueFilter
{
    /// <include file='D3D12_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER.AllowList"]/*'/>

    public D3D12InfoQueueFilterDesc AllowList;

    /// <include file='D3D12_INFO_QUEUE_FILTER.xml' path='doc/member[@name="D3D12_INFO_QUEUE_FILTER.DenyList"]/*'/>

    public D3D12InfoQueueFilterDesc DenyList;
}
