// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoDecodeAV1PictureInfoFlags
{
    public uint Bitfield;

    [NativeTypeName("uint32_t : 1")]
    public uint ErrorResilientMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint DisableCdfUpdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint UseSuperres
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint RenderAndFrameSizeDifferent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 3) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint AllowScreenContentTools
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 4) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint IsFilterSwitchable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 5) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ForceIntegerMv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 6) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint FrameSizeOverrideFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 7) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint BufferRemovalTimePresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 8) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint AllowIntrabc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint FrameRefsShortSignaling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 10) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint AllowHighPrecisionMv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 11) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint IsMotionModeSwitchable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 12) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint UseRefFrameMvs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 13) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint DisableFrameEndUpdateCdf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 14) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint AllowWarpedMotion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 15) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ReducedTxSet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 16) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ReferenceSelect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 17) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SkipModePresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 18) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint DeltaQPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 19) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint DeltaLfPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 20) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint DeltaLfMulti
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 21) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SegmentationEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 22) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SegmentationUpdateMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 23) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SegmentationTemporalUpdate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 24) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 24)) | ((value & 0x1u) << 24); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SegmentationUpdateData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 25) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 25)) | ((value & 0x1u) << 25); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint UsesLr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 26) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 26)) | ((value & 0x1u) << 26); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint UsesChromaLr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 27) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 27)) | ((value & 0x1u) << 27); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ApplyGrain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 28) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 28)) | ((value & 0x1u) << 28); }
    }

    [NativeTypeName("uint32_t : 3")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 29) & 0x7u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x7u << 29)) | ((value & 0x7u) << 29); }
    }
}
