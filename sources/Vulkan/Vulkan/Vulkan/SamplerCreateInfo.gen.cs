// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct SamplerCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkSamplerCreateFlags")]
    public SamplerCreateFlags Flags;
    public Filter MagFilter;
    public Filter MinFilter;
    public SamplerMipmapMode MipmapMode;
    public SamplerAddressMode AddressModeU;
    public SamplerAddressMode AddressModeV;
    public SamplerAddressMode AddressModeW;
    public float MipLodBias;

    [NativeTypeName("VkBool32")]
    public uint AnisotropyEnable;
    public float MaxAnisotropy;

    [NativeTypeName("VkBool32")]
    public uint CompareEnable;
    public CompareOp CompareOp;
    public float MinLod;
    public float MaxLod;
    public BorderColor BorderColor;

    [NativeTypeName("VkBool32")]
    public uint UnnormalizedCoordinates;
}
