// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum BufferUsageFlags : uint
{
    None = 0x0,
    TransferSrcBit = 0x1,
    TransferDstBit = 0x2,
    UniformTexelBufferBit = 0x4,
    StorageTexelBufferBit = 0x8,
    UniformBufferBit = 0x10,
    StorageBufferBit = 0x20,
    IndexBufferBit = 0x40,
    VertexBufferBit = 0x80,
    IndirectBufferBit = 0x100,
    ShaderDeviceAddressBit = 0x20000,
    VideoDecodeSrcBitKHR = 0x2000,
    VideoDecodeDstBitKHR = 0x4000,
    TransformFeedbackBufferBitEXT = 0x800,
    TransformFeedbackCounterBufferBitEXT = 0x1000,
    ConditionalRenderingBitEXT = 0x200,
    AccelerationStructureBuildInputReadOnlyBitKHR = 0x80000,
    AccelerationStructureStorageBitKHR = 0x100000,
    ShaderBindingTableBitKHR = 0x400,
    VideoEncodeDstBitKHR = 0x8000,
    VideoEncodeSrcBitKHR = 0x10000,
    SamplerDescriptorBufferBitEXT = 0x200000,
    ResourceDescriptorBufferBitEXT = 0x400000,
    PushDescriptorsDescriptorBufferBitEXT = 0x4000000,
    MicromapBuildInputReadOnlyBitEXT = 0x800000,
    MicromapStorageBitEXT = 0x1000000,
    TileMemoryBitQCOM = 0x8000000,
    RayTracingBitNV = ShaderBindingTableBitKHR,
    ShaderDeviceAddressBitEXT = ShaderDeviceAddressBit,
    ShaderDeviceAddressBitKHR = ShaderDeviceAddressBit,
}
