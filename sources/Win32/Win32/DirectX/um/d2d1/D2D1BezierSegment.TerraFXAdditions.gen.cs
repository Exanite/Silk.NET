// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1BezierSegment
{
    public D2D1_BEZIER_SEGMENT(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F point1,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F point2,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F point3
    )
    {
        this = DirectX.BezierSegment(point1, point2, point3);
    }
}
