// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct AabbPositionsKHR
{
    [SupportedApiProfile("vulkan")]
    public float MinX;

    [SupportedApiProfile("vulkan")]
    public float MinY;

    [SupportedApiProfile("vulkan")]
    public float MinZ;

    [SupportedApiProfile("vulkan")]
    public float MaxX;

    [SupportedApiProfile("vulkan")]
    public float MaxY;

    [SupportedApiProfile("vulkan")]
    public float MaxZ;
}
