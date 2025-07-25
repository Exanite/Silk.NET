// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiDecodeSwapChain"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDXGIDecodeSwapChainTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiDecodeSwapChain"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiDecodeSwapChain).GUID, Is.EqualTo(IID.IdxgiDecodeSwapChain));
    }

    /// <summary>Validates that the <see cref = "IdxgiDecodeSwapChain"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IdxgiDecodeSwapChain>(),
            Is.EqualTo(sizeof(IdxgiDecodeSwapChain))
        );
    }

    /// <summary>Validates that the <see cref = "IdxgiDecodeSwapChain"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiDecodeSwapChain).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiDecodeSwapChain"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiDecodeSwapChain), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiDecodeSwapChain), Is.EqualTo(4));
        }
    }
}
