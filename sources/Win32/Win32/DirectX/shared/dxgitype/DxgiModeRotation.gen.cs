// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION"]/*'/>
public enum DxgiModeRotation
{
    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_UNSPECIFIED"]/*'/>

    Unspecified = 0,

    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_IDENTITY"]/*'/>

    Identity = 1,

    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_ROTATE90"]/*'/>

    Rotate90 = 2,

    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_ROTATE180"]/*'/>

    Rotate180 = 3,

    /// <include file='DXGI_MODE_ROTATION.xml' path='doc/member[@name="DXGI_MODE_ROTATION.DXGI_MODE_ROTATION_ROTATE270"]/*'/>

    Rotate270 = 4,
}
