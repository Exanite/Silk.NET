// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiDecodeSwapChainDesc"/> struct.</summary>
public static unsafe partial class DXGI_DECODE_SWAP_CHAIN_DESCTests
{
    /// <summary>Validates that the <see cref = "DxgiDecodeSwapChainDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DxgiDecodeSwapChainDesc>(),
            Is.EqualTo(sizeof(DxgiDecodeSwapChainDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DxgiDecodeSwapChainDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiDecodeSwapChainDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiDecodeSwapChainDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiDecodeSwapChainDesc), Is.EqualTo(4));
    }
}
