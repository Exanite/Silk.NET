// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoEncodeH265LongTermRefPics
{
    [NativeTypeName("uint8_t")]
    public byte NumLongTermSps;

    [NativeTypeName("uint8_t")]
    public byte NumLongTermPics;

    [NativeTypeName("uint8_t[32]")]
    public StdVideoEncodeH265LongTermRefPicsLtIdxSps LtIdxSps;

    [NativeTypeName("uint8_t[16]")]
    public StdVideoEncodeH265LongTermRefPicsPocLsbLt PocLsbLt;

    [NativeTypeName("uint16_t")]
    public ushort UsedByCurrPicLtFlag;

    [NativeTypeName("uint8_t[48]")]
    public StdVideoEncodeH265LongTermRefPicsDeltaPocMsbPresentFlag DeltaPocMsbPresentFlag;

    [NativeTypeName("uint8_t[48]")]
    public StdVideoEncodeH265LongTermRefPicsDeltaPocMsbCycleLt DeltaPocMsbCycleLt;
}
