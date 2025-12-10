// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceLineRasterizationFeatures
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint RectangularLines;

    [NativeTypeName("VkBool32")]
    public uint BresenhamLines;

    [NativeTypeName("VkBool32")]
    public uint SmoothLines;

    [NativeTypeName("VkBool32")]
    public uint StippledRectangularLines;

    [NativeTypeName("VkBool32")]
    public uint StippledBresenhamLines;

    [NativeTypeName("VkBool32")]
    public uint StippledSmoothLines;
}
