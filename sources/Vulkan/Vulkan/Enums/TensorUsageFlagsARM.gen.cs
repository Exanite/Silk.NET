// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Transformed]
[Flags]
public enum TensorUsageFlagsARM : ulong
{
    None = 0x0,
    ShaderBit = 0x2,
    TransferSrcBit = 0x4,
    TransferDstBit = 0x8,
    ImageAliasingBit = 0x10,
    DataGraphBit = 0x20,
}
