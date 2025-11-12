// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxGraphicsShaderGroupCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIndirectSequenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIndirectCommandsTokenCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIndirectCommandsStreamCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIndirectCommandsTokenOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxIndirectCommandsStreamStride;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinSequencesCountBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinSequencesIndexBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinIndirectCommandsBufferOffsetAlignment;
}
