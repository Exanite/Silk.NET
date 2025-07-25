// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MAPPED_RECT.xml' path='doc/member[@name="DXGI_MAPPED_RECT"]/*'/>
public unsafe partial struct DxgiMappedRect
{
    /// <include file='DXGI_MAPPED_RECT.xml' path='doc/member[@name="DXGI_MAPPED_RECT.Pitch"]/*'/>

    public int Pitch;

    /// <include file='DXGI_MAPPED_RECT.xml' path='doc/member[@name="DXGI_MAPPED_RECT.pBits"]/*'/>

    public byte* PBits;
}
