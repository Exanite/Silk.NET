// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum SubpassMergeStatusEXT : uint
{
    [SupportedApiProfile("vulkan")]
    MergedEXT = 0,

    [SupportedApiProfile("vulkan")]
    DisallowedEXT = 1,

    [SupportedApiProfile("vulkan")]
    NotMergedSideEffectsEXT = 2,

    [SupportedApiProfile("vulkan")]
    NotMergedSamplesMismatchEXT = 3,

    [SupportedApiProfile("vulkan")]
    NotMergedViewsMismatchEXT = 4,

    [SupportedApiProfile("vulkan")]
    NotMergedAliasingEXT = 5,

    [SupportedApiProfile("vulkan")]
    NotMergedDependenciesEXT = 6,

    [SupportedApiProfile("vulkan")]
    NotMergedIncompatibleInputAttachmentEXT = 7,

    [SupportedApiProfile("vulkan")]
    NotMergedTooManyAttachmentsEXT = 8,

    [SupportedApiProfile("vulkan")]
    NotMergedInsufficientStorageEXT = 9,

    [SupportedApiProfile("vulkan")]
    NotMergedDepthStencilCountEXT = 10,

    [SupportedApiProfile("vulkan")]
    NotMergedResolveAttachmentReuseEXT = 11,

    [SupportedApiProfile("vulkan")]
    NotMergedSingleSubpassEXT = 12,

    [SupportedApiProfile("vulkan")]
    NotMergedUnspecifiedEXT = 13,
}
