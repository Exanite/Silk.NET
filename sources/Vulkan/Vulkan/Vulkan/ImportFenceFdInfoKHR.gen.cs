// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportFenceFdInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkFence")]
    [SupportedApiProfile("vulkan")]
    public FenceHandle Fence;

    [NativeTypeName("VkFenceImportFlags")]
    [SupportedApiProfile("vulkan")]
    public FenceImportFlags Flags;

    [SupportedApiProfile("vulkan")]
    public ExternalFenceHandleTypeFlags HandleType;

    [SupportedApiProfile("vulkan")]
    public int Fd;
}
