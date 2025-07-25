// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE"]/*'/>
public enum D3Ddeclusage
{
    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_POSITION"]/*'/>

    Position = 0,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_BLENDWEIGHT"]/*'/>

    Blendweight,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_BLENDINDICES"]/*'/>

    Blendindices,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_NORMAL"]/*'/>

    Normal,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_PSIZE"]/*'/>

    Psize,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_TEXCOORD"]/*'/>

    Texcoord,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_TANGENT"]/*'/>

    Tangent,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_BINORMAL"]/*'/>

    Binormal,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_TESSFACTOR"]/*'/>

    Tessfactor,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_POSITIONT"]/*'/>

    Positiont,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_COLOR"]/*'/>

    Color,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_FOG"]/*'/>

    Fog,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_DEPTH"]/*'/>

    Depth,

    /// <include file='D3DDECLUSAGE.xml' path='doc/member[@name="D3DDECLUSAGE.D3DDECLUSAGE_SAMPLE"]/*'/>

    Sample,
}
