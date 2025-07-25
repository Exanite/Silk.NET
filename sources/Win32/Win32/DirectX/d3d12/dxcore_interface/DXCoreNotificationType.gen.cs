// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType"]/*'/>
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreNotificationType : uint
{
    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterListStale"]/*'/>

    ListStale = 0,

    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterNoLongerValid"]/*'/>

    NoLongerValid = 1,

    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterBudgetChange"]/*'/>

    BudgetChange = 2,

    /// <include file='DXCoreNotificationType.xml' path='doc/member[@name="DXCoreNotificationType.AdapterHardwareContentProtectionTeardown"]/*'/>

    HardwareContentProtectionTeardown = 3,
}
