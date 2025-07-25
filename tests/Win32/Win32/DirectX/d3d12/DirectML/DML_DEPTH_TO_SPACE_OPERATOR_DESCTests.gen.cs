// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlDepthToSpaceOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_DEPTH_TO_SPACE_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlDepthToSpaceOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlDepthToSpaceOperatorDesc>(),
            Is.EqualTo(sizeof(DmlDepthToSpaceOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlDepthToSpaceOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlDepthToSpaceOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlDepthToSpaceOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlDepthToSpaceOperatorDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DmlDepthToSpaceOperatorDesc), Is.EqualTo(12));
        }
    }
}
