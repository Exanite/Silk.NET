// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE"]/*'/>
public enum D3Dtexturestagestatetype
{
    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLOROP"]/*'/>

    Colorop = 1,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLORARG1"]/*'/>

    Colorarg1 = 2,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLORARG2"]/*'/>

    Colorarg2 = 3,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAOP"]/*'/>

    Alphaop = 4,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAARG1"]/*'/>

    Alphaarg1 = 5,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAARG2"]/*'/>

    Alphaarg2 = 6,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT00"]/*'/>

    Bumpenvmat00 = 7,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT01"]/*'/>

    Bumpenvmat01 = 8,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT10"]/*'/>

    Bumpenvmat10 = 9,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVMAT11"]/*'/>

    Bumpenvmat11 = 10,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_TEXCOORDINDEX"]/*'/>

    Texcoordindex = 11,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVLSCALE"]/*'/>

    Bumpenvlscale = 22,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_BUMPENVLOFFSET"]/*'/>

    Bumpenvloffset = 23,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_TEXTURETRANSFORMFLAGS"]/*'/>

    Texturetransformflags = 24,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_COLORARG0"]/*'/>

    Colorarg0 = 26,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_ALPHAARG0"]/*'/>

    Alphaarg0 = 27,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_RESULTARG"]/*'/>

    Resultarg = 28,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_CONSTANT"]/*'/>

    Constant = 32,

    /// <include file='D3DTEXTURESTAGESTATETYPE.xml' path='doc/member[@name="D3DTEXTURESTAGESTATETYPE.D3DTSS_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
