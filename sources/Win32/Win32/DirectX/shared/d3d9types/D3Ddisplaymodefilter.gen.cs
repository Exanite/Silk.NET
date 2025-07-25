// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER"]/*'/>
public partial struct D3Ddisplaymodefilter
{
    /// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER.Size"]/*'/>

    public uint Size;

    /// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER.Format"]/*'/>

    public D3Dformat Format;

    /// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER.ScanLineOrdering"]/*'/>

    public D3Dscanlineordering ScanLineOrdering;
}
