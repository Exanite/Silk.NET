// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlCastOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_CAST_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlCastOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DmlCastOperatorDesc>(), Is.EqualTo(sizeof(DmlCastOperatorDesc)));
    }

    /// <summary>Validates that the <see cref = "DmlCastOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlCastOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlCastOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlCastOperatorDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DmlCastOperatorDesc), Is.EqualTo(8));
        }
    }
}
