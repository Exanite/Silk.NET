// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceTransformFeedbackPropertiesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MaxTransformFeedbackStreams;

    [NativeTypeName("uint32_t")]
    public uint MaxTransformFeedbackBuffers;

    [NativeTypeName("VkDeviceSize")]
    public ulong MaxTransformFeedbackBufferSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTransformFeedbackStreamDataSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTransformFeedbackBufferDataSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTransformFeedbackBufferDataStride;

    [NativeTypeName("VkBool32")]
    public uint TransformFeedbackQueries;

    [NativeTypeName("VkBool32")]
    public uint TransformFeedbackStreamsLinesTriangles;

    [NativeTypeName("VkBool32")]
    public uint TransformFeedbackRasterizationStreamSelect;

    [NativeTypeName("VkBool32")]
    public uint TransformFeedbackDraw;
}
