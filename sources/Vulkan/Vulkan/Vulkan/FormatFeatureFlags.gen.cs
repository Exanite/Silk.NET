// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum FormatFeatureFlags : uint
{
    None = 0x0,
    SampledImageBit = 0x1,
    StorageImageBit = 0x2,
    StorageImageAtomicBit = 0x4,
    UniformTexelBufferBit = 0x8,
    StorageTexelBufferBit = 0x10,
    StorageTexelBufferAtomicBit = 0x20,
    VertexBufferBit = 0x40,
    ColorAttachmentBit = 0x80,
    ColorAttachmentBlendBit = 0x100,
    DepthStencilAttachmentBit = 0x200,
    BlitSrcBit = 0x400,
    BlitDstBit = 0x800,
    SampledImageFilterLinearBit = 0x1000,
    TransferSrcBit = 0x4000,
    TransferDstBit = 0x8000,
    MidpointChromaSamplesBit = 0x20000,
    SampledImageYcbcrConversionLinearFilterBit = 0x40000,
    SampledImageYcbcrConversionSeparateReconstructionFilterBit = 0x80000,
    SampledImageYcbcrConversionChromaReconstructionExplicitBit = 0x100000,
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit = 0x200000,
    DisjointBit = 0x400000,
    CositedChromaSamplesBit = 0x800000,
    SampledImageFilterMinmaxBit = 0x10000,
    VideoDecodeOutputBitKHR = 0x2000000,
    VideoDecodeDpbBitKHR = 0x4000000,
    AccelerationStructureVertexBufferBitKHR = 0x20000000,
    SampledImageFilterCubicBitEXT = 0x2000,
    FragmentDensityMapBitEXT = 0x1000000,
    FragmentShadingRateAttachmentBitKHR = 0x40000000,
    VideoEncodeInputBitKHR = 0x8000000,
    VideoEncodeDpbBitKHR = 0x10000000,
    SampledImageFilterCubicBitIMG = SampledImageFilterCubicBitEXT,
    TransferSrcBitKHR = TransferSrcBit,
    TransferDstBitKHR = TransferDstBit,
    SampledImageFilterMinmaxBitEXT = SampledImageFilterMinmaxBit,
    MidpointChromaSamplesBitKHR = MidpointChromaSamplesBit,
    SampledImageYcbcrConversionLinearFilterBitKHR = SampledImageYcbcrConversionLinearFilterBit,
    SampledImageYcbcrConversionSeparateReconstructionFilterBitKHR =
        SampledImageYcbcrConversionSeparateReconstructionFilterBit,
    SampledImageYcbcrConversionChromaReconstructionExplicitBitKHR =
        SampledImageYcbcrConversionChromaReconstructionExplicitBit,
    SampledImageYcbcrConversionChromaReconstructionExplicitForceableBitKHR =
        SampledImageYcbcrConversionChromaReconstructionExplicitForceableBit,
    DisjointBitKHR = DisjointBit,
    CositedChromaSamplesBitKHR = CositedChromaSamplesBit,
}
