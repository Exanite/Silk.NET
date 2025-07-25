// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiSurface"/> struct.</summary>
public static unsafe partial class IDXGISurfaceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiSurface"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiSurface).GUID, Is.EqualTo(IID.IdxgiSurface));
    }

    /// <summary>Validates that the <see cref = "IdxgiSurface"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiSurface>(), Is.EqualTo(sizeof(IdxgiSurface)));
    }

    /// <summary>Validates that the <see cref = "IdxgiSurface"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiSurface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiSurface"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiSurface), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiSurface), Is.EqualTo(4));
        }
    }
}
