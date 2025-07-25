// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlCumulativeSummationOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_CUMULATIVE_SUMMATION_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlCumulativeSummationOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlCumulativeSummationOperatorDesc>(),
            Is.EqualTo(sizeof(DmlCumulativeSummationOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlCumulativeSummationOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlCumulativeSummationOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlCumulativeSummationOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlCumulativeSummationOperatorDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DmlCumulativeSummationOperatorDesc), Is.EqualTo(20));
        }
    }
}
