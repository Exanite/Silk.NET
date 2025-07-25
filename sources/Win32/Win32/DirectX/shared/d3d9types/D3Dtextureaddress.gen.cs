// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS"]/*'/>
public enum D3Dtextureaddress
{
    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_WRAP"]/*'/>

    Wrap = 1,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_MIRROR"]/*'/>

    Mirror = 2,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_CLAMP"]/*'/>

    Clamp = 3,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_BORDER"]/*'/>

    Border = 4,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_MIRRORONCE"]/*'/>

    Mirroronce = 5,

    /// <include file='D3DTEXTUREADDRESS.xml' path='doc/member[@name="D3DTEXTUREADDRESS.D3DTADDRESS_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
