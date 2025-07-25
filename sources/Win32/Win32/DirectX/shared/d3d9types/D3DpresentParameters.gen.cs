// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS"]/*'/>
public partial struct D3DpresentParameters
{
    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferWidth"]/*'/>

    public uint BackBufferWidth;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferHeight"]/*'/>

    public uint BackBufferHeight;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferFormat"]/*'/>

    public D3Dformat BackBufferFormat;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.BackBufferCount"]/*'/>

    public uint BackBufferCount;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.MultiSampleType"]/*'/>

    public D3DmultisampleType MultiSampleType;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.MultiSampleQuality"]/*'/>

    [NativeTypeName("DWORD")]
    public uint MultiSampleQuality;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.SwapEffect"]/*'/>

    public D3Dswapeffect SwapEffect;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.hDeviceWindow"]/*'/>

    public HWND HDeviceWindow;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.Windowed"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Windowed;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.EnableAutoDepthStencil"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> EnableAutoDepthStencil;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.AutoDepthStencilFormat"]/*'/>

    public D3Dformat AutoDepthStencilFormat;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.Flags"]/*'/>

    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.FullScreen_RefreshRateInHz"]/*'/>

    public uint FullScreenRefreshRateInHz;

    /// <include file='D3DPRESENT_PARAMETERS.xml' path='doc/member[@name="D3DPRESENT_PARAMETERS.PresentationInterval"]/*'/>

    public uint PresentationInterval;
}
