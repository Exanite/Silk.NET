// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY"]/*'/>
public enum DxgiResidency
{
    /// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY.DXGI_RESIDENCY_FULLY_RESIDENT"]/*'/>

    FullyResident = 1,

    /// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY.DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY"]/*'/>

    ResidentInSharedMemory = 2,

    /// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY.DXGI_RESIDENCY_EVICTED_TO_DISK"]/*'/>

    EvictedToDisk = 3,
}
