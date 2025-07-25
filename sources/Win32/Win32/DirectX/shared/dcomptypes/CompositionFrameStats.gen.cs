// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS"]/*'/>
public partial struct CompositionFrameStats
{
    /// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS.startTime"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong StartTime;

    /// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS.targetTime"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong TargetTime;

    /// <include file='COMPOSITION_FRAME_STATS.xml' path='doc/member[@name="COMPOSITION_FRAME_STATS.framePeriod"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong FramePeriod;
}
