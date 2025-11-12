// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct SwapchainCreateInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkSwapchainCreateFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public SwapchainCreateFlagsKHR Flags;

    [NativeTypeName("VkSurfaceKHR")]
    [SupportedApiProfile("vulkan")]
    public SurfaceKHRHandle Surface;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinImageCount;

    [SupportedApiProfile("vulkan")]
    public Format ImageFormat;

    [SupportedApiProfile("vulkan")]
    public ColorSpaceKHR ImageColorSpace;

    [SupportedApiProfile("vulkan")]
    public Extent2D ImageExtent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ImageArrayLayers;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan")]
    public ImageUsageFlags ImageUsage;

    [SupportedApiProfile("vulkan")]
    public SharingMode ImageSharingMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueFamilyIndexCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PQueueFamilyIndices;

    [SupportedApiProfile("vulkan")]
    public SurfaceTransformFlagsKHR PreTransform;

    [SupportedApiProfile("vulkan")]
    public CompositeAlphaFlagsKHR CompositeAlpha;

    [SupportedApiProfile("vulkan")]
    public PresentModeKHR PresentMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> Clipped;

    [NativeTypeName("VkSwapchainKHR")]
    [SupportedApiProfile("vulkan")]
    public SwapchainKHRHandle OldSwapchain;
}
