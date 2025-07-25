// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE"]/*'/>
public enum D3Dshademode
{
    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_FLAT"]/*'/>

    Flat = 1,

    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_GOURAUD"]/*'/>

    Gouraud = 2,

    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_PHONG"]/*'/>

    Phong = 3,

    /// <include file='D3DSHADEMODE.xml' path='doc/member[@name="D3DSHADEMODE.D3DSHADE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
