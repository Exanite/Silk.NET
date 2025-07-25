// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD"]/*'/>
public enum D3Ddeclmethod
{
    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_DEFAULT"]/*'/>

    Default = 0,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_PARTIALU"]/*'/>

    Partialu,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_PARTIALV"]/*'/>

    Partialv,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_CROSSUV"]/*'/>

    Crossuv,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_UV"]/*'/>

    Uv,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_LOOKUP"]/*'/>

    Lookup,

    /// <include file='D3DDECLMETHOD.xml' path='doc/member[@name="D3DDECLMETHOD.D3DDECLMETHOD_LOOKUPPRESAMPLED"]/*'/>

    Lookuppresampled,
}
