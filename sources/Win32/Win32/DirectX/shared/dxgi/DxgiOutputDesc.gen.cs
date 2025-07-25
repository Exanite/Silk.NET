// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC"]/*'/>
public partial struct DxgiOutputDesc
{
    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.DeviceName"]/*'/>

    [NativeTypeName("WCHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.DesktopCoordinates"]/*'/>

    public RECT DesktopCoordinates;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.AttachedToDesktop"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AttachedToDesktop;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.Rotation"]/*'/>

    public DxgiModeRotation Rotation;

    /// <include file='DXGI_OUTPUT_DESC.xml' path='doc/member[@name="DXGI_OUTPUT_DESC.Monitor"]/*'/>

    public HMONITOR Monitor;

    /// <include file='_DeviceName_e__FixedBuffer.xml' path='doc/member[@name="_DeviceName_e__FixedBuffer"]/*'/>

    [InlineArray(32)]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public ushort e0;
    }
}
