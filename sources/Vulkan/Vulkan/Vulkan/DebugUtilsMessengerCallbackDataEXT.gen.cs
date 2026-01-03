// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
    public uint Flags;

    [NativeTypeName("const char *")]
    public sbyte* PMessageIdName;

    [NativeTypeName("int32_t")]
    public int MessageIdNumber;

    [NativeTypeName("const char *")]
    public sbyte* PMessage;

    [NativeTypeName("uint32_t")]
    public uint QueueLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    public DebugUtilsLabelEXT* PQueueLabels;

    [NativeTypeName("uint32_t")]
    public uint CmdBufLabelCount;

    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
    public DebugUtilsLabelEXT* PCmdBufLabels;

    [NativeTypeName("uint32_t")]
    public uint ObjectCount;

    [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
    public DebugUtilsObjectNameInfoEXT* PObjects;
}
