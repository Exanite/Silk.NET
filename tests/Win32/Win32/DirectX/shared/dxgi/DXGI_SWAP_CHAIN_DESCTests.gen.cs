// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiSwapChainDesc"/> struct.</summary>
public static unsafe partial class DXGI_SWAP_CHAIN_DESCTests
{
    /// <summary>Validates that the <see cref = "DxgiSwapChainDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiSwapChainDesc>(), Is.EqualTo(sizeof(DxgiSwapChainDesc)));
    }

    /// <summary>Validates that the <see cref = "DxgiSwapChainDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiSwapChainDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiSwapChainDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxgiSwapChainDesc), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(DxgiSwapChainDesc), Is.EqualTo(60));
        }
    }
}
