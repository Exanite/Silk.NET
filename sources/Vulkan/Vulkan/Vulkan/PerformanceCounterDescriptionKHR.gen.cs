// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PerformanceCounterDescriptionKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkPerformanceCounterDescriptionFlagsKHR")]
    public PerformanceCounterDescriptionFlagsKHR Flags;

    [NativeTypeName("char[256]")]
    public PerformanceCounterDescriptionKHRName Name;

    [NativeTypeName("char[256]")]
    public PerformanceCounterDescriptionKHRCategory Category;

    [NativeTypeName("char[256]")]
    public PerformanceCounterDescriptionKHRDescription Description;
}
