// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlSlice1OperatorDesc"/> struct.</summary>
public static unsafe partial class DML_SLICE1_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlSlice1OperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlSlice1OperatorDesc>(),
            Is.EqualTo(sizeof(DmlSlice1OperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlSlice1OperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlSlice1OperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlSlice1OperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlSlice1OperatorDesc), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(DmlSlice1OperatorDesc), Is.EqualTo(24));
        }
    }
}
