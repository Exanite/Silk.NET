// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH265HrdParameters
{
    public StdVideoH265HrdFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte TickDivisorMinus2;

    [NativeTypeName("uint8_t")]
    public byte DuCpbRemovalDelayIncrementLengthMinus1;

    [NativeTypeName("uint8_t")]
    public byte DpbOutputDelayDuLengthMinus1;

    [NativeTypeName("uint8_t")]
    public byte BitRateScale;

    [NativeTypeName("uint8_t")]
    public byte CpbSizeScale;

    [NativeTypeName("uint8_t")]
    public byte CpbSizeDuScale;

    [NativeTypeName("uint8_t")]
    public byte InitialCpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint8_t")]
    public byte AuCpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint8_t")]
    public byte DpbOutputDelayLengthMinus1;

    [NativeTypeName("uint8_t[7]")]
    public StdVideoH265HrdParametersCpbCntMinus1 CpbCntMinus1;

    [NativeTypeName("uint16_t[7]")]
    public StdVideoH265HrdParametersElementalDurationInTcMinus1 ElementalDurationInTcMinus1;

    [NativeTypeName("uint16_t[3]")]
    public StdVideoH265HrdParametersReserved Reserved;

    [NativeTypeName("const StdVideoH265SubLayerHrdParameters *")]
    public StdVideoH265SubLayerHrdParameters* PSubLayerHrdParametersNal;

    [NativeTypeName("const StdVideoH265SubLayerHrdParameters *")]
    public StdVideoH265SubLayerHrdParameters* PSubLayerHrdParametersVcl;
}
