// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreHardwareID
{
    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.vendorID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint VendorID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.deviceID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint DeviceID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.subSysID"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint SubSysID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.revision"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint Revision;
}
