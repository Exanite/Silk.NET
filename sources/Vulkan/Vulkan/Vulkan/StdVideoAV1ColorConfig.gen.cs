// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoAV1ColorConfig
{
    public StdVideoAV1ColorConfigFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte BitDepth;

    [NativeTypeName("uint8_t")]
    public byte SubsamplingX;

    [NativeTypeName("uint8_t")]
    public byte SubsamplingY;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;
    public StdVideoAV1ColorPrimaries ColorPrimaries;
    public StdVideoAV1TransferCharacteristics TransferCharacteristics;
    public StdVideoAV1MatrixCoefficients MatrixCoefficients;
    public StdVideoAV1ChromaSamplePosition ChromaSamplePosition;
}
