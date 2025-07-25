// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiAdapterDesc"/> struct.</summary>
public static unsafe partial class DXGI_ADAPTER_DESCTests
{
    /// <summary>Validates that the <see cref = "DxgiAdapterDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiAdapterDesc>(), Is.EqualTo(sizeof(DxgiAdapterDesc)));
    }

    /// <summary>Validates that the <see cref = "DxgiAdapterDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiAdapterDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiAdapterDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxgiAdapterDesc), Is.EqualTo(304));
        }
        else
        {
            Assert.That(sizeof(DxgiAdapterDesc), Is.EqualTo(292));
        }
    }
}
