// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE"]/*'/>
public enum D3Ddevtype
{
    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_HAL"]/*'/>

    Hal = 1,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_REF"]/*'/>

    Ref = 2,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_SW"]/*'/>

    Sw = 3,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_NULLREF"]/*'/>

    Nullref = 4,

    /// <include file='D3DDEVTYPE.xml' path='doc/member[@name="D3DDEVTYPE.D3DDEVTYPE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
