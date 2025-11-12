// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeRateControlInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeRateControlFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeRateControlModeFlagsKHR RateControlMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint LayerCount;

    [NativeTypeName("const VkVideoEncodeRateControlLayerInfoKHR *")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeRateControlLayerInfoKHR* PLayers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VirtualBufferSizeInMs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint InitialVirtualBufferSizeInMs;
}
