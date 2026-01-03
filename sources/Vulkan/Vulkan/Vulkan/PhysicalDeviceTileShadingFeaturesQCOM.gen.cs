// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceTileShadingFeaturesQCOM
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint TileShading;

    [NativeTypeName("VkBool32")]
    public uint TileShadingFragmentStage;

    [NativeTypeName("VkBool32")]
    public uint TileShadingColorAttachments;

    [NativeTypeName("VkBool32")]
    public uint TileShadingDepthAttachments;

    [NativeTypeName("VkBool32")]
    public uint TileShadingStencilAttachments;

    [NativeTypeName("VkBool32")]
    public uint TileShadingInputAttachments;

    [NativeTypeName("VkBool32")]
    public uint TileShadingSampledAttachments;

    [NativeTypeName("VkBool32")]
    public uint TileShadingPerTileDraw;

    [NativeTypeName("VkBool32")]
    public uint TileShadingPerTileDispatch;

    [NativeTypeName("VkBool32")]
    public uint TileShadingDispatchTile;

    [NativeTypeName("VkBool32")]
    public uint TileShadingApron;

    [NativeTypeName("VkBool32")]
    public uint TileShadingAnisotropicApron;

    [NativeTypeName("VkBool32")]
    public uint TileShadingAtomicOps;

    [NativeTypeName("VkBool32")]
    public uint TileShadingImageProcessing;
}
