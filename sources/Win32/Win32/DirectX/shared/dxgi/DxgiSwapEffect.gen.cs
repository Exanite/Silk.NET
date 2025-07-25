// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT"]/*'/>
public enum DxgiSwapEffect
{
    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_DISCARD"]/*'/>

    Discard = 0,

    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_SEQUENTIAL"]/*'/>

    Sequential = 1,

    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL"]/*'/>

    FlipSequential = 3,

    /// <include file='DXGI_SWAP_EFFECT.xml' path='doc/member[@name="DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_DISCARD"]/*'/>

    FlipDiscard = 4,
}
