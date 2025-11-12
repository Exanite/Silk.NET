// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct SRTDataNV
{
    [SupportedApiProfile("vulkan")]
    public float Sx;

    [SupportedApiProfile("vulkan")]
    public float A;

    [SupportedApiProfile("vulkan")]
    public float B;

    [SupportedApiProfile("vulkan")]
    public float Pvx;

    [SupportedApiProfile("vulkan")]
    public float Sy;

    [SupportedApiProfile("vulkan")]
    public float C;

    [SupportedApiProfile("vulkan")]
    public float Pvy;

    [SupportedApiProfile("vulkan")]
    public float Sz;

    [SupportedApiProfile("vulkan")]
    public float Pvz;

    [SupportedApiProfile("vulkan")]
    public float Qx;

    [SupportedApiProfile("vulkan")]
    public float Qy;

    [SupportedApiProfile("vulkan")]
    public float Qz;

    [SupportedApiProfile("vulkan")]
    public float Qw;

    [SupportedApiProfile("vulkan")]
    public float Tx;

    [SupportedApiProfile("vulkan")]
    public float Ty;

    [SupportedApiProfile("vulkan")]
    public float Tz;
}
