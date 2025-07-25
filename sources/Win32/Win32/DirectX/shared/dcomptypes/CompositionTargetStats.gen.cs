// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS"]/*'/>
public partial struct CompositionTargetStats
{
    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.outstandingPresents"]/*'/>

    public uint OutstandingPresents;

    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.presentTime"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong PresentTime;

    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.vblankDuration"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong VblankDuration;

    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.presentedStats"]/*'/>

    public CompositionStats PresentedStats;

    /// <include file='COMPOSITION_TARGET_STATS.xml' path='doc/member[@name="COMPOSITION_TARGET_STATS.completedStats"]/*'/>

    public CompositionStats CompletedStats;
}
