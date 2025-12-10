// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ImageViewCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkImageViewCreateFlags")]
    public ImageViewCreateFlags Flags;

    [NativeTypeName("VkImage")]
    public ImageHandle Image;
    public ImageViewType ViewType;
    public Format Format;
    public ComponentMapping Components;
    public ImageSubresourceRange SubresourceRange;
}
