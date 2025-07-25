// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DCOMPOSERECTDESC.xml' path='doc/member[@name="D3DCOMPOSERECTDESC"]/*'/>
public partial struct D3Dcomposerectdesc
{
    /// <include file='D3DCOMPOSERECTDESC.xml' path='doc/member[@name="D3DCOMPOSERECTDESC.X"]/*'/>

    public ushort X;

    /// <include file='D3DCOMPOSERECTDESC.xml' path='doc/member[@name="D3DCOMPOSERECTDESC.Y"]/*'/>

    public ushort Y;

    /// <include file='D3DCOMPOSERECTDESC.xml' path='doc/member[@name="D3DCOMPOSERECTDESC.Width"]/*'/>

    public ushort Width;

    /// <include file='D3DCOMPOSERECTDESC.xml' path='doc/member[@name="D3DCOMPOSERECTDESC.Height"]/*'/>

    public ushort Height;
}
