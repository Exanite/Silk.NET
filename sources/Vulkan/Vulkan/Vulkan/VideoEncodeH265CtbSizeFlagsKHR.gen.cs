// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeH265CtbSizeFlagsKHR : uint
{
    None = 0x0,
    Size16Bit = 0x1,
    Size32Bit = 0x2,
    Size64Bit = 0x4,
}
