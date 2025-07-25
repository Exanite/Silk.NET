// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ELEMENT_WISE_LOGICAL_GREATER_THAN_OR_EQUAL_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc>(),
            Is.EqualTo(sizeof(DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(
                sizeof(DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc),
                Is.EqualTo(24)
            );
        }
        else
        {
            Assert.That(
                sizeof(DmlElementWiseLogicalGreaterThanOrEqualOperatorDesc),
                Is.EqualTo(12)
            );
        }
    }
}
