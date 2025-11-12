// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct BindSparseInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint WaitSemaphoreCount;

    [NativeTypeName("const VkSemaphore *")]
    [SupportedApiProfile("vulkan")]
    public SemaphoreHandle* PWaitSemaphores;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint BufferBindCount;

    [NativeTypeName("const VkSparseBufferMemoryBindInfo *")]
    [SupportedApiProfile("vulkan")]
    public SparseBufferMemoryBindInfo* PBufferBinds;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ImageOpaqueBindCount;

    [NativeTypeName("const VkSparseImageOpaqueMemoryBindInfo *")]
    [SupportedApiProfile("vulkan")]
    public SparseImageOpaqueMemoryBindInfo* PImageOpaqueBinds;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ImageBindCount;

    [NativeTypeName("const VkSparseImageMemoryBindInfo *")]
    [SupportedApiProfile("vulkan")]
    public SparseImageMemoryBindInfo* PImageBinds;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SignalSemaphoreCount;

    [NativeTypeName("const VkSemaphore *")]
    [SupportedApiProfile("vulkan")]
    public SemaphoreHandle* PSignalSemaphores;
}
