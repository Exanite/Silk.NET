// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct AllocationCallbacks
{
    public void* PUserData;

    [NativeTypeName("PFN_vkAllocationFunction")]
    public AllocationFunction PfnAllocation;

    [NativeTypeName("PFN_vkReallocationFunction")]
    public ReallocationFunction PfnReallocation;

    [NativeTypeName("PFN_vkFreeFunction")]
    public FreeFunction PfnFree;

    [NativeTypeName("PFN_vkInternalAllocationNotification")]
    public InternalAllocationNotification PfnInternalAllocation;

    [NativeTypeName("PFN_vkInternalFreeNotification")]
    public InternalFreeNotification PfnInternalFree;
}
