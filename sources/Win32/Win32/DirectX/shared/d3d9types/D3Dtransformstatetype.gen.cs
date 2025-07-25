// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE"]/*'/>
public enum D3Dtransformstatetype
{
    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_VIEW"]/*'/>

    View = 2,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_PROJECTION"]/*'/>

    Projection = 3,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE0"]/*'/>

    Texture0 = 16,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE1"]/*'/>

    Texture1 = 17,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE2"]/*'/>

    Texture2 = 18,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE3"]/*'/>

    Texture3 = 19,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE4"]/*'/>

    Texture4 = 20,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE5"]/*'/>

    Texture5 = 21,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE6"]/*'/>

    Texture6 = 22,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_TEXTURE7"]/*'/>

    Texture7 = 23,

    /// <include file='D3DTRANSFORMSTATETYPE.xml' path='doc/member[@name="D3DTRANSFORMSTATETYPE.D3DTS_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
