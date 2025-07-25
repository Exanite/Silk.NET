// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiSwapChain3"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IDXGISwapChain3Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiSwapChain3"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiSwapChain3).GUID, Is.EqualTo(IID.IdxgiSwapChain3));
    }

    /// <summary>Validates that the <see cref = "IdxgiSwapChain3"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiSwapChain3>(), Is.EqualTo(sizeof(IdxgiSwapChain3)));
    }

    /// <summary>Validates that the <see cref = "IdxgiSwapChain3"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiSwapChain3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiSwapChain3"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiSwapChain3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiSwapChain3), Is.EqualTo(4));
        }
    }
}
