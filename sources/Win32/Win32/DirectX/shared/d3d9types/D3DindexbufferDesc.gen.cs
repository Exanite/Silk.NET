// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DINDEXBUFFER_DESC.xml' path='doc/member[@name="D3DINDEXBUFFER_DESC"]/*'/>
public partial struct D3DindexbufferDesc
{
    /// <include file='D3DINDEXBUFFER_DESC.xml' path='doc/member[@name="D3DINDEXBUFFER_DESC.Format"]/*'/>

    public D3Dformat Format;

    /// <include file='D3DINDEXBUFFER_DESC.xml' path='doc/member[@name="D3DINDEXBUFFER_DESC.Type"]/*'/>

    public D3Dresourcetype Type;

    /// <include file='D3DINDEXBUFFER_DESC.xml' path='doc/member[@name="D3DINDEXBUFFER_DESC.Usage"]/*'/>

    [NativeTypeName("DWORD")]
    public uint Usage;

    /// <include file='D3DINDEXBUFFER_DESC.xml' path='doc/member[@name="D3DINDEXBUFFER_DESC.Pool"]/*'/>

    public D3Dpool Pool;

    /// <include file='D3DINDEXBUFFER_DESC.xml' path='doc/member[@name="D3DINDEXBUFFER_DESC.Size"]/*'/>

    public uint Size;
}
