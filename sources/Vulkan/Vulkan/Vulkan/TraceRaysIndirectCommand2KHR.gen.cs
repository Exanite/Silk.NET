// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct TraceRaysIndirectCommand2KHR
{
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong RaygenShaderRecordAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong RaygenShaderRecordSize;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong MissShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MissShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MissShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong HitShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong HitShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong HitShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong CallableShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong CallableShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong CallableShaderBindingTableStride;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Width;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Height;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Depth;
}
