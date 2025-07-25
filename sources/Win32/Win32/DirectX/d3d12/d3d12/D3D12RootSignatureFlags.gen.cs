// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS"]/*'/>
[Flags]
public enum D3D12RootSignatureFlags
{
    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_ALLOW_INPUT_ASSEMBLER_INPUT_LAYOUT"]/*'/>

    AllowInputAssemblerInputLayout = 0x1,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_VERTEX_SHADER_ROOT_ACCESS"]/*'/>

    DenyVertexShaderRootAccess = 0x2,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_HULL_SHADER_ROOT_ACCESS"]/*'/>

    DenyHullShaderRootAccess = 0x4,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_DOMAIN_SHADER_ROOT_ACCESS"]/*'/>

    DenyDomainShaderRootAccess = 0x8,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_GEOMETRY_SHADER_ROOT_ACCESS"]/*'/>

    DenyGeometryShaderRootAccess = 0x10,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_PIXEL_SHADER_ROOT_ACCESS"]/*'/>

    DenyPixelShaderRootAccess = 0x20,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_ALLOW_STREAM_OUTPUT"]/*'/>

    AllowStreamOutput = 0x40,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_LOCAL_ROOT_SIGNATURE"]/*'/>

    LocalRootSignature = 0x80,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_AMPLIFICATION_SHADER_ROOT_ACCESS"]/*'/>

    DenyAmplificationShaderRootAccess = 0x100,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_DENY_MESH_SHADER_ROOT_ACCESS"]/*'/>

    DenyMeshShaderRootAccess = 0x200,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_CBV_SRV_UAV_HEAP_DIRECTLY_INDEXED"]/*'/>

    CbvSrvUavHeapDirectlyIndexed = 0x400,

    /// <include file='D3D12_ROOT_SIGNATURE_FLAGS.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_FLAGS.D3D12_ROOT_SIGNATURE_FLAG_SAMPLER_HEAP_DIRECTLY_INDEXED"]/*'/>

    SamplerHeapDirectlyIndexed = 0x800,
}
