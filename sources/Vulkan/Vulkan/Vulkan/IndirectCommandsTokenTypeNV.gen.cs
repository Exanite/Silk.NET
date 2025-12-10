// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum IndirectCommandsTokenTypeNV : uint
{
    ShaderGroup = 0,
    StateFlags = 1,
    IndexBuffer = 2,
    VertexBuffer = 3,
    PushConstant = 4,
    DrawIndexed = 5,
    Draw = 6,
    DrawTasks = 7,
    DrawMeshTasks = 1000328000,
    Pipeline = 1000428003,
    Dispatch = 1000428004,
}
