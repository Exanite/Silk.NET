// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiMappedRect"/> struct.</summary>
public static unsafe partial class DXGI_MAPPED_RECTTests
{
    /// <summary>Validates that the <see cref = "DxgiMappedRect"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiMappedRect>(), Is.EqualTo(sizeof(DxgiMappedRect)));
    }

    /// <summary>Validates that the <see cref = "DxgiMappedRect"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiMappedRect).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiMappedRect"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxgiMappedRect), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DxgiMappedRect), Is.EqualTo(8));
        }
    }
}
