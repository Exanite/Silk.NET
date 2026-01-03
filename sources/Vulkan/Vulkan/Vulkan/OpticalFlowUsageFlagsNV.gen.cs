// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum OpticalFlowUsageFlagsNV : uint
{
    Unknown = 0x0,
    InputBit = 0x1,
    OutputBit = 0x2,
    HintBit = 0x4,
    CostBit = 0x8,
    GlobalFlowBit = 0x10,
}
