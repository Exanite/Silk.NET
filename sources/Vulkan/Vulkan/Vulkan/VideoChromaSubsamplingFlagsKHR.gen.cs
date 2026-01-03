// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoChromaSubsamplingFlagsKHR : uint
{
    SubsamplingInvalid = 0x0,
    SubsamplingMonochromeBit = 0x1,
    Subsampling420Bit = 0x2,
    Subsampling422Bit = 0x4,
    Subsampling444Bit = 0x8,
}
