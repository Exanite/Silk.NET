// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DisplayPropertiesKHR
{
    [NativeTypeName("VkDisplayKHR")]
    public DisplayHandleKHR Display;

    [NativeTypeName("const char *")]
    public sbyte* DisplayName;
    public Extent2D PhysicalDimensions;
    public Extent2D PhysicalResolution;

    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    public SurfaceTransformFlagsKHR SupportedTransforms;

    [NativeTypeName("VkBool32")]
    public uint PlaneReorderPossible;

    [NativeTypeName("VkBool32")]
    public uint PersistentContent;
}
