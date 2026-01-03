// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoAV1FilmGrain
{
    public StdVideoAV1FilmGrainFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte GrainScalingMinus8;

    [NativeTypeName("uint8_t")]
    public byte ArCoeffLag;

    [NativeTypeName("uint8_t")]
    public byte ArCoeffShiftMinus6;

    [NativeTypeName("uint8_t")]
    public byte GrainScaleShift;

    [NativeTypeName("uint16_t")]
    public ushort GrainSeed;

    [NativeTypeName("uint8_t")]
    public byte FilmGrainParamsRefIdx;

    [NativeTypeName("uint8_t")]
    public byte NumYPoints;

    [NativeTypeName("uint8_t[14]")]
    public StdVideoAV1FilmGrainPointYValue PointYValue;

    [NativeTypeName("uint8_t[14]")]
    public StdVideoAV1FilmGrainPointYScaling PointYScaling;

    [NativeTypeName("uint8_t")]
    public byte NumCbPoints;

    [NativeTypeName("uint8_t[10]")]
    public StdVideoAV1FilmGrainPointCbValue PointCbValue;

    [NativeTypeName("uint8_t[10]")]
    public StdVideoAV1FilmGrainPointCbScaling PointCbScaling;

    [NativeTypeName("uint8_t")]
    public byte NumCrPoints;

    [NativeTypeName("uint8_t[10]")]
    public StdVideoAV1FilmGrainPointCrValue PointCrValue;

    [NativeTypeName("uint8_t[10]")]
    public StdVideoAV1FilmGrainPointCrScaling PointCrScaling;

    [NativeTypeName("int8_t[24]")]
    public StdVideoAV1FilmGrainArCoeffsYPlus128 ArCoeffsYPlus128;

    [NativeTypeName("int8_t[25]")]
    public StdVideoAV1FilmGrainArCoeffsCbPlus128 ArCoeffsCbPlus128;

    [NativeTypeName("int8_t[25]")]
    public StdVideoAV1FilmGrainArCoeffsCrPlus128 ArCoeffsCrPlus128;

    [NativeTypeName("uint8_t")]
    public byte CbMult;

    [NativeTypeName("uint8_t")]
    public byte CbLumaMult;

    [NativeTypeName("uint16_t")]
    public ushort CbOffset;

    [NativeTypeName("uint8_t")]
    public byte CrMult;

    [NativeTypeName("uint8_t")]
    public byte CrLumaMult;

    [NativeTypeName("uint16_t")]
    public ushort CrOffset;
}
