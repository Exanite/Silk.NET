// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoAV1TileInfo
{
    public StdVideoAV1TileInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte TileCols;

    [NativeTypeName("uint8_t")]
    public byte TileRows;

    [NativeTypeName("uint16_t")]
    public ushort ContextUpdateTileId;

    [NativeTypeName("uint8_t")]
    public byte TileSizeBytesMinus1;

    [NativeTypeName("uint8_t[7]")]
    public StdVideoAV1TileInfoReserved1 Reserved1;

    [NativeTypeName("const uint16_t *")]
    public ushort* PMiColStarts;

    [NativeTypeName("const uint16_t *")]
    public ushort* PMiRowStarts;

    [NativeTypeName("const uint16_t *")]
    public ushort* PWidthInSbsMinus1;

    [NativeTypeName("const uint16_t *")]
    public ushort* PHeightInSbsMinus1;
}
