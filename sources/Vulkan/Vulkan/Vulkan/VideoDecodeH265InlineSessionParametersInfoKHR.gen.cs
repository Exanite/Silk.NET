// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoDecodeH265InlineSessionParametersInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("const StdVideoH265VideoParameterSet *")]
    public StdVideoH265VideoParameterSet* PStdVPS;

    [NativeTypeName("const StdVideoH265SequenceParameterSet *")]
    public StdVideoH265SequenceParameterSet* PStdSPS;

    [NativeTypeName("const StdVideoH265PictureParameterSet *")]
    public StdVideoH265PictureParameterSet* PStdPPS;
}
