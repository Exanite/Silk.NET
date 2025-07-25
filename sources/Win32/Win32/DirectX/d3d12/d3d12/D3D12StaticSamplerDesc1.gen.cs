// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1"]/*'/>
public partial struct D3D12StaticSamplerDesc1
{
    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.Filter"]/*'/>

    public D3D12Filter Filter;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.AddressU"]/*'/>

    public D3D12TextureAddressMode AddressU;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.AddressV"]/*'/>

    public D3D12TextureAddressMode AddressV;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.AddressW"]/*'/>

    public D3D12TextureAddressMode AddressW;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MipLODBias"]/*'/>

    public float MipLODBias;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MaxAnisotropy"]/*'/>

    public uint MaxAnisotropy;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.ComparisonFunc"]/*'/>

    public D3D12ComparisonFunc ComparisonFunc;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.BorderColor"]/*'/>

    public D3D12StaticBorderColor BorderColor;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MinLOD"]/*'/>

    public float MinLOD;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MaxLOD"]/*'/>

    public float MaxLOD;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.ShaderRegister"]/*'/>

    public uint ShaderRegister;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.RegisterSpace"]/*'/>

    public uint RegisterSpace;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.ShaderVisibility"]/*'/>

    public D3D12ShaderVisibility ShaderVisibility;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.Flags"]/*'/>

    public D3D12SamplerFlags Flags;
}
