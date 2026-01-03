// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct LayerSettingEXT
{
    [NativeTypeName("const char *")]
    public sbyte* PLayerName;

    [NativeTypeName("const char *")]
    public sbyte* PSettingName;
    public LayerSettingTypeEXT Type;

    [NativeTypeName("uint32_t")]
    public uint ValueCount;

    [NativeTypeName("const void *")]
    public void* PValues;
}
