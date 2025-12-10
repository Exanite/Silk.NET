// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct SRTDataNV
{
    public float Sx;
    public float A;
    public float B;
    public float Pvx;
    public float Sy;
    public float C;
    public float Pvy;
    public float Sz;
    public float Pvz;
    public float Qx;
    public float Qy;
    public float Qz;
    public float Qw;
    public float Tx;
    public float Ty;
    public float Tz;
}
