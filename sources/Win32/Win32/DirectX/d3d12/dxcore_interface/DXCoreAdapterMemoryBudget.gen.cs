// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreAdapterMemoryBudget
{
    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.budget"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong Budget;

    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.currentUsage"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong CurrentUsage;

    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.availableForReservation"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong AvailableForReservation;

    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.currentReservation"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong CurrentReservation;
}
