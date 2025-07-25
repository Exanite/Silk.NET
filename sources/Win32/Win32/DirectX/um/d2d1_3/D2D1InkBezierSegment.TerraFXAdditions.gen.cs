// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1InkBezierSegment
{
    public D2D1_INK_BEZIER_SEGMENT(
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1InkPoint point1,
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1InkPoint point2,
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1InkPoint point3
    )
    {
        this = DirectX.InkBezierSegment(point1, point2, point3);
    }
}
