// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum AccessFlags : uint
{
    IndirectCommandReadBit = 0x1,
    IndexReadBit = 0x2,
    VertexAttributeReadBit = 0x4,
    UniformReadBit = 0x8,
    InputAttachmentReadBit = 0x10,
    ShaderReadBit = 0x20,
    ShaderWriteBit = 0x40,
    ColorAttachmentReadBit = 0x80,
    ColorAttachmentWriteBit = 0x100,
    DepthStencilAttachmentReadBit = 0x200,
    DepthStencilAttachmentWriteBit = 0x400,
    TransferReadBit = 0x800,
    TransferWriteBit = 0x1000,
    HostReadBit = 0x2000,
    HostWriteBit = 0x4000,
    MemoryReadBit = 0x8000,
    MemoryWriteBit = 0x10000,
    None = 0x0,
    TransformFeedbackWriteBitEXT = 0x2000000,
    TransformFeedbackCounterReadBitEXT = 0x4000000,
    TransformFeedbackCounterWriteBitEXT = 0x8000000,
    ConditionalRenderingReadBitEXT = 0x100000,
    ColorAttachmentReadNoncoherentBitEXT = 0x80000,
    AccelerationStructureReadBitKHR = 0x200000,
    AccelerationStructureWriteBitKHR = 0x400000,
    FragmentDensityMapReadBitEXT = 0x1000000,
    FragmentShadingRateAttachmentReadBitKHR = 0x800000,
    CommandPreprocessReadBitEXT = 0x20000,
    CommandPreprocessWriteBitEXT = 0x40000,
    ShadingRateImageReadBitNV = FragmentShadingRateAttachmentReadBitKHR,
    AccelerationStructureReadBitNV = AccelerationStructureReadBitKHR,
    AccelerationStructureWriteBitNV = AccelerationStructureWriteBitKHR,
    CommandPreprocessReadBitNV = CommandPreprocessReadBitEXT,
    CommandPreprocessWriteBitNV = CommandPreprocessWriteBitEXT,
    NoneKHR = None,
}
