// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY"]/*'/>
public enum D3D12CpuPageProperty
{
    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_NOT_AVAILABLE"]/*'/>

    NotAvailable = 1,

    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE"]/*'/>

    WriteCombine = 2,

    /// <include file='D3D12_CPU_PAGE_PROPERTY.xml' path='doc/member[@name="D3D12_CPU_PAGE_PROPERTY.D3D12_CPU_PAGE_PROPERTY_WRITE_BACK"]/*'/>

    WriteBack = 3,
}
