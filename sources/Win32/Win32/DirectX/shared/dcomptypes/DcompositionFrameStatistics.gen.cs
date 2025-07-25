// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct DcompositionFrameStatistics
{
    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.lastFrameTime"]/*'/>

    public LargeInteger LastFrameTime;

    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.currentCompositionRate"]/*'/>

    public DxgiRational CurrentCompositionRate;

    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.currentTime"]/*'/>

    public LargeInteger CurrentTime;

    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.timeFrequency"]/*'/>

    public LargeInteger TimeFrequency;

    /// <include file='DCOMPOSITION_FRAME_STATISTICS.xml' path='doc/member[@name="DCOMPOSITION_FRAME_STATISTICS.nextEstimatedFrameTime"]/*'/>

    public LargeInteger NextEstimatedFrameTime;
}
