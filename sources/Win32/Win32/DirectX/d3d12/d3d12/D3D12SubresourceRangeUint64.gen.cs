// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SUBRESOURCE_RANGE_UINT64.xml' path='doc/member[@name="D3D12_SUBRESOURCE_RANGE_UINT64"]/*'/>
public partial struct D3D12SubresourceRangeUint64
{
    /// <include file='D3D12_SUBRESOURCE_RANGE_UINT64.xml' path='doc/member[@name="D3D12_SUBRESOURCE_RANGE_UINT64.Subresource"]/*'/>

    public uint Subresource;

    /// <include file='D3D12_SUBRESOURCE_RANGE_UINT64.xml' path='doc/member[@name="D3D12_SUBRESOURCE_RANGE_UINT64.Range"]/*'/>

    public D3D12RangeUint64 Range;
}
