// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlElementWiseLogicalOrOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ELEMENT_WISE_LOGICAL_OR_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlElementWiseLogicalOrOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlElementWiseLogicalOrOperatorDesc>(),
            Is.EqualTo(sizeof(DmlElementWiseLogicalOrOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseLogicalOrOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlElementWiseLogicalOrOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseLogicalOrOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlElementWiseLogicalOrOperatorDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DmlElementWiseLogicalOrOperatorDesc), Is.EqualTo(12));
        }
    }
}
