// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum QueryType : uint
{
    Occlusion = 0,
    PipelineStatistics = 1,
    Timestamp = 2,
    ResultStatusOnlyKHR = 1000023000,
    TransformFeedbackStreamEXT = 1000028004,
    PerformanceQueryKHR = 1000116000,
    AccelerationStructureCompactedSizeKHR = 1000150000,
    AccelerationStructureSerializationSizeKHR = 1000150001,
    AccelerationStructureCompactedSizeNV = 1000165000,
    PerformanceQueryINTEL = 1000210000,
    VideoEncodeFeedbackKHR = 1000299000,
    MeshPrimitivesGeneratedEXT = 1000328000,
    PrimitivesGeneratedEXT = 1000382000,
    AccelerationStructureSerializationBottomLevelPointersKHR = 1000386000,
    AccelerationStructureSizeKHR = 1000386001,
    MicromapSerializationSizeEXT = 1000396000,
    MicromapCompactedSizeEXT = 1000396001,
}
