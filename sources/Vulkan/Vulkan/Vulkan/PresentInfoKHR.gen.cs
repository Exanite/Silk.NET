// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PresentInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint WaitSemaphoreCount;

    [NativeTypeName("const VkSemaphore *")]
    [SupportedApiProfile("vulkan")]
    public SemaphoreHandle* PWaitSemaphores;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SwapchainCount;

    [NativeTypeName("const VkSwapchainKHR *")]
    [SupportedApiProfile("vulkan")]
    public SwapchainKHRHandle* PSwapchains;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PImageIndices;

    [SupportedApiProfile("vulkan")]
    public Result* PResults;
}
