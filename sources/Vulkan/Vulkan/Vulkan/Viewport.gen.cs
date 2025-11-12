// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct Viewport
{
    [SupportedApiProfile("vulkan")]
    public float X;

    [SupportedApiProfile("vulkan")]
    public float Y;

    [SupportedApiProfile("vulkan")]
    public float Width;

    [SupportedApiProfile("vulkan")]
    public float Height;

    [SupportedApiProfile("vulkan")]
    public float MinDepth;

    [SupportedApiProfile("vulkan")]
    public float MaxDepth;
}
