// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum QueueFlags : uint
{
    None = 0x0,
    GraphicsBit = 0x1,
    ComputeBit = 0x2,
    TransferBit = 0x4,
    SparseBindingBit = 0x8,
    ProtectedBit = 0x10,
    VideoDecodeBitKHR = 0x20,
    VideoEncodeBitKHR = 0x40,
    OpticalFlowBitNV = 0x100,
    DataGraphBitARM = 0x400,
}
