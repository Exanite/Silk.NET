// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP"]/*'/>
public enum D3Dblendop
{
    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_ADD"]/*'/>

    Add = 1,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_SUBTRACT"]/*'/>

    Subtract = 2,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_REVSUBTRACT"]/*'/>

    Revsubtract = 3,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_MIN"]/*'/>

    Min = 4,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_MAX"]/*'/>

    Max = 5,

    /// <include file='D3DBLENDOP.xml' path='doc/member[@name="D3DBLENDOP.D3DBLENDOP_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
