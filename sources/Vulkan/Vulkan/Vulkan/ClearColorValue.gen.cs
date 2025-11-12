// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public partial struct ClearColorValue
{
    [FieldOffset(0)]
    [NativeTypeName("float[4]")]
    [SupportedApiProfile("vulkan")]
    public ClearColorValueFloat32 Float32;

    [FieldOffset(0)]
    [NativeTypeName("int32_t[4]")]
    [SupportedApiProfile("vulkan")]
    public ClearColorValueInt32 Int32;

    [FieldOffset(0)]
    [NativeTypeName("uint32_t[4]")]
    [SupportedApiProfile("vulkan")]
    public ClearColorValueUint32 Uint32;
}
