// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlScalarUnion"/> struct.</summary>
public static unsafe partial class DML_SCALAR_UNIONTests
{
    /// <summary>Validates that the <see cref = "DmlScalarUnion"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DmlScalarUnion>(), Is.EqualTo(sizeof(DmlScalarUnion)));
    }

    /// <summary>Validates that the <see cref = "DmlScalarUnion"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(DmlScalarUnion).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlScalarUnion"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DmlScalarUnion), Is.EqualTo(8));
    }
}
