// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiSwapChainMedia"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDXGISwapChainMediaTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiSwapChainMedia"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiSwapChainMedia).GUID, Is.EqualTo(IID.IdxgiSwapChainMedia));
    }

    /// <summary>Validates that the <see cref = "IdxgiSwapChainMedia"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiSwapChainMedia>(), Is.EqualTo(sizeof(IdxgiSwapChainMedia)));
    }

    /// <summary>Validates that the <see cref = "IdxgiSwapChainMedia"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiSwapChainMedia).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiSwapChainMedia"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiSwapChainMedia), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiSwapChainMedia), Is.EqualTo(4));
        }
    }
}
