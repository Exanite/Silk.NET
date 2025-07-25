// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlRoiPoolingOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ROI_POOLING_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlRoiPoolingOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlRoiPoolingOperatorDesc>(),
            Is.EqualTo(sizeof(DmlRoiPoolingOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlRoiPoolingOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlRoiPoolingOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlRoiPoolingOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlRoiPoolingOperatorDesc), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DmlRoiPoolingOperatorDesc), Is.EqualTo(24));
        }
    }
}
