// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceGroupPropertiesPhysicalDevices
{
    public PhysicalDeviceHandle E0;
    public PhysicalDeviceHandle E1;
    public PhysicalDeviceHandle E2;
    public PhysicalDeviceHandle E3;
    public PhysicalDeviceHandle E4;
    public PhysicalDeviceHandle E5;
    public PhysicalDeviceHandle E6;
    public PhysicalDeviceHandle E7;
    public PhysicalDeviceHandle E8;
    public PhysicalDeviceHandle E9;
    public PhysicalDeviceHandle E10;
    public PhysicalDeviceHandle E11;
    public PhysicalDeviceHandle E12;
    public PhysicalDeviceHandle E13;
    public PhysicalDeviceHandle E14;
    public PhysicalDeviceHandle E15;
    public PhysicalDeviceHandle E16;
    public PhysicalDeviceHandle E17;
    public PhysicalDeviceHandle E18;
    public PhysicalDeviceHandle E19;
    public PhysicalDeviceHandle E20;
    public PhysicalDeviceHandle E21;
    public PhysicalDeviceHandle E22;
    public PhysicalDeviceHandle E23;
    public PhysicalDeviceHandle E24;
    public PhysicalDeviceHandle E25;
    public PhysicalDeviceHandle E26;
    public PhysicalDeviceHandle E27;
    public PhysicalDeviceHandle E28;
    public PhysicalDeviceHandle E29;
    public PhysicalDeviceHandle E30;
    public PhysicalDeviceHandle E31;
    public ref PhysicalDeviceHandle this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (PhysicalDeviceHandle* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
