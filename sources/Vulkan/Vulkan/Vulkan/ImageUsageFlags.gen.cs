// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ImageUsageFlags : uint
{
    None = 0x0,
    TransferSrcBit = 0x1,
    TransferDstBit = 0x2,
    SampledBit = 0x4,
    StorageBit = 0x8,
    ColorAttachmentBit = 0x10,
    DepthStencilAttachmentBit = 0x20,
    TransientAttachmentBit = 0x40,
    InputAttachmentBit = 0x80,
    HostTransferBit = 0x400000,
    VideoDecodeDstBitKHR = 0x400,
    VideoDecodeSrcBitKHR = 0x800,
    VideoDecodeDpbBitKHR = 0x1000,
    FragmentDensityMapBitEXT = 0x200,
    FragmentShadingRateAttachmentBitKHR = 0x100,
    VideoEncodeDstBitKHR = 0x2000,
    VideoEncodeSrcBitKHR = 0x4000,
    VideoEncodeDpbBitKHR = 0x8000,
    AttachmentFeedbackLoopBitEXT = 0x80000,
    InvocationMaskBitHUAWEI = 0x40000,
    SampleWeightBitQCOM = 0x100000,
    SampleBlockMatchBitQCOM = 0x200000,
    TensorAliasingBitARM = 0x800000,
    TileMemoryBitQCOM = 0x8000000,
    VideoEncodeQuantizationDeltaMapBitKHR = 0x2000000,
    VideoEncodeEmphasisMapBitKHR = 0x4000000,
    ShadingRateImageBitNV = FragmentShadingRateAttachmentBitKHR,
    HostTransferBitEXT = HostTransferBit,
}
