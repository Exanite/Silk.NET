// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND"]/*'/>
public enum D3Dblend
{
    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_ZERO"]/*'/>

    Zero = 1,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_ONE"]/*'/>

    One = 2,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCCOLOR"]/*'/>

    Srccolor = 3,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVSRCCOLOR"]/*'/>

    Invsrccolor = 4,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCALPHA"]/*'/>

    Srcalpha = 5,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVSRCALPHA"]/*'/>

    Invsrcalpha = 6,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_DESTALPHA"]/*'/>

    Destalpha = 7,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVDESTALPHA"]/*'/>

    Invdestalpha = 8,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_DESTCOLOR"]/*'/>

    Destcolor = 9,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVDESTCOLOR"]/*'/>

    Invdestcolor = 10,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCALPHASAT"]/*'/>

    Srcalphasat = 11,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_BOTHSRCALPHA"]/*'/>

    Bothsrcalpha = 12,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_BOTHINVSRCALPHA"]/*'/>

    Bothinvsrcalpha = 13,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_BLENDFACTOR"]/*'/>

    Blendfactor = 14,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVBLENDFACTOR"]/*'/>

    Invblendfactor = 15,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_SRCCOLOR2"]/*'/>

    Srccolor2 = 16,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_INVSRCCOLOR2"]/*'/>

    Invsrccolor2 = 17,

    /// <include file='D3DBLEND.xml' path='doc/member[@name="D3DBLEND.D3DBLEND_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
