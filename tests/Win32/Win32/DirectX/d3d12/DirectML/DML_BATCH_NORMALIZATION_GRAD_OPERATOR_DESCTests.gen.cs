// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlBatchNormalizationGradOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlBatchNormalizationGradOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlBatchNormalizationGradOperatorDesc>(),
            Is.EqualTo(sizeof(DmlBatchNormalizationGradOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlBatchNormalizationGradOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlBatchNormalizationGradOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlBatchNormalizationGradOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlBatchNormalizationGradOperatorDesc), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(DmlBatchNormalizationGradOperatorDesc), Is.EqualTo(36));
        }
    }
}
