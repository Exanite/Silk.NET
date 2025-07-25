// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE"]/*'/>
public enum D3Dtexturefiltertype
{
    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_NONE"]/*'/>

    None = 0,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_POINT"]/*'/>

    Point = 1,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_LINEAR"]/*'/>

    Linear = 2,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_ANISOTROPIC"]/*'/>

    Anisotropic = 3,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_PYRAMIDALQUAD"]/*'/>

    Pyramidalquad = 6,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_GAUSSIANQUAD"]/*'/>

    Gaussianquad = 7,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_CONVOLUTIONMONO"]/*'/>

    Convolutionmono = 8,

    /// <include file='D3DTEXTUREFILTERTYPE.xml' path='doc/member[@name="D3DTEXTUREFILTERTYPE.D3DTEXF_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
