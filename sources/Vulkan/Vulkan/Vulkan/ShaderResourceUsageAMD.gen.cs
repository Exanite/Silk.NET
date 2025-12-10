// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct ShaderResourceUsageAMD
{
    [NativeTypeName("uint32_t")]
    public uint NumUsedVgprs;

    [NativeTypeName("uint32_t")]
    public uint NumUsedSgprs;

    [NativeTypeName("uint32_t")]
    public uint LdsSizePerLocalWorkGroup;

    [NativeTypeName("size_t")]
    public nuint LdsUsageSizeInBytes;

    [NativeTypeName("size_t")]
    public nuint ScratchMemUsageInBytes;
}
