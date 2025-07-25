// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum DcompositionBackfaceVisibility
{
    /// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY.DCOMPOSITION_BACKFACE_VISIBILITY_VISIBLE"]/*'/>

    Visible = 0,

    /// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY.DCOMPOSITION_BACKFACE_VISIBILITY_HIDDEN"]/*'/>

    Hidden = 1,

    /// <include file='DCOMPOSITION_BACKFACE_VISIBILITY.xml' path='doc/member[@name="DCOMPOSITION_BACKFACE_VISIBILITY.DCOMPOSITION_BACKFACE_VISIBILITY_INHERIT"]/*'/>

    Inherit = unchecked((int)(0xffffffff)),
}
