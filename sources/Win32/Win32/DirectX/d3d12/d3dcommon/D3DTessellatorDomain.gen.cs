// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN"]/*'/>
public enum D3DTessellatorDomain
{
    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_UNDEFINED"]/*'/>

    DTessellatorDomainUndefined = 0,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_ISOLINE"]/*'/>

    DTessellatorDomainIsoline = 1,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_TRI"]/*'/>

    DTessellatorDomainTri = 2,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_QUAD"]/*'/>

    DTessellatorDomainQuad = 3,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_UNDEFINED"]/*'/>

    D11TessellatorDomainUndefined = DTessellatorDomainUndefined,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_ISOLINE"]/*'/>

    D11TessellatorDomainIsoline = DTessellatorDomainIsoline,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_TRI"]/*'/>

    D11TessellatorDomainTri = DTessellatorDomainTri,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_QUAD"]/*'/>

    D11TessellatorDomainQuad = DTessellatorDomainQuad,
}
