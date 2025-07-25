// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlBindingProperties"/> struct.</summary>
public static unsafe partial class DML_BINDING_PROPERTIESTests
{
    /// <summary>Validates that the <see cref = "DmlBindingProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlBindingProperties>(),
            Is.EqualTo(sizeof(DmlBindingProperties))
        );
    }

    /// <summary>Validates that the <see cref = "DmlBindingProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlBindingProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlBindingProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DmlBindingProperties), Is.EqualTo(24));
    }
}
