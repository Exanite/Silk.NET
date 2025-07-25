// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC"]/*'/>
public unsafe partial struct D3D12RootSignatureDesc
{
    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.NumParameters"]/*'/>

    public uint NumParameters;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.pParameters"]/*'/>

    [NativeTypeName("const D3D12_ROOT_PARAMETER *")]
    public D3D12RootParameter* PParameters;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.NumStaticSamplers"]/*'/>

    public uint NumStaticSamplers;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.pStaticSamplers"]/*'/>

    [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
    public D3D12StaticSamplerDesc* PStaticSamplers;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.Flags"]/*'/>

    public D3D12RootSignatureFlags Flags;
}
