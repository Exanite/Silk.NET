// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC"]/*'/>
public partial struct DxgiSwapChainFullscreenDesc
{
    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.RefreshRate"]/*'/>

    public DxgiRational RefreshRate;

    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.ScanlineOrdering"]/*'/>

    public DxgiModeScanlineOrder ScanlineOrdering;

    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.Scaling"]/*'/>

    public DxgiModeScaling Scaling;

    /// <include file='DXGI_SWAP_CHAIN_FULLSCREEN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC.Windowed"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Windowed;
}
