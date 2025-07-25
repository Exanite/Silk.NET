// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlMeanVarianceNormalizationOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlMeanVarianceNormalizationOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlMeanVarianceNormalizationOperatorDesc>(),
            Is.EqualTo(sizeof(DmlMeanVarianceNormalizationOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlMeanVarianceNormalizationOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlMeanVarianceNormalizationOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlMeanVarianceNormalizationOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlMeanVarianceNormalizationOperatorDesc), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(DmlMeanVarianceNormalizationOperatorDesc), Is.EqualTo(32));
        }
    }
}
