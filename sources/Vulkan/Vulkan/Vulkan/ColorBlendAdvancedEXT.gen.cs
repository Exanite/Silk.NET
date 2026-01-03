// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct ColorBlendAdvancedEXT
{
    public BlendOp AdvancedBlendOp;

    [NativeTypeName("VkBool32")]
    public uint SrcPremultiplied;

    [NativeTypeName("VkBool32")]
    public uint DstPremultiplied;
    public BlendOverlapEXT BlendOverlap;

    [NativeTypeName("VkBool32")]
    public uint ClampResults;
}
