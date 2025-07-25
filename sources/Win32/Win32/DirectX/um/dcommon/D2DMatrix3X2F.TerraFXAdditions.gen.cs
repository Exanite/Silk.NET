// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2DMatrix3X2F : IEquatable<D2DMatrix3X2F>
{
    public D2D_MATRIX_3X2_F(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        Unsafe.SkipInit(out this);
        this.m11 = m11;
        this.m12 = m12;
        this.m21 = m21;
        this.m22 = m22;
        this.dx = dx;
        this.dy = dy;
    }

    public static ref readonly D2DMatrix3X2F Identity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
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
            Debug.Assert(data.Length == Unsafe.SizeOf<D2DMatrix3X2F>());
            return ref Unsafe.As<byte, D2DMatrix3X2F>(ref MemoryMarshal.GetReference(data));
        }
    }
    public readonly float Determinant =>
        (Anonymous.Anonymous1.m11 * Anonymous.Anonymous1.m22)
        - (Anonymous.Anonymous1.m12 * Anonymous.Anonymous1.m21);
    public readonly bool IsInvertible
    {
        get
        {
            fixed (D2DMatrix3X2F* matrix = &this)
            {
                return D2D1IsMatrixInvertible(matrix) != 0;
            }
        }
    }
    public readonly bool IsIdentity
    {
        get
        {
            return (Anonymous.Anonymous1.m11 == 1.0f)
                && (Anonymous.Anonymous1.m12 == 0.0f)
                && (Anonymous.Anonymous1.m21 == 0.0f)
                && (Anonymous.Anonymous1.m22 == 1.0f)
                && (Anonymous.Anonymous1.dx == 0.0f)
                && (Anonymous.Anonymous1.dy == 0.0f);
        }
    }

    public static D2DMatrix3X2F operator *(
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2DMatrix3X2F a,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2DMatrix3X2F b
    )
    {
        D2DMatrix3X2F result = default;
        result.SetProduct(a, b);
        return result;
    }

    public static D2DPoint2F operator *(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2DPoint2F point,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2DMatrix3X2F matrix
    ) => matrix.TransformPoint(point);

    public static bool operator ==(D2DMatrix3X2F l, D2DMatrix3X2F r)
    {
        return (l.m11 == r.m11)
            && (l.m12 == r.m12)
            && (l.m21 == r.m21)
            && (l.m22 == r.m22)
            && (l.dx == r.dx)
            && (l.dy == r.dy);
    }

    public static bool operator !=(D2DMatrix3X2F l, D2DMatrix3X2F r) => !(l == r);

    public readonly bool Equals(D2DMatrix3X2F other) => this == other;

    public override readonly bool Equals(object? obj) =>
        (obj is D2DMatrix3X2F other) && this == other;

    public override int GetHashCode() => HashCode.Combine(m11, m12, m21, m22, dx, dy);

    public bool Invert()
    {
        fixed (D2DMatrix3X2F* matrix = &this)
        {
            return D2D1InvertMatrix(matrix) != 0;
        }
    }

    public static D2DMatrix3X2F Rotation(float angle, D2DPoint2F center = default)
    {
        D2DMatrix3X2F rotation;
        D2D1MakeRotateMatrix(angle, center, &rotation);
        return rotation;
    }

    public static D2DMatrix3X2F Scale(
        [NativeTypeName("D2D1_SIZE_F")] D2DSizeF size,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F center = default
    )
    {
        D2DMatrix3X2F scale = default;
        scale.m11 = size.width;
        scale.m12 = 0.0f;
        scale.m21 = 0.0f;
        scale.m22 = size.height;
        scale.dx = center.x - size.width * center.x;
        scale.dy = center.y - size.height * center.y;
        return scale;
    }

    public static D2DMatrix3X2F Scale(
        float x,
        float y,
        [NativeTypeName("D2D1_POINT_2F")] D2DPoint2F center = default
    )
    {
        return Scale(new D2DSizeF(x, y), center);
    }

    public void SetProduct(
        [NativeTypeName("const D2D1_MATRIX_3X2 &")] in D2DMatrix3X2F a,
        [NativeTypeName("const D2D1_MATRIX_3X2 &")] in D2DMatrix3X2F b
    )
    {
        m11 = (a.m11 * b.m11) + (a.m12 * b.m21);
        m12 = (a.m11 * b.m12) + (a.m12 * b.m22);
        m21 = (a.m21 * b.m11) + (a.m22 * b.m21);
        m22 = (a.m21 * b.m12) + (a.m22 * b.m22);
        dx = (a.dx * b.m11) + (a.dy * b.m21) + b.dx;
        dy = (a.dx * b.m12) + (a.dy * b.m22) + b.dy;
    }

    public static D2DMatrix3X2F Skew(float angleX, float angleY, D2DPoint2F center = default)
    {
        D2DMatrix3X2F skew;
        D2D1MakeSkewMatrix(angleX, angleY, center, &skew);
        return skew;
    }

    public readonly D2DPoint2F TransformPoint([NativeTypeName("D2D1_POINT_2F")] D2DPoint2F point)
    {
        D2DPoint2F result = new D2DPoint2F
        {
            x =
                (point.x * Anonymous.Anonymous1.m11)
                + (point.y * Anonymous.Anonymous1.m21)
                + Anonymous.Anonymous1.dx,
            y =
                (point.x * Anonymous.Anonymous1.m12)
                + (point.y * Anonymous.Anonymous1.m22)
                + Anonymous.Anonymous1.dy,
        };
        return result;
    }

    public static D2DMatrix3X2F Translation([NativeTypeName("D2D1_SIZE_F")] D2DSizeF size)
    {
        D2DMatrix3X2F translation = default;
        translation.m11 = 1.0f;
        translation.m12 = 0.0f;
        translation.m21 = 0.0f;
        translation.m22 = 1.0f;
        translation.dx = size.width;
        translation.dy = size.height;
        return translation;
    }

    public static D2DMatrix3X2F Translation(float x, float y)
    {
        return Translation(new D2DSizeF(x, y));
    }
}
