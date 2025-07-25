// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC"]/*'/>
public partial struct DxgiSwapChainDesc
{
    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferDesc"]/*'/>

    public DxgiModeDesc BufferDesc;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.SampleDesc"]/*'/>

    public DxgiSampleDesc SampleDesc;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferUsage"]/*'/>

    [NativeTypeName("DXGI_USAGE")]
    public uint BufferUsage;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.BufferCount"]/*'/>

    public uint BufferCount;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.OutputWindow"]/*'/>

    public HWND OutputWindow;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.Windowed"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Windowed;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.SwapEffect"]/*'/>

    public DxgiSwapEffect SwapEffect;

    /// <include file='DXGI_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC.Flags"]/*'/>

    public uint Flags;
}
