// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC"]/*'/>
public partial struct D3D12SamplerDesc
{
    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.Filter"]/*'/>

    public D3D12Filter Filter;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.AddressU"]/*'/>

    public D3D12TextureAddressMode AddressU;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.AddressV"]/*'/>

    public D3D12TextureAddressMode AddressV;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.AddressW"]/*'/>

    public D3D12TextureAddressMode AddressW;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MipLODBias"]/*'/>

    public float MipLODBias;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MaxAnisotropy"]/*'/>

    public uint MaxAnisotropy;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.ComparisonFunc"]/*'/>

    public D3D12ComparisonFunc ComparisonFunc;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.BorderColor"]/*'/>

    [NativeTypeName("FLOAT[4]")]
    public _BorderColor_e__FixedBuffer BorderColor;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MinLOD"]/*'/>

    public float MinLOD;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MaxLOD"]/*'/>

    public float MaxLOD;

    /// <include file='_BorderColor_e__FixedBuffer.xml' path='doc/member[@name="_BorderColor_e__FixedBuffer"]/*'/>

    [InlineArray(4)]
    public partial struct _BorderColor_e__FixedBuffer
    {
        public float e0;
    }
}
