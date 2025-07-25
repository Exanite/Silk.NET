// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiDevice2"/> struct.</summary>
public static unsafe partial class IDXGIDevice2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiDevice2"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiDevice2).GUID, Is.EqualTo(IID.IdxgiDevice2));
    }

    /// <summary>Validates that the <see cref = "IdxgiDevice2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiDevice2>(), Is.EqualTo(sizeof(IdxgiDevice2)));
    }

    /// <summary>Validates that the <see cref = "IdxgiDevice2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiDevice2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiDevice2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiDevice2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiDevice2), Is.EqualTo(4));
        }
    }
}
