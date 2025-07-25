// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlActivationLogSoftmaxOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ACTIVATION_LOG_SOFTMAX_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlActivationLogSoftmaxOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlActivationLogSoftmaxOperatorDesc>(),
            Is.EqualTo(sizeof(DmlActivationLogSoftmaxOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlActivationLogSoftmaxOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlActivationLogSoftmaxOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlActivationLogSoftmaxOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlActivationLogSoftmaxOperatorDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DmlActivationLogSoftmaxOperatorDesc), Is.EqualTo(8));
        }
    }
}
