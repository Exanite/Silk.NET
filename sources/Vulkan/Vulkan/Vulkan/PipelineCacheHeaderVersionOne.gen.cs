// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct PipelineCacheHeaderVersionOne
{
    [NativeTypeName("uint32_t")]
    public uint HeaderSize;
    public PipelineCacheHeaderVersion HeaderVersion;

    [NativeTypeName("uint32_t")]
    public uint VendorID;

    [NativeTypeName("uint32_t")]
    public uint DeviceID;

    [NativeTypeName("uint8_t[16]")]
    public PipelineCacheHeaderVersionOnePipelineCacheUUID PipelineCacheUUID;
}
