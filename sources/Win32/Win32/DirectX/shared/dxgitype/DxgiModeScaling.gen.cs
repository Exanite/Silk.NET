// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING"]/*'/>
public enum DxgiModeScaling
{
    /// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING.DXGI_MODE_SCALING_UNSPECIFIED"]/*'/>

    Unspecified = 0,

    /// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING.DXGI_MODE_SCALING_CENTERED"]/*'/>

    Centered = 1,

    /// <include file='DXGI_MODE_SCALING.xml' path='doc/member[@name="DXGI_MODE_SCALING.DXGI_MODE_SCALING_STRETCHED"]/*'/>

    Stretched = 2,
}
