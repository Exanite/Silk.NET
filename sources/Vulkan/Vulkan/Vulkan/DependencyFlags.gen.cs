// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum DependencyFlags : uint
{
    None = 0x0,
    ByRegionBit = 0x1,
    DeviceGroupBit = 0x4,
    ViewLocalBit = 0x2,
    FeedbackLoopBitEXT = 0x8,
    QueueFamilyOwnershipTransferUseAllStagesBitKHR = 0x20,
    AsymmetricEventBitKHR = 0x40,
    ViewLocalBitKHR = ViewLocalBit,
    DeviceGroupBitKHR = DeviceGroupBit,
}
