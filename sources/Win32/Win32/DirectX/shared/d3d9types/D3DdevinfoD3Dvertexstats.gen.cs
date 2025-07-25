// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDEVINFO_D3DVERTEXSTATS.xml' path='doc/member[@name="D3DDEVINFO_D3DVERTEXSTATS"]/*'/>
public partial struct D3DdevinfoD3Dvertexstats
{
    /// <include file='D3DDEVINFO_D3DVERTEXSTATS.xml' path='doc/member[@name="D3DDEVINFO_D3DVERTEXSTATS.NumRenderedTriangles"]/*'/>

    [NativeTypeName("DWORD")]
    public uint NumRenderedTriangles;

    /// <include file='D3DDEVINFO_D3DVERTEXSTATS.xml' path='doc/member[@name="D3DDEVINFO_D3DVERTEXSTATS.NumExtraClippingTriangles"]/*'/>

    [NativeTypeName("DWORD")]
    public uint NumExtraClippingTriangles;
}
