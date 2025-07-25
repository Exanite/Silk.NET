// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlReverseSubsequencesOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_REVERSE_SUBSEQUENCES_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlReverseSubsequencesOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlReverseSubsequencesOperatorDesc>(),
            Is.EqualTo(sizeof(DmlReverseSubsequencesOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlReverseSubsequencesOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlReverseSubsequencesOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlReverseSubsequencesOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlReverseSubsequencesOperatorDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DmlReverseSubsequencesOperatorDesc), Is.EqualTo(16));
        }
    }
}
