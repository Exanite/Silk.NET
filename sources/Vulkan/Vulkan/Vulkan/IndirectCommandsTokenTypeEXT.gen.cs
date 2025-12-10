// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum IndirectCommandsTokenTypeEXT : uint
{
    ExecutionSet = 0,
    PushConstant = 1,
    SequenceIndex = 2,
    IndexBuffer = 3,
    VertexBuffer = 4,
    DrawIndexed = 5,
    Draw = 6,
    DrawIndexedCount = 7,
    DrawCount = 8,
    Dispatch = 9,
    DrawMeshTasksNv = 1000202002,
    DrawMeshTasksCountNv = 1000202003,
    DrawMeshTasks = 1000328000,
    DrawMeshTasksCount = 1000328001,
    TraceRays2 = 1000386004,
}
