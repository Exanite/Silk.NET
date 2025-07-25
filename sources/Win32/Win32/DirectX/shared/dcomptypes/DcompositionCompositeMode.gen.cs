// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum DcompositionCompositeMode
{
    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER"]/*'/>

    SourceOver = 0,

    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT"]/*'/>

    DestinationInvert = 1,

    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND"]/*'/>

    MinBlend = 2,

    /// <include file='DCOMPOSITION_COMPOSITE_MODE.xml' path='doc/member[@name="DCOMPOSITION_COMPOSITE_MODE.DCOMPOSITION_COMPOSITE_MODE_INHERIT"]/*'/>

    Inherit = unchecked((int)(0xffffffff)),
}
