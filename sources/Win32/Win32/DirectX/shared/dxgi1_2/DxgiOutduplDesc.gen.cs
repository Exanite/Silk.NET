// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTDUPL_DESC.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC"]/*'/>
public partial struct DxgiOutduplDesc
{
    /// <include file='DXGI_OUTDUPL_DESC.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC.ModeDesc"]/*'/>

    public DxgiModeDesc ModeDesc;

    /// <include file='DXGI_OUTDUPL_DESC.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC.Rotation"]/*'/>

    public DxgiModeRotation Rotation;

    /// <include file='DXGI_OUTDUPL_DESC.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC.DesktopImageInSystemMemory"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> DesktopImageInSystemMemory;
}
