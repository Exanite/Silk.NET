// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlElementWiseClipGrad1OperatorDesc"/> struct.</summary>
public static unsafe partial class DML_ELEMENT_WISE_CLIP_GRAD1_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlElementWiseClipGrad1OperatorDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlElementWiseClipGrad1OperatorDesc>(),
            Is.EqualTo(sizeof(DmlElementWiseClipGrad1OperatorDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseClipGrad1OperatorDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlElementWiseClipGrad1OperatorDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlElementWiseClipGrad1OperatorDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlElementWiseClipGrad1OperatorDesc), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(DmlElementWiseClipGrad1OperatorDesc), Is.EqualTo(32));
        }
    }
}
