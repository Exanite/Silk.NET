// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1InkStyleProperties
{
    public D2D1_INK_STYLE_PROPERTIES(
        D2D1_INK_NIB_SHAPE nibShape,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2DMatrix3X2F nibTransform
    )
    {
        this = DirectX.InkStyleProperties(nibShape, nibTransform);
    }
}
