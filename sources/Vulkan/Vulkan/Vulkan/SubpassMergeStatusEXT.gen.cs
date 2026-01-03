// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum SubpassMergeStatusEXT : uint
{
    Merged = 0,
    Disallowed = 1,
    NotMergedSideEffects = 2,
    NotMergedSamplesMismatch = 3,
    NotMergedViewsMismatch = 4,
    NotMergedAliasing = 5,
    NotMergedDependencies = 6,
    NotMergedIncompatibleInputAttachment = 7,
    NotMergedTooManyAttachments = 8,
    NotMergedInsufficientStorage = 9,
    NotMergedDepthStencilCount = 10,
    NotMergedResolveAttachmentReuse = 11,
    NotMergedSingleSubpass = 12,
    NotMergedUnspecified = 13,
}
