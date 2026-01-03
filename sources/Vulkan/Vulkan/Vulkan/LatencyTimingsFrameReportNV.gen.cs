// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct LatencyTimingsFrameReportNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("uint64_t")]
    public ulong PresentID;

    [NativeTypeName("uint64_t")]
    public ulong InputSampleTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong SimStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong SimEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong RenderSubmitStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong RenderSubmitEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong PresentStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong PresentEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong DriverStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong DriverEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong OsRenderQueueStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong OsRenderQueueEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong GpuRenderStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong GpuRenderEndTimeUs;
}
