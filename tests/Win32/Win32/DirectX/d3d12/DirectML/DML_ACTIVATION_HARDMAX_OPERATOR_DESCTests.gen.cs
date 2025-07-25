// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlActivationHardmaxOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ACTIVATION_HARDMAX_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlActivationHardmaxOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlActivationHardmaxOperatorDesc>(),
            Is.EqualTo(sizeof(DmlActivationHardmaxOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlActivationHardmaxOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlActivationHardmaxOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlActivationHardmaxOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlActivationHardmaxOperatorDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DmlActivationHardmaxOperatorDesc), Is.EqualTo(8));
        }
    }
}
