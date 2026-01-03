// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct TensorFormatPropertiesARM
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkFormatFeatureFlags2")]
    public FormatFeatureFlags2 OptimalTilingTensorFeatures;

    [NativeTypeName("VkFormatFeatureFlags2")]
    public FormatFeatureFlags2 LinearTilingTensorFeatures;
}
