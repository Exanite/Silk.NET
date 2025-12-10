// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum QueryResultFlags : uint
{
    None = 0x0,
    Result64Bit = 0x1,
    ResultWaitBit = 0x2,
    ResultWithAvailabilityBit = 0x4,
    ResultPartialBit = 0x8,
    ResultWithStatusBitKHR = 0x10,
}
