// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1ArcSegment
{
    public D2D1_ARC_SEGMENT(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F point,
        [NativeTypeName("const D2D1_SIZE_F &")] in D2DSizeF size,
        float rotationAngle,
        D2D1_SWEEP_DIRECTION sweepDirection,
        D2D1_ARC_SIZE arcSize
    )
    {
        this = DirectX.ArcSegment(point, size, rotationAngle, sweepDirection, arcSize);
    }
}
