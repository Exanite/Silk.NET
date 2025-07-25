// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiDevice"/> struct.</summary>
public static unsafe partial class IDXGIDeviceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiDevice"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiDevice).GUID, Is.EqualTo(IID.IdxgiDevice));
    }

    /// <summary>Validates that the <see cref = "IdxgiDevice"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiDevice>(), Is.EqualTo(sizeof(IdxgiDevice)));
    }

    /// <summary>Validates that the <see cref = "IdxgiDevice"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiDevice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiDevice"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiDevice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiDevice), Is.EqualTo(4));
        }
    }
}
