// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3"]/*'/>
[Flags]
public enum DxgiAdapterFlag3
{
    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_NONE"]/*'/>

    None = 0,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_REMOTE"]/*'/>

    Remote = 1,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_SOFTWARE"]/*'/>

    Software = 2,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE"]/*'/>

    AcgCompatible = 4,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES"]/*'/>

    SupportMonitoredFences = 8,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES"]/*'/>

    SupportNonMonitoredFences = 0x10,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE"]/*'/>

    KeyedMutexConformance = 0x20,

    /// <include file='DXGI_ADAPTER_FLAG3.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG3.DXGI_ADAPTER_FLAG3_FORCE_DWORD"]/*'/>

    ForceDword = unchecked((int)(0xffffffff)),
}
