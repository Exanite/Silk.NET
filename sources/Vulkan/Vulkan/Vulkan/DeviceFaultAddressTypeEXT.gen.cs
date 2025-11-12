// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum DeviceFaultAddressTypeEXT : uint
{
    [SupportedApiProfile("vulkan")]
    NoneEXT = 0,

    [SupportedApiProfile("vulkan")]
    ReadInvalidEXT = 1,

    [SupportedApiProfile("vulkan")]
    WriteInvalidEXT = 2,

    [SupportedApiProfile("vulkan")]
    ExecuteInvalidEXT = 3,

    [SupportedApiProfile("vulkan")]
    InstructionPointerUnknownEXT = 4,

    [SupportedApiProfile("vulkan")]
    InstructionPointerInvalidEXT = 5,

    [SupportedApiProfile("vulkan")]
    InstructionPointerFaultEXT = 6,
}
