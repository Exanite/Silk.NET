// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3"]/*'/>
public partial struct DxgiAdapterDesc3
{
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.Description"]/*'/>

    [NativeTypeName("WCHAR[128]")]
    public _Description_e__FixedBuffer Description;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.VendorId"]/*'/>

    public uint VendorId;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.DeviceId"]/*'/>

    public uint DeviceId;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.SubSysId"]/*'/>

    public uint SubSysId;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.Revision"]/*'/>

    public uint Revision;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.DedicatedVideoMemory"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.DedicatedSystemMemory"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.SharedSystemMemory"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.AdapterLuid"]/*'/>

    public LUID AdapterLuid;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.Flags"]/*'/>

    public DxgiAdapterFlag3 Flags;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.GraphicsPreemptionGranularity"]/*'/>

    public DxgiGraphicsPreemptionGranularity GraphicsPreemptionGranularity;

    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.ComputePreemptionGranularity"]/*'/>

    public DxgiComputePreemptionGranularity ComputePreemptionGranularity;

    /// <include file='_Description_e__FixedBuffer.xml' path='doc/member[@name="_Description_e__FixedBuffer"]/*'/>

    [InlineArray(128)]
    public partial struct _Description_e__FixedBuffer
    {
        public ushort e0;
    }
}
