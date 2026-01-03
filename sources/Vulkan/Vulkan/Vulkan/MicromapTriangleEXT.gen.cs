// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct MicromapTriangleEXT
{
    [NativeTypeName("uint32_t")]
    public uint DataOffset;

    [NativeTypeName("uint16_t")]
    public ushort SubdivisionLevel;

    [NativeTypeName("uint16_t")]
    public ushort Format;
}
