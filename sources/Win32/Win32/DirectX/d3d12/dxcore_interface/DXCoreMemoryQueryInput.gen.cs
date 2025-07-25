// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreMemoryQueryInput.xml' path='doc/member[@name="DXCoreMemoryQueryInput"]/*'/>
public partial struct DXCoreMemoryQueryInput
{
    /// <include file='DXCoreMemoryQueryInput.xml' path='doc/member[@name="DXCoreMemoryQueryInput.physicalAdapterIndex"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint PhysicalAdapterIndex;

    /// <include file='DXCoreMemoryQueryInput.xml' path='doc/member[@name="DXCoreMemoryQueryInput.memoryType"]/*'/>

    public DXCoreMemoryType MemoryType;
}
