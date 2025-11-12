// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AllocationCallbacks
{
    [SupportedApiProfile("vulkan")]
    public void* PUserData;

    [NativeTypeName("PFN_vkAllocationFunction")]
    [SupportedApiProfile("vulkan")]
    public PFNVkAllocationFunction PfnAllocation;

    [NativeTypeName("PFN_vkReallocationFunction")]
    [SupportedApiProfile("vulkan")]
    public PFNVkReallocationFunction PfnReallocation;

    [NativeTypeName("PFN_vkFreeFunction")]
    [SupportedApiProfile("vulkan")]
    public PFNVkFreeFunction PfnFree;

    [NativeTypeName("PFN_vkInternalAllocationNotification")]
    [SupportedApiProfile("vulkan")]
    public PFNVkInternalAllocationNotification PfnInternalAllocation;

    [NativeTypeName("PFN_vkInternalFreeNotification")]
    [SupportedApiProfile("vulkan")]
    public PFNVkInternalFreeNotification PfnInternalFree;
}
