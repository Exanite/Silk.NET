// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsMessengerCreateInfoEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDebugUtilsMessengerCreateFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [NativeTypeName("VkDebugUtilsMessageSeverityFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public DebugUtilsMessageSeverityFlagsEXT MessageSeverity;

    [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public DebugUtilsMessageTypeFlagsEXT MessageType;

    [NativeTypeName("PFN_vkDebugUtilsMessengerCallbackEXT")]
    [SupportedApiProfile("vulkan")]
    public PFNVkDebugUtilsMessengerCallbackEXT PfnUserCallback;

    [SupportedApiProfile("vulkan")]
    public void* PUserData;
}
