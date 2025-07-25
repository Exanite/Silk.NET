// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT"]/*'/>
public enum D3Dswapeffect
{
    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD"]/*'/>

    Discard = 1,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FLIP"]/*'/>

    Flip = 2,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_COPY"]/*'/>

    Copy = 3,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_OVERLAY"]/*'/>

    Overlay = 4,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FLIPEX"]/*'/>

    Flipex = 5,

    /// <include file='D3DSWAPEFFECT.xml' path='doc/member[@name="D3DSWAPEFFECT.D3DSWAPEFFECT_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
