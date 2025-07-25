// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlBindingTableDesc"/> struct.</summary>
public static unsafe partial class DML_BINDING_TABLE_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlBindingTableDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DmlBindingTableDesc>(), Is.EqualTo(sizeof(DmlBindingTableDesc)));
    }

    /// <summary>Validates that the <see cref = "DmlBindingTableDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlBindingTableDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlBindingTableDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlBindingTableDesc), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DmlBindingTableDesc), Is.EqualTo(24));
        }
    }
}
