// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlSpaceToDepth1OperatorDesc"/> struct.</summary>
public static unsafe partial class DML_SPACE_TO_DEPTH1_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlSpaceToDepth1OperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlSpaceToDepth1OperatorDesc>(),
            Is.EqualTo(sizeof(DmlSpaceToDepth1OperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlSpaceToDepth1OperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlSpaceToDepth1OperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlSpaceToDepth1OperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlSpaceToDepth1OperatorDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DmlSpaceToDepth1OperatorDesc), Is.EqualTo(16));
        }
    }
}
