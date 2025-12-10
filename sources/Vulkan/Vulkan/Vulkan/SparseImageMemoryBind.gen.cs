// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct SparseImageMemoryBind
{
    public ImageSubresource Subresource;
    public Offset3D Offset;
    public Extent3D Extent;

    [NativeTypeName("VkDeviceMemory")]
    public DeviceMemoryHandle Memory;

    [NativeTypeName("VkDeviceSize")]
    public ulong MemoryOffset;

    [NativeTypeName("VkSparseMemoryBindFlags")]
    public SparseMemoryBindFlags Flags;
}
