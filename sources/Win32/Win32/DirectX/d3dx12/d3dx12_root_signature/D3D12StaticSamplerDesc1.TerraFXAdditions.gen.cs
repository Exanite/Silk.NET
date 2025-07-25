// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12StaticSamplerDesc1
{
    public D3D12_STATIC_SAMPLER_DESC1(
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC &")] in D3D12StaticSamplerDesc o
    )
    {
        Unsafe.As<D3D12StaticSamplerDesc1, D3D12StaticSamplerDesc>(ref this) = o;
        Flags = D3D12SamplerFlags.None;
    }

    public D3D12_STATIC_SAMPLER_DESC1(
        uint shaderRegister,
        D3D12Filter filter = D3D12Filter.Anisotropic,
        D3D12TextureAddressMode addressU = D3D12TextureAddressMode.Wrap,
        D3D12TextureAddressMode addressV = D3D12TextureAddressMode.Wrap,
        D3D12TextureAddressMode addressW = D3D12TextureAddressMode.Wrap,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        D3D12ComparisonFunc comparisonFunc = D3D12ComparisonFunc.LessEqual,
        D3D12StaticBorderColor borderColor = D3D12StaticBorderColor.OpaqueWhite,
        float minLOD = 0.0f,
        float maxLOD = (3.402823466e+38f),
        D3D12ShaderVisibility shaderVisibility = D3D12ShaderVisibility.All,
        uint registerSpace = 0,
        D3D12SamplerFlags flags = D3D12SamplerFlags.None
    )
    {
        Init(
            shaderRegister,
            filter,
            addressU,
            addressV,
            addressW,
            mipLODBias,
            maxAnisotropy,
            comparisonFunc,
            borderColor,
            minLOD,
            maxLOD,
            shaderVisibility,
            registerSpace,
            flags
        );
    }

    public static void Init(
        [NativeTypeName("D3D12_STATIC_SAMPLER_DESC1 &")] ref D3D12StaticSamplerDesc1 samplerDesc,
        uint shaderRegister,
        D3D12Filter filter = D3D12Filter.Anisotropic,
        D3D12TextureAddressMode addressU = D3D12TextureAddressMode.Wrap,
        D3D12TextureAddressMode addressV = D3D12TextureAddressMode.Wrap,
        D3D12TextureAddressMode addressW = D3D12TextureAddressMode.Wrap,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        D3D12ComparisonFunc comparisonFunc = D3D12ComparisonFunc.LessEqual,
        D3D12StaticBorderColor borderColor = D3D12StaticBorderColor.OpaqueWhite,
        float minLOD = 0.0f,
        float maxLOD = (3.402823466e+38f),
        D3D12ShaderVisibility shaderVisibility = D3D12ShaderVisibility.All,
        uint registerSpace = 0,
        D3D12SamplerFlags flags = D3D12SamplerFlags.None
    )
    {
        samplerDesc.ShaderRegister = shaderRegister;
        samplerDesc.Filter = filter;
        samplerDesc.AddressU = addressU;
        samplerDesc.AddressV = addressV;
        samplerDesc.AddressW = addressW;
        samplerDesc.MipLODBias = mipLODBias;
        samplerDesc.MaxAnisotropy = maxAnisotropy;
        samplerDesc.ComparisonFunc = comparisonFunc;
        samplerDesc.BorderColor = borderColor;
        samplerDesc.MinLOD = minLOD;
        samplerDesc.MaxLOD = maxLOD;
        samplerDesc.ShaderVisibility = shaderVisibility;
        samplerDesc.RegisterSpace = registerSpace;
        samplerDesc.Flags = flags;
    }

    public void Init(
        uint shaderRegister,
        D3D12Filter filter = D3D12Filter.Anisotropic,
        D3D12TextureAddressMode addressU = D3D12TextureAddressMode.Wrap,
        D3D12TextureAddressMode addressV = D3D12TextureAddressMode.Wrap,
        D3D12TextureAddressMode addressW = D3D12TextureAddressMode.Wrap,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        D3D12ComparisonFunc comparisonFunc = D3D12ComparisonFunc.LessEqual,
        D3D12StaticBorderColor borderColor = D3D12StaticBorderColor.OpaqueWhite,
        float minLOD = 0.0f,
        float maxLOD = (3.402823466e+38f),
        D3D12ShaderVisibility shaderVisibility = D3D12ShaderVisibility.All,
        uint registerSpace = 0,
        D3D12SamplerFlags flags = D3D12SamplerFlags.None
    )
    {
        Init(
            ref this,
            shaderRegister,
            filter,
            addressU,
            addressV,
            addressW,
            mipLODBias,
            maxAnisotropy,
            comparisonFunc,
            borderColor,
            minLOD,
            maxLOD,
            shaderVisibility,
            registerSpace,
            flags
        );
    }
}
