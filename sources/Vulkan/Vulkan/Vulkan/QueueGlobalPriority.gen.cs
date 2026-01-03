// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum QueueGlobalPriority : uint
{
    Low = 128,
    Medium = 256,
    High = 512,
    Realtime = 1024,
    LowEXT = Low,
    MediumEXT = Medium,
    HighEXT = High,
    RealtimeEXT = Realtime,
    LowKHR = Low,
    MediumKHR = Medium,
    HighKHR = High,
    RealtimeKHR = Realtime,
}
