// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct DeviceFaultVendorBinaryHeaderVersionOneEXT
{
    [NativeTypeName("uint32_t")]
    public uint HeaderSize;
    public DeviceFaultVendorBinaryHeaderVersionEXT HeaderVersion;

    [NativeTypeName("uint32_t")]
    public uint VendorID;

    [NativeTypeName("uint32_t")]
    public uint DeviceID;

    [NativeTypeName("uint32_t")]
    public uint DriverVersion;

    [NativeTypeName("uint8_t[16]")]
    public DeviceFaultVendorBinaryHeaderVersionOneEXTPipelineCacheUUID PipelineCacheUUID;

    [NativeTypeName("uint32_t")]
    public uint ApplicationNameOffset;

    [NativeTypeName("uint32_t")]
    public uint ApplicationVersion;

    [NativeTypeName("uint32_t")]
    public uint EngineNameOffset;

    [NativeTypeName("uint32_t")]
    public uint EngineVersion;

    [NativeTypeName("uint32_t")]
    public uint ApiVersion;
}
