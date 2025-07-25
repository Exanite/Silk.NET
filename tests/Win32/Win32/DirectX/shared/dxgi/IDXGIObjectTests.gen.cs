// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiObject"/> struct.</summary>
public static unsafe partial class IDXGIObjectTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiObject"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiObject).GUID, Is.EqualTo(IID.IdxgiObject));
    }

    /// <summary>Validates that the <see cref = "IdxgiObject"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiObject>(), Is.EqualTo(sizeof(IdxgiObject)));
    }

    /// <summary>Validates that the <see cref = "IdxgiObject"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiObject).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiObject"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiObject), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiObject), Is.EqualTo(4));
        }
    }
}
