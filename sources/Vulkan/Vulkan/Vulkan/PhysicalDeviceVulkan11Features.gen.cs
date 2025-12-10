// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan11Features
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint StorageBuffer16BitAccess;

    [NativeTypeName("VkBool32")]
    public uint UniformAndStorageBuffer16BitAccess;

    [NativeTypeName("VkBool32")]
    public uint StoragePushConstant16;

    [NativeTypeName("VkBool32")]
    public uint StorageInputOutput16;

    [NativeTypeName("VkBool32")]
    public uint Multiview;

    [NativeTypeName("VkBool32")]
    public uint MultiviewGeometryShader;

    [NativeTypeName("VkBool32")]
    public uint MultiviewTessellationShader;

    [NativeTypeName("VkBool32")]
    public uint VariablePointersStorageBuffer;

    [NativeTypeName("VkBool32")]
    public uint VariablePointers;

    [NativeTypeName("VkBool32")]
    public uint ProtectedMemory;

    [NativeTypeName("VkBool32")]
    public uint SamplerYcbcrConversion;

    [NativeTypeName("VkBool32")]
    public uint ShaderDrawParameters;
}
