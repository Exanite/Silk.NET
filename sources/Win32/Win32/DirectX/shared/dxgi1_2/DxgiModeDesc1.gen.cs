// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1"]/*'/>
public partial struct DxgiModeDesc1
{
    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Width"]/*'/>

    public uint Width;

    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Height"]/*'/>

    public uint Height;

    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.RefreshRate"]/*'/>

    public DxgiRational RefreshRate;

    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.ScanlineOrdering"]/*'/>

    public DxgiModeScanlineOrder ScanlineOrdering;

    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Scaling"]/*'/>

    public DxgiModeScaling Scaling;

    /// <include file='DXGI_MODE_DESC1.xml' path='doc/member[@name="DXGI_MODE_DESC1.Stereo"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Stereo;
}
