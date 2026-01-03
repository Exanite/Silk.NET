// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum DescriptorBindingFlags : uint
{
    None = 0x0,
    UpdateAfterBindBit = 0x1,
    UpdateUnusedWhilePendingBit = 0x2,
    PartiallyBoundBit = 0x4,
    VariableDescriptorCountBit = 0x8,
    UpdateAfterBindBitEXT = UpdateAfterBindBit,
    UpdateUnusedWhilePendingBitEXT = UpdateUnusedWhilePendingBit,
    PartiallyBoundBitEXT = PartiallyBoundBit,
    VariableDescriptorCountBitEXT = VariableDescriptorCountBit,
}
