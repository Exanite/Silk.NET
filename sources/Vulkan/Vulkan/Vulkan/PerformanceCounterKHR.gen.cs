// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PerformanceCounterKHR
{
    public StructureType SType;
    public void* PNext;
    public PerformanceCounterUnitKHR Unit;
    public PerformanceCounterScopeKHR Scope;
    public PerformanceCounterStorageKHR Storage;

    [NativeTypeName("uint8_t[16]")]
    public PerformanceCounterKHRUuid Uuid;
}
