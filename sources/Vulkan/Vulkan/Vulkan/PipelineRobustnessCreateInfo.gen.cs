// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineRobustnessCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessBufferBehavior StorageBuffers;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessBufferBehavior UniformBuffers;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessBufferBehavior VertexInputs;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessImageBehavior Images;
}
