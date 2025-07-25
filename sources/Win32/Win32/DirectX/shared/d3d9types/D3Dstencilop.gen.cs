// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP"]/*'/>
public enum D3Dstencilop
{
    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_KEEP"]/*'/>

    Keep = 1,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_ZERO"]/*'/>

    Zero = 2,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_REPLACE"]/*'/>

    Replace = 3,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_INCRSAT"]/*'/>

    Incrsat = 4,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_DECRSAT"]/*'/>

    Decrsat = 5,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_INVERT"]/*'/>

    Invert = 6,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_INCR"]/*'/>

    Incr = 7,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_DECR"]/*'/>

    Decr = 8,

    /// <include file='D3DSTENCILOP.xml' path='doc/member[@name="D3DSTENCILOP.D3DSTENCILOP_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
