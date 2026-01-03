// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum SamplerReductionMode : uint
{
    WeightedAverage = 0,
    Min = 1,
    Max = 2,
    WeightedAverageRangeclampQCOM = 1000521000,
    WeightedAverageEXT = WeightedAverage,
    MinEXT = Min,
    MaxEXT = Max,
}
