// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoH264SpsFlags
{
    public uint Bitfield;

    [NativeTypeName("uint32_t : 1")]
    public uint ConstraintSet0Flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1u) | (value & 0x1u); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ConstraintSet1Flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 1) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ConstraintSet2Flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 2) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ConstraintSet3Flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 3) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ConstraintSet4Flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 4) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint ConstraintSet5Flag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 5) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint Direct8X8InferenceFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 6) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint MbAdaptiveFrameFieldFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 7) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint FrameMbsOnlyFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 8) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint DeltaPicOrderAlwaysZeroFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SeparateColourPlaneFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 10) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint GapsInFrameNumValueAllowedFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 11) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint QpprimeYZeroTransformBypassFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 12) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint FrameCroppingFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 13) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint SeqScalingMatrixPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 14) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14); }
    }

    [NativeTypeName("uint32_t : 1")]
    public uint VuiParametersPresentFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 15) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15); }
    }
}
