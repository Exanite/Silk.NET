// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS"]/*'/>
public enum DxgiReclaimResourceResults
{
    /// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS.DXGI_RECLAIM_RESOURCE_RESULT_OK"]/*'/>

    Ok = 0,

    /// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS.DXGI_RECLAIM_RESOURCE_RESULT_DISCARDED"]/*'/>

    Discarded = 1,

    /// <include file='DXGI_RECLAIM_RESOURCE_RESULTS.xml' path='doc/member[@name="DXGI_RECLAIM_RESOURCE_RESULTS.DXGI_RECLAIM_RESOURCE_RESULT_NOT_COMMITTED"]/*'/>

    NotCommitted = 2,
}
