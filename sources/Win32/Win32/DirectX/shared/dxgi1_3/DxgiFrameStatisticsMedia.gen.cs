// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA"]/*'/>
public partial struct DxgiFrameStatisticsMedia
{
    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.PresentCount"]/*'/>

    public uint PresentCount;

    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.PresentRefreshCount"]/*'/>

    public uint PresentRefreshCount;

    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.SyncRefreshCount"]/*'/>

    public uint SyncRefreshCount;

    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.SyncQPCTime"]/*'/>

    public LargeInteger SyncQPCTime;

    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.SyncGPUTime"]/*'/>

    public LargeInteger SyncGPUTime;

    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.CompositionMode"]/*'/>

    public DxgiFramePresentationMode CompositionMode;

    /// <include file='DXGI_FRAME_STATISTICS_MEDIA.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA.ApprovedPresentDuration"]/*'/>

    public uint ApprovedPresentDuration;
}
