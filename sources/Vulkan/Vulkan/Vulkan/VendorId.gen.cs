// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VendorId : uint
{
    [SupportedApiProfile("vulkan")]
    VendorIdKhronos = 0x10000,

    [SupportedApiProfile("vulkan")]
    VendorIdVIV = 0x10001,

    [SupportedApiProfile("vulkan")]
    VendorIdVSI = 0x10002,

    [SupportedApiProfile("vulkan")]
    VendorIdKazan = 0x10003,

    [SupportedApiProfile("vulkan")]
    VendorIdCodeplay = 0x10004,

    [SupportedApiProfile("vulkan")]
    VendorIdMESA = 0x10005,

    [SupportedApiProfile("vulkan")]
    VendorIdPocl = 0x10006,

    [SupportedApiProfile("vulkan")]
    VendorIdMobileye = 0x10007,
}
