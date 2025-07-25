// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12StaticSamplerDesc
{
    public D3D12_STATIC_SAMPLER_DESC(
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
        uint registerSpace = 0
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
            registerSpace
        );
    }

    public static void Init(
        [NativeTypeName("D3D12_STATIC_SAMPLER_DESC &")] ref D3D12StaticSamplerDesc samplerDesc,
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
        uint registerSpace = 0
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
        uint registerSpace = 0
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
            registerSpace
        );
    }
}
