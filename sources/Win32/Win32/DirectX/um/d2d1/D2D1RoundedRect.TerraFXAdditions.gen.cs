// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1RoundedRect
{
    public D2D1_ROUNDED_RECT(
        [NativeTypeName("const D2D1_RECT_F")] in D2DRectF rect,
        float radiusX,
        float radiusY
    )
    {
        this = DirectX.RoundedRect(rect, radiusX, radiusY);
    }
}
