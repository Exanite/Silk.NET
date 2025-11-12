// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct DrmFormatModifierProperties2EXT
{
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong DrmFormatModifier;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DrmFormatModifierPlaneCount;

    [NativeTypeName("VkFormatFeatureFlags2")]
    [SupportedApiProfile("vulkan")]
    public FormatFeatureFlags2 DrmFormatModifierTilingFeatures;
}
