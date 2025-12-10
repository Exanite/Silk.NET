// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceDrmPropertiesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint HasPrimary;

    [NativeTypeName("VkBool32")]
    public uint HasRender;

    [NativeTypeName("int64_t")]
    public long PrimaryMajor;

    [NativeTypeName("int64_t")]
    public long PrimaryMinor;

    [NativeTypeName("int64_t")]
    public long RenderMajor;

    [NativeTypeName("int64_t")]
    public long RenderMinor;
}
