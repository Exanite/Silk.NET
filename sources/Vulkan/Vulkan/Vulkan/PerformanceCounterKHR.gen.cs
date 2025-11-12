// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PerformanceCounterKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public PerformanceCounterUnitKHR Unit;

    [SupportedApiProfile("vulkan")]
    public PerformanceCounterScopeKHR Scope;

    [SupportedApiProfile("vulkan")]
    public PerformanceCounterStorageKHR Storage;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public PerformanceCounterKHRUuid Uuid;
}
