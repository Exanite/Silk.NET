// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D2D1_LAYER_OPTIONS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2D1LayerParameters
{
    public static ref readonly D2D1LayerParameters DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data;
            if (Environment.Is64BitProcess)
            {
                data =
                [
                    0xFF,
                    0xFF,
                    0x7F,
                    0xFF,
                    0xFF,
                    0xFF,
                    0x7F,
                    0xFF,
                    0xFF,
                    0xFF,
                    0x7F,
                    0x7F,
                    0xFF,
                    0xFF,
                    0x7F,
                    0x7F,
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
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                ];
            }
            else
            {
                data =
                [
                    0xFF,
                    0xFF,
                    0x7F,
                    0xFF,
                    0xFF,
                    0xFF,
                    0x7F,
                    0xFF,
                    0xFF,
                    0xFF,
                    0x7F,
                    0x7F,
                    0xFF,
                    0xFF,
                    0x7F,
                    0x7F,
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
            }
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1LayerParameters>());
            return ref Unsafe.As<byte, D2D1LayerParameters>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D1_LAYER_PARAMETERS(
        [Optional] ID2D1Geometry* geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        float opacity = 1.0f,
        ID2D1Brush* opacityBrush = null,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
        : this(
            DirectX.InfiniteRect,
            geometricMask,
            maskAntialiasMode,
            DirectX.IdentityMatrix,
            opacity,
            opacityBrush,
            layerOptions
        ) { }

    public D2D1_LAYER_PARAMETERS(
        [NativeTypeName("const D2D1_RECT_F")] in D2DRectF contentBounds,
        [Optional] ID2D1Geometry* geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        float opacity = 1.0f,
        ID2D1Brush* opacityBrush = null,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
        : this(
            contentBounds,
            geometricMask,
            maskAntialiasMode,
            DirectX.IdentityMatrix,
            opacity,
            opacityBrush,
            layerOptions
        ) { }

    public D2D1_LAYER_PARAMETERS(
        [Optional] ID2D1Geometry* geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        [NativeTypeName("D2D1_MATRIX_3X2_F")] D2DMatrix3X2F maskTransform,
        float opacity = 1.0f,
        ID2D1Brush* opacityBrush = null,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
        : this(
            DirectX.InfiniteRect,
            geometricMask,
            maskAntialiasMode,
            maskTransform,
            opacity,
            opacityBrush,
            layerOptions
        ) { }

    public D2D1_LAYER_PARAMETERS(
        [NativeTypeName("const D2D1_RECT_F")] in D2DRectF contentBounds,
        [Optional] ID2D1Geometry* geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        [NativeTypeName("D2D1_MATRIX_3X2_F")] D2DMatrix3X2F maskTransform,
        float opacity = 1.0f,
        ID2D1Brush* opacityBrush = null,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
    {
        this = DirectX.LayerParameters(
            contentBounds,
            geometricMask,
            maskAntialiasMode,
            maskTransform,
            opacity,
            opacityBrush,
            layerOptions
        );
    }
}
