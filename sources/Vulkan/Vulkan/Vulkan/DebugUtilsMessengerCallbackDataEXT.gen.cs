// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan")]
    public sbyte* PMessageIdName;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int MessageIdNumber;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan")]
    public sbyte* PMessage;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan")]
    public DebugUtilsLabelEXT* PQueueLabels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CmdBufLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    [SupportedApiProfile("vulkan")]
    public DebugUtilsLabelEXT* PCmdBufLabels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ObjectCount;

    [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
    [SupportedApiProfile("vulkan")]
    public DebugUtilsObjectNameInfoEXT* PObjects;
}
