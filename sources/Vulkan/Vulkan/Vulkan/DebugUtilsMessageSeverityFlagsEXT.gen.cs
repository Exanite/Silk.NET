// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum DebugUtilsMessageSeverityFlagsEXT : uint
{
    None = 0x0,
    VerboseBit = 0x1,
    InfoBit = 0x10,
    WarningBit = 0x100,
    ErrorBit = 0x1000,
}
