// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlBufferBinding"/> struct.</summary>
public static unsafe partial class DML_BUFFER_BINDINGTests
{
    /// <summary>Validates that the <see cref = "DmlBufferBinding"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DmlBufferBinding>(), Is.EqualTo(sizeof(DmlBufferBinding)));
    }

    /// <summary>Validates that the <see cref = "DmlBufferBinding"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlBufferBinding).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlBufferBinding"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DmlBufferBinding), Is.EqualTo(24));
    }
}
