// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum SampleCountFlags : uint
{
    None = 0x0,
    Count1Bit = 0x1,
    Count2Bit = 0x2,
    Count4Bit = 0x4,
    Count8Bit = 0x8,
    Count16Bit = 0x10,
    Count32Bit = 0x20,
    Count64Bit = 0x40,
}
