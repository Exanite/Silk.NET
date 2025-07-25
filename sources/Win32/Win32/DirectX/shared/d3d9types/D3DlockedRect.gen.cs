// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DLOCKED_RECT.xml' path='doc/member[@name="D3DLOCKED_RECT"]/*'/>
public unsafe partial struct D3DlockedRect
{
    /// <include file='D3DLOCKED_RECT.xml' path='doc/member[@name="D3DLOCKED_RECT.Pitch"]/*'/>

    public int Pitch;

    /// <include file='D3DLOCKED_RECT.xml' path='doc/member[@name="D3DLOCKED_RECT.pBits"]/*'/>

    public void* PBits;
}
