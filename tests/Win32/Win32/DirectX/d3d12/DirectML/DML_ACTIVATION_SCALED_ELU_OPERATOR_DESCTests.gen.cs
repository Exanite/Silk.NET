// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlActivationScaledEluOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ACTIVATION_SCALED_ELU_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlActivationScaledEluOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlActivationScaledEluOperatorDesc>(),
            Is.EqualTo(sizeof(DmlActivationScaledEluOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlActivationScaledEluOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlActivationScaledEluOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlActivationScaledEluOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlActivationScaledEluOperatorDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DmlActivationScaledEluOperatorDesc), Is.EqualTo(16));
        }
    }
}
