// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceShaderIntegerDotProductProperties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct8BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct8BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct8BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct4X8BitPackedUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct4X8BitPackedSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct4X8BitPackedMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct16BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct16BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct16BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct32BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct32BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct32BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct64BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct64BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProduct64BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;

    [NativeTypeName("VkBool32")]
    public uint IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
}
