// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceShaderAtomicFloatFeaturesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat32Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat32AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat64Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferFloat64AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat32Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat32AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat64Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedFloat64AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint ShaderImageFloat32Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderImageFloat32AtomicAdd;

    [NativeTypeName("VkBool32")]
    public uint SparseImageFloat32Atomics;

    [NativeTypeName("VkBool32")]
    public uint SparseImageFloat32AtomicAdd;
}
