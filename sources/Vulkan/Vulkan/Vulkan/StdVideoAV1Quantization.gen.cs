// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoAV1Quantization
{
    public StdVideoAV1QuantizationFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte BaseQIdx;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQYDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQUDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQUAc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQVDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQVAc;

    [NativeTypeName("uint8_t")]
    public byte QmY;

    [NativeTypeName("uint8_t")]
    public byte QmU;

    [NativeTypeName("uint8_t")]
    public byte QmV;
}
