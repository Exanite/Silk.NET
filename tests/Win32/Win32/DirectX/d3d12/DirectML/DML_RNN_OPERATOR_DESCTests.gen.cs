// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlRnnOperatorDesc"/> struct.</summary>
public static unsafe partial class DML_RNN_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlRnnOperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DmlRnnOperatorDesc>(), Is.EqualTo(sizeof(DmlRnnOperatorDesc)));
    }

    /// <summary>Validates that the <see cref = "DmlRnnOperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlRnnOperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlRnnOperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlRnnOperatorDesc), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(DmlRnnOperatorDesc), Is.EqualTo(44));
        }
    }
}
