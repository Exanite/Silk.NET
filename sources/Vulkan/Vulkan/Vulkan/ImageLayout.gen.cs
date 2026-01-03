// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public enum ImageLayout : uint
{
    Undefined = 0,
    General = 1,
    ColorAttachmentOptimal = 2,
    DepthStencilAttachmentOptimal = 3,
    DepthStencilReadOnlyOptimal = 4,
    ShaderReadOnlyOptimal = 5,
    TransferSrcOptimal = 6,
    TransferDstOptimal = 7,
    Preinitialized = 8,
    DepthReadOnlyStencilAttachmentOptimal = 1000117000,
    DepthAttachmentStencilReadOnlyOptimal = 1000117001,
    DepthAttachmentOptimal = 1000241000,
    DepthReadOnlyOptimal = 1000241001,
    StencilAttachmentOptimal = 1000241002,
    StencilReadOnlyOptimal = 1000241003,
    ReadOnlyOptimal = 1000314000,
    AttachmentOptimal = 1000314001,
    RenderingLocalRead = 1000232000,
    PresentSrcKHR = 1000001002,
    VideoDecodeDstKHR = 1000024000,
    VideoDecodeSrcKHR = 1000024001,
    VideoDecodeDpbKHR = 1000024002,
    SharedPresentKHR = 1000111000,
    FragmentDensityMapOptimalEXT = 1000218000,
    FragmentShadingRateAttachmentOptimalKHR = 1000164003,
    VideoEncodeDstKHR = 1000299000,
    VideoEncodeSrcKHR = 1000299001,
    VideoEncodeDpbKHR = 1000299002,
    AttachmentFeedbackLoopOptimalEXT = 1000339000,
    TensorAliasingARM = 1000460000,
    VideoEncodeQuantizationMapKHR = 1000553000,
    ZeroInitializedEXT = 1000620000,
    DepthReadOnlyStencilAttachmentOptimalKHR = DepthReadOnlyStencilAttachmentOptimal,
    DepthAttachmentStencilReadOnlyOptimalKHR = DepthAttachmentStencilReadOnlyOptimal,
    ShadingRateOptimalNV = FragmentShadingRateAttachmentOptimalKHR,
    RenderingLocalReadKHR = RenderingLocalRead,
    DepthAttachmentOptimalKHR = DepthAttachmentOptimal,
    DepthReadOnlyOptimalKHR = DepthReadOnlyOptimal,
    StencilAttachmentOptimalKHR = StencilAttachmentOptimal,
    StencilReadOnlyOptimalKHR = StencilReadOnlyOptimal,
    ReadOnlyOptimalKHR = ReadOnlyOptimal,
    AttachmentOptimalKHR = AttachmentOptimal,
}
