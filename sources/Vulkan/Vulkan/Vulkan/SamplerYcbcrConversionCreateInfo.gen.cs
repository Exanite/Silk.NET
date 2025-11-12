// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct SamplerYcbcrConversionCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public Format Format;

    [SupportedApiProfile("vulkan")]
    public SamplerYcbcrModelConversion YcbcrModel;

    [SupportedApiProfile("vulkan")]
    public SamplerYcbcrRange YcbcrRange;

    [SupportedApiProfile("vulkan")]
    public ComponentMapping Components;

    [SupportedApiProfile("vulkan")]
    public ChromaLocation XChromaOffset;

    [SupportedApiProfile("vulkan")]
    public ChromaLocation YChromaOffset;

    [SupportedApiProfile("vulkan")]
    public Filter ChromaFilter;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ForceExplicitReconstruction;
}
