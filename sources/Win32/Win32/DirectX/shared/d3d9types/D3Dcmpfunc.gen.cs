// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC"]/*'/>
public enum D3Dcmpfunc
{
    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_NEVER"]/*'/>

    Never = 1,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_LESS"]/*'/>

    Less = 2,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_EQUAL"]/*'/>

    Equal = 3,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_LESSEQUAL"]/*'/>

    Lessequal = 4,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_GREATER"]/*'/>

    Greater = 5,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_NOTEQUAL"]/*'/>

    Notequal = 6,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_GREATEREQUAL"]/*'/>

    Greaterequal = 7,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_ALWAYS"]/*'/>

    Always = 8,

    /// <include file='D3DCMPFUNC.xml' path='doc/member[@name="D3DCMPFUNC.D3DCMP_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
