// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct DescriptorUpdateTemplateEntry
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DstBinding;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DstArrayElement;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DescriptorCount;

    [SupportedApiProfile("vulkan")]
    public DescriptorType DescriptorType;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint Offset;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint Stride;
}
