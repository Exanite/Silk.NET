// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12RootParameter1
{
    public static void InitAsConstantBufferView(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        rootParam.ParameterType = D3D12RootParameterType.TypeCbv;
        rootParam.ShaderVisibility = visibility;
        D3D12RootDescriptor1.Init(
            ref rootParam.Anonymous.Descriptor,
            shaderRegister,
            registerSpace,
            flags
        );
    }

    public void InitAsConstantBufferView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        InitAsConstantBufferView(ref this, shaderRegister, registerSpace, flags, visibility);
    }

    public static void InitAsConstants(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12RootParameter1 rootParam,
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        rootParam.ParameterType = D3D12RootParameterType.Type32BitConstants;
        rootParam.ShaderVisibility = visibility;
        D3D12RootConstants.Init(
            ref rootParam.Anonymous.Constants,
            num32BitValues,
            shaderRegister,
            registerSpace
        );
    }

    public void InitAsConstants(
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        InitAsConstants(ref this, num32BitValues, shaderRegister, registerSpace, visibility);
    }

    public static void InitAsDescriptorTable(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12RootParameter1 rootParam,
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12DescriptorRange1* pDescriptorRanges,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        rootParam.ParameterType = D3D12RootParameterType.TypeDescriptorTable;
        rootParam.ShaderVisibility = visibility;
        D3D12RootDescriptorTable1.Init(
            ref rootParam.Anonymous.DescriptorTable,
            numDescriptorRanges,
            pDescriptorRanges
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void InitAsDescriptorTable(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12RootParameter1 rootParam,
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            Ref<D3D12DescriptorRange1> pDescriptorRanges,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        fixed (D3D12DescriptorRange1* __dsl_pDescriptorRanges = pDescriptorRanges)
        {
            InitAsDescriptorTable(
                ref rootParam,
                numDescriptorRanges,
                __dsl_pDescriptorRanges,
                visibility
            );
        }
    }

    public void InitAsDescriptorTable(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12DescriptorRange1* pDescriptorRanges,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        InitAsDescriptorTable(ref this, numDescriptorRanges, pDescriptorRanges, visibility);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void InitAsDescriptorTable(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            Ref<D3D12DescriptorRange1> pDescriptorRanges,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        fixed (D3D12DescriptorRange1* __dsl_pDescriptorRanges = pDescriptorRanges)
        {
            InitAsDescriptorTable(numDescriptorRanges, __dsl_pDescriptorRanges, visibility);
        }
    }

    public static void InitAsShaderResourceView(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        rootParam.ParameterType = D3D12RootParameterType.TypeSrv;
        rootParam.ShaderVisibility = visibility;
        D3D12RootDescriptor1.Init(
            ref rootParam.Anonymous.Descriptor,
            shaderRegister,
            registerSpace,
            flags
        );
    }

    public void InitAsShaderResourceView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        InitAsShaderResourceView(ref this, shaderRegister, registerSpace, flags, visibility);
    }

    public static void InitAsUnorderedAccessView(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        rootParam.ParameterType = D3D12RootParameterType.TypeUav;
        rootParam.ShaderVisibility = visibility;
        D3D12RootDescriptor1.Init(
            ref rootParam.Anonymous.Descriptor,
            shaderRegister,
            registerSpace,
            flags
        );
    }

    public void InitAsUnorderedAccessView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None,
        D3D12ShaderVisibility visibility = D3D12ShaderVisibility.All
    )
    {
        InitAsUnorderedAccessView(ref this, shaderRegister, registerSpace, flags, visibility);
    }
}
