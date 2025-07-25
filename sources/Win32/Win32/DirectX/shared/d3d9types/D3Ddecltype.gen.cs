// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE"]/*'/>
public enum D3Ddecltype
{
    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_FLOAT1"]/*'/>

    Float1 = 0,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_FLOAT2"]/*'/>

    Float2 = 1,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_FLOAT3"]/*'/>

    Float3 = 2,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_FLOAT4"]/*'/>

    Float4 = 3,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_D3DCOLOR"]/*'/>

    D3Dcolor = 4,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_UBYTE4"]/*'/>

    Ubyte4 = 5,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_SHORT2"]/*'/>

    Short2 = 6,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_SHORT4"]/*'/>

    Short4 = 7,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_UBYTE4N"]/*'/>

    Ubyte4N = 8,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_SHORT2N"]/*'/>

    Short2N = 9,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_SHORT4N"]/*'/>

    Short4N = 10,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_USHORT2N"]/*'/>

    Ushort2N = 11,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_USHORT4N"]/*'/>

    Ushort4N = 12,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_UDEC3"]/*'/>

    Udec3 = 13,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_DEC3N"]/*'/>

    Dec3N = 14,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_FLOAT16_2"]/*'/>

    Float16X2 = 15,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_FLOAT16_4"]/*'/>

    Float16X4 = 16,

    /// <include file='D3DDECLTYPE.xml' path='doc/member[@name="D3DDECLTYPE.D3DDECLTYPE_UNUSED"]/*'/>

    Unused = 17,
}
