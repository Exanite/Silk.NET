// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlBatchNormalizationTrainingGradOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_BATCH_NORMALIZATION_TRAINING_GRAD_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlBatchNormalizationTrainingGradOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlBatchNormalizationTrainingGradOperatorDesc>(),
            Is.EqualTo(sizeof(DmlBatchNormalizationTrainingGradOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlBatchNormalizationTrainingGradOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(DmlBatchNormalizationTrainingGradOperatorDesc).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "DmlBatchNormalizationTrainingGradOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlBatchNormalizationTrainingGradOperatorDesc), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(DmlBatchNormalizationTrainingGradOperatorDesc), Is.EqualTo(36));
        }
    }
}
