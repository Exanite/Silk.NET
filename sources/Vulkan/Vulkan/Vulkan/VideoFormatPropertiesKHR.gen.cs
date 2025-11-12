// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoFormatPropertiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public Format Format;

    [SupportedApiProfile("vulkan")]
    public ComponentMapping ComponentMapping;

    [NativeTypeName("VkImageCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public ImageCreateFlags ImageCreateFlags;

    [SupportedApiProfile("vulkan")]
    public ImageType ImageType;

    [SupportedApiProfile("vulkan")]
    public ImageTiling ImageTiling;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan")]
    public ImageUsageFlags ImageUsageFlags;
}
