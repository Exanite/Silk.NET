// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct SparseImageMemoryRequirements
{
    public SparseImageFormatProperties FormatProperties;

    [NativeTypeName("uint32_t")]
    public uint ImageMipTailFirstLod;

    [NativeTypeName("VkDeviceSize")]
    public ulong ImageMipTailSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong ImageMipTailOffset;

    [NativeTypeName("VkDeviceSize")]
    public ulong ImageMipTailStride;
}
