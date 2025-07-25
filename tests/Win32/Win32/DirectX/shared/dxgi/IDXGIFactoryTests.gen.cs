// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiFactory"/> struct.</summary>
public static unsafe partial class IDXGIFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiFactory).GUID, Is.EqualTo(IID.IdxgiFactory));
    }

    /// <summary>Validates that the <see cref = "IdxgiFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiFactory>(), Is.EqualTo(sizeof(IdxgiFactory)));
    }

    /// <summary>Validates that the <see cref = "IdxgiFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiFactory), Is.EqualTo(4));
        }
    }
}
