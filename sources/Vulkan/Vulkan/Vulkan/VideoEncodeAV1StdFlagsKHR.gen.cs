// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeAV1StdFlagsKHR : uint
{
    None = 0x0,
    UniformTileSpacingFlagSetBit = 0x1,
    SkipModePresentUnsetBit = 0x2,
    PrimaryRefFrameBit = 0x4,
    DeltaQBit = 0x8,
}
