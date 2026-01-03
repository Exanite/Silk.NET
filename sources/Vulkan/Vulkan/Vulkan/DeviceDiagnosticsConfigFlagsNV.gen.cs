// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum DeviceDiagnosticsConfigFlagsNV : uint
{
    None = 0x0,
    EnableShaderDebugInfoBit = 0x1,
    EnableResourceTrackingBit = 0x2,
    EnableAutomaticCheckpointsBit = 0x4,
    EnableShaderErrorReportingBit = 0x8,
}
