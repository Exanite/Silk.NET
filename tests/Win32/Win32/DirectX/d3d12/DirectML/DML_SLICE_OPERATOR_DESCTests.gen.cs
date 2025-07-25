// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlSliceOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_SLICE_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlSliceOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlSliceOperatorDesc>(),
            Is.EqualTo(sizeof(DmlSliceOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlSliceOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlSliceOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlSliceOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlSliceOperatorDesc), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(DmlSliceOperatorDesc), Is.EqualTo(24));
        }
    }
}
