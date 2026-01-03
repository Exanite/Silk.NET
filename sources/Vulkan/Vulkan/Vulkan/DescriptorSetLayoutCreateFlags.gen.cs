// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum DescriptorSetLayoutCreateFlags : uint
{
    None = 0x0,
    UpdateAfterBindPoolBit = 0x2,
    PushDescriptorBit = 0x1,
    DescriptorBufferBitEXT = 0x10,
    EmbeddedImmutableSamplersBitEXT = 0x20,
    IndirectBindableBitNV = 0x80,
    HostOnlyPoolBitEXT = 0x4,
    PerStageBitNV = 0x40,
    PushDescriptorBitKHR = PushDescriptorBit,
    UpdateAfterBindPoolBitEXT = UpdateAfterBindPoolBit,
    HostOnlyPoolBitVALVE = HostOnlyPoolBitEXT,
}
