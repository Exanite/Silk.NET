// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CooperativeVectorPropertiesNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR InputType;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR InputInterpretation;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR MatrixInterpretation;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR BiasInterpretation;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR ResultType;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> Transpose;
}
