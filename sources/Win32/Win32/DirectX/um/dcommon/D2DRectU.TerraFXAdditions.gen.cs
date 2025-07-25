// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h and um/d2d1_3helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2DRectU : IEquatable<D2DRectU>
{
    public D2D_RECT_U(
        [NativeTypeName("UINT32")] uint left = 0,
        [NativeTypeName("UINT32")] uint top = 0,
        [NativeTypeName("UINT32")] uint right = 0,
        [NativeTypeName("UINT32")] uint bottom = 0
    )
    {
        this.left = left;
        this.top = top;
        this.right = right;
        this.bottom = bottom;
    }

    public static bool operator ==(
        [NativeTypeName("const D2D1_RECT_U &")] in D2DRectU l,
        [NativeTypeName("const D2D1_RECT_U &")] in D2DRectU r
    )
    {
        return (l.left == r.left)
            && (l.top == r.top)
            && (l.right == r.right)
            && (l.bottom == r.bottom);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D1_RECT_U &")] in D2DRectU l,
        [NativeTypeName("const D2D1_RECT_U &")] in D2DRectU r
    ) => !(l == r);

    public static D2DRectU Infinite
    {
        [return: NativeTypeName("D2D1_RECT_U")]
        get
        {
            D2DRectU rect = new D2DRectU
            {
                left = 0u,
                top = 0u,
                right = uint.MaxValue,
                bottom = uint.MaxValue,
            };
            return rect;
        }
    }

    public readonly bool Equals(D2DRectU other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is D2DRectU other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(left, top, right, bottom);
}
