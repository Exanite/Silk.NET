// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum IndexType : uint
{
    Uint16 = 0,
    Uint32 = 1,
    Uint8 = 1000265000,
    NoneKHR = 1000165000,
    NoneNV = NoneKHR,
    Uint8EXT = Uint8,
    Uint8KHR = Uint8,
}
