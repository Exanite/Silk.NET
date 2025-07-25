// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum DcompositionBorderMode
{
    /// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE.DCOMPOSITION_BORDER_MODE_SOFT"]/*'/>

    Soft = 0,

    /// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE.DCOMPOSITION_BORDER_MODE_HARD"]/*'/>

    Hard = 1,

    /// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE.DCOMPOSITION_BORDER_MODE_INHERIT"]/*'/>

    Inherit = unchecked((int)(0xffffffff)),
}
