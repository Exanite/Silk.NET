// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceShaderAtomicFloat2FeaturesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat16Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat16AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat16AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat64AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat16Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat16AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat16AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat64AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint ShaderImageFloat32AtomicMinMax;

    [NativeTypeName("VkBool32")]
    public uint SparseImageFloat32AtomicMinMax;
}
