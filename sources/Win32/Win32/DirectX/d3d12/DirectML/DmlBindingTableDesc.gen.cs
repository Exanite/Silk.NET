// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC"]/*'/>
public unsafe partial struct DmlBindingTableDesc
{
    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.Dispatchable"]/*'/>

    public IDMLDispatchable Dispatchable;

    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.CPUDescriptorHandle"]/*'/>

    public D3D12CpuDescriptorHandle CPUDescriptorHandle;

    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.GPUDescriptorHandle"]/*'/>

    public D3D12GpuDescriptorHandle GPUDescriptorHandle;

    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.SizeInDescriptors"]/*'/>

    public uint SizeInDescriptors;
}
