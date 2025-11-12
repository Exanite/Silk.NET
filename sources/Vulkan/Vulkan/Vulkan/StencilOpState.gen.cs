// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StencilOpState
{
    [SupportedApiProfile("vulkan")]
    public StencilOp FailOp;

    [SupportedApiProfile("vulkan")]
    public StencilOp PassOp;

    [SupportedApiProfile("vulkan")]
    public StencilOp DepthFailOp;

    [SupportedApiProfile("vulkan")]
    public CompareOp CompareOp;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CompareMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint WriteMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Reference;
}
