// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiPresentParameters"/> struct.</summary>
public static unsafe partial class DXGI_PRESENT_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "DxgiPresentParameters"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DxgiPresentParameters>(),
            Is.EqualTo(sizeof(DxgiPresentParameters))
        );
    }

    /// <summary>Validates that the <see cref = "DxgiPresentParameters"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiPresentParameters).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiPresentParameters"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxgiPresentParameters), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DxgiPresentParameters), Is.EqualTo(16));
        }
    }
}
