// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum PipelineBindPoint : uint
{
    Graphics = 0,
    Compute = 1,
    RayTracingKHR = 1000165000,
    SubpassShadingHUAWEI = 1000369003,
    DataGraphARM = 1000507000,
    RayTracingNV = RayTracingKHR,
}
