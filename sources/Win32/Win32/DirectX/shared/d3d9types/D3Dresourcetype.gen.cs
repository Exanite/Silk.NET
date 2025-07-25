// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE"]/*'/>
public enum D3Dresourcetype
{
    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_SURFACE"]/*'/>

    Surface = 1,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VOLUME"]/*'/>

    Volume = 2,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_TEXTURE"]/*'/>

    Texture = 3,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VOLUMETEXTURE"]/*'/>

    Volumetexture = 4,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_CUBETEXTURE"]/*'/>

    Cubetexture = 5,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_VERTEXBUFFER"]/*'/>

    Vertexbuffer = 6,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_INDEXBUFFER"]/*'/>

    Indexbuffer = 7,

    /// <include file='D3DRESOURCETYPE.xml' path='doc/member[@name="D3DRESOURCETYPE.D3DRTYPE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
