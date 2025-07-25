// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1GradientMeshPatch
{
    public D2D1_GRADIENT_MESH_PATCH(
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point00,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point01,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point02,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point03,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point10,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point11,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point12,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point13,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point20,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point21,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point22,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point23,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point30,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point31,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point32,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point33,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color00,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color03,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color30,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color33,
        D2D1_PATCH_EDGE_MODE topEdgeMode,
        D2D1_PATCH_EDGE_MODE leftEdgeMode,
        D2D1_PATCH_EDGE_MODE bottomEdgeMode,
        D2D1_PATCH_EDGE_MODE rightEdgeMode
    )
    {
        this = DirectX.GradientMeshPatch(
            point00,
            point01,
            point02,
            point03,
            point10,
            point11,
            point12,
            point13,
            point20,
            point21,
            point22,
            point23,
            point30,
            point31,
            point32,
            point33,
            color00,
            color03,
            color30,
            color33,
            topEdgeMode,
            leftEdgeMode,
            bottomEdgeMode,
            rightEdgeMode
        );
    }

    public static D2D1GradientMeshPatch FromCoonsPatch(
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point0,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point1,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point2,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point3,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point4,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point5,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point6,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point7,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point8,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point9,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point10,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point11,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color0,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color1,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color2,
        [NativeTypeName("D2D1_COLOR_F")] DxgiRgba color3,
        D2D1_PATCH_EDGE_MODE topEdgeMode,
        D2D1_PATCH_EDGE_MODE leftEdgeMode,
        D2D1_PATCH_EDGE_MODE bottomEdgeMode,
        D2D1_PATCH_EDGE_MODE rightEdgeMode
    )
    {
        return DirectX.GradientMeshPatchFromCoonsPatch(
            point0,
            point1,
            point2,
            point3,
            point4,
            point5,
            point6,
            point7,
            point8,
            point9,
            point10,
            point11,
            color0,
            color1,
            color2,
            color3,
            topEdgeMode,
            leftEdgeMode,
            bottomEdgeMode,
            rightEdgeMode
        );
    }
}
