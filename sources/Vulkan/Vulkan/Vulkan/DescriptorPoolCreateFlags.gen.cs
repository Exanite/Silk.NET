// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum DescriptorPoolCreateFlags : uint
{
    None = 0x0,
    FreeDescriptorSetBit = 0x1,
    UpdateAfterBindBit = 0x2,
    HostOnlyBitEXT = 0x4,
    AllowOverallocationSetsBitNV = 0x8,
    AllowOverallocationPoolsBitNV = 0x10,
    UpdateAfterBindBitEXT = UpdateAfterBindBit,
    HostOnlyBitVALVE = HostOnlyBitEXT,
}
