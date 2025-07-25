// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC"]/*'/>
public partial struct DxgiSurfaceDesc
{
    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.Width"]/*'/>

    public uint Width;

    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.Height"]/*'/>

    public uint Height;

    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='DXGI_SURFACE_DESC.xml' path='doc/member[@name="DXGI_SURFACE_DESC.SampleDesc"]/*'/>

    public DxgiSampleDesc SampleDesc;
}
