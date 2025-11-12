// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugMarkerObjectTagInfoEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public DebugReportObjectTypeEXT ObjectType;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong @object;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong TagName;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint TagSize;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PTag;
}
