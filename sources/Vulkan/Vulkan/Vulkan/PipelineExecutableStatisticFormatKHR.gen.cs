// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public enum PipelineExecutableStatisticFormatKHR : uint
{
    Bool32 = 0,
    Int64 = 1,
    Uint64 = 2,
    Float64 = 3,
}
