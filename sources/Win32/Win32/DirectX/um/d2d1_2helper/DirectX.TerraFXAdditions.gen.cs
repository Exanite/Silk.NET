// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_2helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [SupportedOSPlatform("windows6.3")]
    public static float ComputeFlatteningTolerance(
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2DMatrix3X2F matrix,
        float dpiX = 96.0f,
        float dpiY = 96.0f,
        float maxZoomFactor = 1.0f
    )
    {
        D2DMatrix3X2F dpiDependentTransform =
            matrix * D2DMatrix3X2F.Scale(dpiX / 96.0f, dpiY / 96.0f);
        float absMaxZoomFactor = (maxZoomFactor > 0) ? maxZoomFactor : -maxZoomFactor;
        return D2D1_DEFAULT_FLATTENING_TOLERANCE
            / (absMaxZoomFactor * D2D1ComputeMaximumScaleFactor(&dpiDependentTransform));
    }
}
