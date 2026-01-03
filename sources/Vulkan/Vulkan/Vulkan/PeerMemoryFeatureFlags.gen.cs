// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum PeerMemoryFeatureFlags : uint
{
    None = 0x0,
    CopySrcBit = 0x1,
    CopyDstBit = 0x2,
    GenericSrcBit = 0x4,
    GenericDstBit = 0x8,
    CopySrcBitKHR = CopySrcBit,
    CopyDstBitKHR = CopyDstBit,
    GenericSrcBitKHR = GenericSrcBit,
    GenericDstBitKHR = GenericDstBit,
}
