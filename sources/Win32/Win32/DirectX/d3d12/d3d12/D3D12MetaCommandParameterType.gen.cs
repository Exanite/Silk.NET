// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE"]/*'/>
public enum D3D12MetaCommandParameterType
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_FLOAT"]/*'/>

    Float = 0,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_UINT64"]/*'/>

    Uint64 = 1,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_GPU_VIRTUAL_ADDRESS"]/*'/>

    GpuVirtualAddress = 2,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_CPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV"]/*'/>

    CpuDescriptorHandleHeapTypeCbvSrvUav = 3,

    /// <include file='D3D12_META_COMMAND_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_TYPE.D3D12_META_COMMAND_PARAMETER_TYPE_GPU_DESCRIPTOR_HANDLE_HEAP_TYPE_CBV_SRV_UAV"]/*'/>

    GpuDescriptorHandleHeapTypeCbvSrvUav = 4,
}
