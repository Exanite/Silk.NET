// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum CommandPoolCreateFlags : uint
{
    None = 0x0,
    TransientBit = 0x1,
    ResetCommandBufferBit = 0x2,
    ProtectedBit = 0x4,
}
