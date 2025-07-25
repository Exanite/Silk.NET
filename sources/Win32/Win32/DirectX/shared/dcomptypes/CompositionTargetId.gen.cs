// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID"]/*'/>
[SupportedOSPlatform("windows10.0.22000.0")]
public partial struct CompositionTargetId
{
    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.displayAdapterLuid"]/*'/>

    public LUID DisplayAdapterLuid;

    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.renderAdapterLuid"]/*'/>

    public LUID RenderAdapterLuid;

    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.vidPnSourceId"]/*'/>

    public uint VidPnSourceId;

    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.vidPnTargetId"]/*'/>

    public uint VidPnTargetId;

    /// <include file='COMPOSITION_TARGET_ID.xml' path='doc/member[@name="COMPOSITION_TARGET_ID.uniqueId"]/*'/>

    public uint UniqueId;
}
