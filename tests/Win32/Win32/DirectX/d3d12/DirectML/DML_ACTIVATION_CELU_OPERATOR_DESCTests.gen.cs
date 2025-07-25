// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlActivationCeluOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ACTIVATION_CELU_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlActivationCeluOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlActivationCeluOperatorDesc>(),
            Is.EqualTo(sizeof(DmlActivationCeluOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlActivationCeluOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlActivationCeluOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlActivationCeluOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlActivationCeluOperatorDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DmlActivationCeluOperatorDesc), Is.EqualTo(12));
        }
    }
}
