// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct SemaphoreSubmitInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkSemaphore")]
    [SupportedApiProfile("vulkan")]
    public SemaphoreHandle Semaphore;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong Value;

    [NativeTypeName("VkPipelineStageFlags2")]
    [SupportedApiProfile("vulkan")]
    public PipelineStageFlags2 StageMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DeviceIndex;
}
