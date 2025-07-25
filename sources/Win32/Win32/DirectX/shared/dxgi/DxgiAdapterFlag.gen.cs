// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG"]/*'/>
[Flags]
public enum DxgiAdapterFlag
{
    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_REMOTE"]/*'/>

    Remote = 1,

    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_SOFTWARE"]/*'/>

    Software = 2,

    /// <include file='DXGI_ADAPTER_FLAG.xml' path='doc/member[@name="DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_FORCE_DWORD"]/*'/>

    ForceDword = unchecked((int)(0xffffffff)),
}
