// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC"]/*'/>
public partial struct DxgiModeDesc
{
    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Width"]/*'/>

    public uint Width;

    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Height"]/*'/>

    public uint Height;

    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.RefreshRate"]/*'/>

    public DxgiRational RefreshRate;

    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.ScanlineOrdering"]/*'/>

    public DxgiModeScanlineOrder ScanlineOrdering;

    /// <include file='DXGI_MODE_DESC.xml' path='doc/member[@name="DXGI_MODE_DESC.Scaling"]/*'/>

    public DxgiModeScaling Scaling;
}
