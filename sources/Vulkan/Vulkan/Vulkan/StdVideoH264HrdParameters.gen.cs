// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoH264HrdParameters
{
    [NativeTypeName("uint8_t")]
    public byte CpbCntMinus1;

    [NativeTypeName("uint8_t")]
    public byte BitRateScale;

    [NativeTypeName("uint8_t")]
    public byte CpbSizeScale;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint32_t[32]")]
    public StdVideoH264HrdParametersBitRateValueMinus1 BitRateValueMinus1;

    [NativeTypeName("uint32_t[32]")]
    public StdVideoH264HrdParametersCpbSizeValueMinus1 CpbSizeValueMinus1;

    [NativeTypeName("uint8_t[32]")]
    public StdVideoH264HrdParametersCbrFlag CbrFlag;

    [NativeTypeName("uint32_t")]
    public uint InitialCpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint32_t")]
    public uint CpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint32_t")]
    public uint DpbOutputDelayLengthMinus1;

    [NativeTypeName("uint32_t")]
    public uint TimeOffsetLength;
}
