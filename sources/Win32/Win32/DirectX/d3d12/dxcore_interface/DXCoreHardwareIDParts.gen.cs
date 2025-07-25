// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts"]/*'/>
public partial struct DXCoreHardwareIDParts
{
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.vendorID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint VendorID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.deviceID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint DeviceID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.subSystemID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint SubSystemID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.subVendorID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint SubVendorID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.revisionID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint RevisionID;
}
