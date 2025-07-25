// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DCLIPSTATUS9.xml' path='doc/member[@name="D3DCLIPSTATUS9"]/*'/>
public partial struct D3Dclipstatus9
{
    /// <include file='D3DCLIPSTATUS9.xml' path='doc/member[@name="D3DCLIPSTATUS9.ClipUnion"]/*'/>

    [NativeTypeName("DWORD")]
    public uint ClipUnion;

    /// <include file='D3DCLIPSTATUS9.xml' path='doc/member[@name="D3DCLIPSTATUS9.ClipIntersection"]/*'/>

    [NativeTypeName("DWORD")]
    public uint ClipIntersection;
}
