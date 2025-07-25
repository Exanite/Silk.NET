// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG"]/*'/>
[Flags]
public enum DxgiSwapChainFlag
{
    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_NONPREROTATED"]/*'/>

    Nonprerotated = 1,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH"]/*'/>

    AllowModeSwitch = 2,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE"]/*'/>

    GdiCompatible = 4,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT"]/*'/>

    RestrictedContent = 8,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER"]/*'/>

    RestrictSharedResourceDriver = 16,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY"]/*'/>

    DisplayOnly = 32,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT"]/*'/>

    FrameLatencyWaitableObject = 64,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER"]/*'/>

    ForegroundLayer = 128,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO"]/*'/>

    FullscreenVideo = 256,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO"]/*'/>

    YuvVideo = 512,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED"]/*'/>

    HwProtected = 1024,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING"]/*'/>

    AllowTearing = 2048,

    /// <include file='DXGI_SWAP_CHAIN_FLAG.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FLAG.DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS"]/*'/>

    RestrictedToAllHolographicDisplays = 4096,
}
