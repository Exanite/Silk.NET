// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlActivationTanhOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ACTIVATION_TANH_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlActivationTanhOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlActivationTanhOperatorDesc>(),
            Is.EqualTo(sizeof(DmlActivationTanhOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlActivationTanhOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlActivationTanhOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlActivationTanhOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlActivationTanhOperatorDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DmlActivationTanhOperatorDesc), Is.EqualTo(8));
        }
    }
}
