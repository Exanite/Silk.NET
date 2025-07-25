// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING"]/*'/>
public enum D3Dscanlineordering
{
    /// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING.D3DSCANLINEORDERING_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING.D3DSCANLINEORDERING_PROGRESSIVE"]/*'/>

    Progressive = 1,

    /// <include file='D3DSCANLINEORDERING.xml' path='doc/member[@name="D3DSCANLINEORDERING.D3DSCANLINEORDERING_INTERLACED"]/*'/>

    Interlaced = 2,
}
