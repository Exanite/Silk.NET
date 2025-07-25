// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY"]/*'/>
public enum D3D12ResidencyPriority
{
    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_MINIMUM"]/*'/>

    Minimum = 0x28000000,

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_LOW"]/*'/>

    Low = 0x50000000,

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_NORMAL"]/*'/>

    Normal = 0x78000000,

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_HIGH"]/*'/>

    High = unchecked((int)(0xa0010000)),

    /// <include file='D3D12_RESIDENCY_PRIORITY.xml' path='doc/member[@name="D3D12_RESIDENCY_PRIORITY.D3D12_RESIDENCY_PRIORITY_MAXIMUM"]/*'/>

    Maximum = unchecked((int)(0xc8000000)),
}
