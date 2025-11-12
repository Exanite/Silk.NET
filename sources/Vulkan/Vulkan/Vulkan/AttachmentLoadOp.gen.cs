// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum AttachmentLoadOp : uint
{
    [SupportedApiProfile("vulkan")]
    Load = 0,

    [SupportedApiProfile("vulkan")]
    Clear = 1,

    [SupportedApiProfile("vulkan")]
    DontCare = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    None = 1000400000,

    [SupportedApiProfile("vulkan", ["VK_EXT_load_store_op_none"])]
    NoneEXT = None,

    [SupportedApiProfile("vulkan", ["VK_KHR_load_store_op_none"])]
    NoneKHR = None,
}
