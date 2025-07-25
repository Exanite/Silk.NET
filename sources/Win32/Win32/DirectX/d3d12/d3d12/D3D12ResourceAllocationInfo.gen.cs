// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_ALLOCATION_INFO.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO"]/*'/>
public partial struct D3D12ResourceAllocationInfo
{
    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO.SizeInBytes"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong SizeInBytes;

    /// <include file='D3D12_RESOURCE_ALLOCATION_INFO.xml' path='doc/member[@name="D3D12_RESOURCE_ALLOCATION_INFO.Alignment"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong Alignment;
}
