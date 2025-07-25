// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE"]/*'/>
public enum DxgiAlphaMode
{
    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_UNSPECIFIED"]/*'/>

    Unspecified = 0,

    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED"]/*'/>

    Premultiplied = 1,

    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_STRAIGHT"]/*'/>

    Straight = 2,

    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_IGNORE"]/*'/>

    Ignore = 3,

    /// <include file='DXGI_ALPHA_MODE.xml' path='doc/member[@name="DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_FORCE_DWORD"]/*'/>

    ForceDword = unchecked((int)(0xffffffff)),
}
