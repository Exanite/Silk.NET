// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceSubgroupProperties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint SubgroupSize;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags SupportedStages;

    [NativeTypeName("VkSubgroupFeatureFlags")]
    public SubgroupFeatureFlags SupportedOperations;

    [NativeTypeName("VkBool32")]
    public uint QuadOperationsInAllStages;
}
