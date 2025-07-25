// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12DescriptorRange1
{
    public D3D12_DESCRIPTOR_RANGE1(
        D3D12DescriptorRangeType rangeType,
        uint numDescriptors,
        uint baseShaderRegister,
        uint registerSpace = 0,
        D3D12DescriptorRangeFlags flags = D3D12DescriptorRangeFlags.None,
        uint offsetInDescriptorsFromTableStart = (0xffffffff)
    )
    {
        Init(
            rangeType,
            numDescriptors,
            baseShaderRegister,
            registerSpace,
            flags,
            offsetInDescriptorsFromTableStart
        );
    }

    public void Init(
        D3D12DescriptorRangeType rangeType,
        uint numDescriptors,
        uint baseShaderRegister,
        uint registerSpace = 0,
        D3D12DescriptorRangeFlags flags = D3D12DescriptorRangeFlags.None,
        uint offsetInDescriptorsFromTableStart = (0xffffffff)
    )
    {
        Init(
            ref this,
            rangeType,
            numDescriptors,
            baseShaderRegister,
            registerSpace,
            flags,
            offsetInDescriptorsFromTableStart
        );
    }

    public static void Init(
        [NativeTypeName("D3D12_DESCRIPTOR_RANGE1 &")] ref D3D12DescriptorRange1 range,
        D3D12DescriptorRangeType rangeType,
        uint numDescriptors,
        uint baseShaderRegister,
        uint registerSpace = 0,
        D3D12DescriptorRangeFlags flags = D3D12DescriptorRangeFlags.None,
        uint offsetInDescriptorsFromTableStart = (0xffffffff)
    )
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.Flags = flags;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
