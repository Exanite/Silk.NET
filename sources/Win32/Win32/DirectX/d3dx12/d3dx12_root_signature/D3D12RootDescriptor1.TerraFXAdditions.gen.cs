// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12RootDescriptor1
{
    public D3D12_ROOT_DESCRIPTOR1(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None
    )
    {
        Init(shaderRegister, registerSpace, flags);
    }

    public void Init(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None
    )
    {
        Init(ref this, shaderRegister, registerSpace, flags);
    }

    public static void Init(
        [NativeTypeName("D3D12_ROOT_DESCRIPTOR1 &")] ref D3D12RootDescriptor1 table,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12RootDescriptorFlags flags = D3D12RootDescriptorFlags.None
    )
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
        table.Flags = flags;
    }
}
