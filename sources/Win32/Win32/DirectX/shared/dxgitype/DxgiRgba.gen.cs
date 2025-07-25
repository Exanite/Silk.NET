// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA"]/*'/>
public partial struct DxgiRgba
{
    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.r"]/*'/>

    public float R;

    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.g"]/*'/>

    public float G;

    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.b"]/*'/>

    public float B;

    /// <include file='DXGI_RGBA.xml' path='doc/member[@name="DXGI_RGBA.a"]/*'/>

    public float A;
}
