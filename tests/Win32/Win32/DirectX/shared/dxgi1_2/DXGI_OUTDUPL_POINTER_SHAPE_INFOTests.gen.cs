// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiOutduplPointerShapeInfo"/> struct.</summary>
public static unsafe partial class DXGI_OUTDUPL_POINTER_SHAPE_INFOTests
{
    /// <summary>Validates that the <see cref = "DxgiOutduplPointerShapeInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DxgiOutduplPointerShapeInfo>(),
            Is.EqualTo(sizeof(DxgiOutduplPointerShapeInfo))
        );
    }

    /// <summary>Validates that the <see cref = "DxgiOutduplPointerShapeInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiOutduplPointerShapeInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiOutduplPointerShapeInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiOutduplPointerShapeInfo), Is.EqualTo(24));
    }
}
