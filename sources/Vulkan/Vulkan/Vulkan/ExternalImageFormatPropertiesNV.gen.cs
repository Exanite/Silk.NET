// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct ExternalImageFormatPropertiesNV
{
    [SupportedApiProfile("vulkan")]
    public ImageFormatProperties ImageFormatProperties;

    [NativeTypeName("VkExternalMemoryFeatureFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public ExternalMemoryFeatureFlagsNV ExternalMemoryFeatures;

    [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public ExternalMemoryHandleTypeFlagsNV ExportFromImportedHandleTypes;

    [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public ExternalMemoryHandleTypeFlagsNV CompatibleHandleTypes;
}
