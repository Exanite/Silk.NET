// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1LinearGradientBrushProperties
{
    public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F startPoint,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F endPoint
    )
    {
        this = DirectX.LinearGradientBrushProperties(startPoint, endPoint);
    }
}
