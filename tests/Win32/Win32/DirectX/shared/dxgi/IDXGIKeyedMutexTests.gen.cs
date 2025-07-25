// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiKeyedMutex"/> struct.</summary>
public static unsafe partial class IDXGIKeyedMutexTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiKeyedMutex"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiKeyedMutex).GUID, Is.EqualTo(IID.IdxgiKeyedMutex));
    }

    /// <summary>Validates that the <see cref = "IdxgiKeyedMutex"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiKeyedMutex>(), Is.EqualTo(sizeof(IdxgiKeyedMutex)));
    }

    /// <summary>Validates that the <see cref = "IdxgiKeyedMutex"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiKeyedMutex).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiKeyedMutex"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiKeyedMutex), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiKeyedMutex), Is.EqualTo(4));
        }
    }
}
