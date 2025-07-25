// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS"]/*'/>
public partial struct D3Dpresentstats
{
    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.PresentCount"]/*'/>

    public uint PresentCount;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.PresentRefreshCount"]/*'/>

    public uint PresentRefreshCount;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.SyncRefreshCount"]/*'/>

    public uint SyncRefreshCount;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.SyncQPCTime"]/*'/>

    public LargeInteger SyncQPCTime;

    /// <include file='D3DPRESENTSTATS.xml' path='doc/member[@name="D3DPRESENTSTATS.SyncGPUTime"]/*'/>

    public LargeInteger SyncGPUTime;
}
