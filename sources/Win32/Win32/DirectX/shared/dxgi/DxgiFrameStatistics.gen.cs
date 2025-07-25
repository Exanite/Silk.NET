// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_FRAME_STATISTICS.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS"]/*'/>
public partial struct DxgiFrameStatistics
{
    /// <include file='DXGI_FRAME_STATISTICS.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS.PresentCount"]/*'/>

    public uint PresentCount;

    /// <include file='DXGI_FRAME_STATISTICS.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS.PresentRefreshCount"]/*'/>

    public uint PresentRefreshCount;

    /// <include file='DXGI_FRAME_STATISTICS.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS.SyncRefreshCount"]/*'/>

    public uint SyncRefreshCount;

    /// <include file='DXGI_FRAME_STATISTICS.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS.SyncQPCTime"]/*'/>

    public LargeInteger SyncQPCTime;

    /// <include file='DXGI_FRAME_STATISTICS.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS.SyncGPUTime"]/*'/>

    public LargeInteger SyncGPUTime;
}
