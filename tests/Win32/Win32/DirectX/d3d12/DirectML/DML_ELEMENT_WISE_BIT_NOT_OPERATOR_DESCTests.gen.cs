// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlElementWiseBitNotOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ELEMENT_WISE_BIT_NOT_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlElementWiseBitNotOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlElementWiseBitNotOperatorDesc>(),
            Is.EqualTo(sizeof(DmlElementWiseBitNotOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseBitNotOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlElementWiseBitNotOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseBitNotOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlElementWiseBitNotOperatorDesc), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DmlElementWiseBitNotOperatorDesc), Is.EqualTo(8));
        }
    }
}
