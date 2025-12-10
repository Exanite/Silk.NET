// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum OpticalFlowGridSizeFlagsNV : uint
{
    SizeUnknown = 0x0,
    Size1X1Bit = 0x1,
    Size2X2Bit = 0x2,
    Size4X4Bit = 0x4,
    Size8X8Bit = 0x8,
}
