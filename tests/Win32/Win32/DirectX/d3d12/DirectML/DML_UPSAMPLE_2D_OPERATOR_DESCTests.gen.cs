// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlUpsample2DOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_UPSAMPLE_2D_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlUpsample2DOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlUpsample2DOperatorDesc>(),
            Is.EqualTo(sizeof(DmlUpsample2DOperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlUpsample2DOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlUpsample2DOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlUpsample2DOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlUpsample2DOperatorDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DmlUpsample2DOperatorDesc), Is.EqualTo(20));
        }
    }
}
