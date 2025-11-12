// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AcquireNextImageInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkSwapchainKHR")]
    [SupportedApiProfile("vulkan")]
    public SwapchainKHRHandle Swapchain;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong Timeout;

    [NativeTypeName("VkSemaphore")]
    [SupportedApiProfile("vulkan")]
    public SemaphoreHandle Semaphore;

    [NativeTypeName("VkFence")]
    [SupportedApiProfile("vulkan")]
    public FenceHandle Fence;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DeviceMask;
}
