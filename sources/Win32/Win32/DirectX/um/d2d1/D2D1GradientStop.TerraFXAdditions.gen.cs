// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1GradientStop
{
    public D2D1_GRADIENT_STOP(
        float position,
        [NativeTypeName("const D2D1_COLOR_F &")] in DxgiRgba color
    )
    {
        this = DirectX.GradientStop(position, color);
    }
}
