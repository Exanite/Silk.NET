// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlAdamOptimizerOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ADAM_OPTIMIZER_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlAdamOptimizerOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlAdamOptimizerOperatorDesc>(),
            Is.EqualTo(sizeof(DmlAdamOptimizerOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlAdamOptimizerOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlAdamOptimizerOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlAdamOptimizerOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlAdamOptimizerOperatorDesc), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(DmlAdamOptimizerOperatorDesc), Is.EqualTo(48));
        }
    }
}
