// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO"]/*'/>
public partial struct D3DrectpatchInfo
{
    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.StartVertexOffsetWidth"]/*'/>

    public uint StartVertexOffsetWidth;

    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.StartVertexOffsetHeight"]/*'/>

    public uint StartVertexOffsetHeight;

    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.Width"]/*'/>

    public uint Width;

    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.Height"]/*'/>

    public uint Height;

    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.Stride"]/*'/>

    public uint Stride;

    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.Basis"]/*'/>

    public D3Dbasistype Basis;

    /// <include file='D3DRECTPATCH_INFO.xml' path='doc/member[@name="D3DRECTPATCH_INFO.Degree"]/*'/>

    public D3Ddegreetype Degree;
}
