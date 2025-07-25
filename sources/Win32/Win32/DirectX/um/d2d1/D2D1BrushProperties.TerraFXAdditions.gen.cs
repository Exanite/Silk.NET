// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1BrushProperties
{
    public static ref readonly D2D1BrushProperties DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1BrushProperties>());
            return ref Unsafe.As<byte, D2D1BrushProperties>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D1_BRUSH_PROPERTIES(float opacity = 1.0f)
        : this(opacity, DirectX.IdentityMatrix) { }

    public D2D1_BRUSH_PROPERTIES(
        [Optional, DefaultParameterValue(1.0f)] float opacity,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2DMatrix3X2F transform
    )
    {
        this = DirectX.BrushProperties(opacity, transform);
    }
}
