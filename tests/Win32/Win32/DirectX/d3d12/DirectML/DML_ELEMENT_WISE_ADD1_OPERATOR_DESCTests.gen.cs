// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlElementWiseAdd1OperatorDesc"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class DML_ELEMENT_WISE_ADD1_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlElementWiseAdd1OperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlElementWiseAdd1OperatorDesc>(),
            Is.EqualTo(sizeof(DmlElementWiseAdd1OperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseAdd1OperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlElementWiseAdd1OperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseAdd1OperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlElementWiseAdd1OperatorDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DmlElementWiseAdd1OperatorDesc), Is.EqualTo(16));
        }
    }
}
