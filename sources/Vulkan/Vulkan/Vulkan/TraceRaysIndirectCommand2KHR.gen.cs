// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct TraceRaysIndirectCommand2KHR
{
    [NativeTypeName("VkDeviceAddress")]
    public ulong RaygenShaderRecordAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong RaygenShaderRecordSize;

    [NativeTypeName("VkDeviceAddress")]
    public ulong MissShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong MissShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong MissShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    public ulong HitShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong HitShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong HitShaderBindingTableStride;

    [NativeTypeName("VkDeviceAddress")]
    public ulong CallableShaderBindingTableAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong CallableShaderBindingTableSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong CallableShaderBindingTableStride;

    [NativeTypeName("uint32_t")]
    public uint Width;

    [NativeTypeName("uint32_t")]
    public uint Height;

    [NativeTypeName("uint32_t")]
    public uint Depth;
}
