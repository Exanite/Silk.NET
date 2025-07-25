// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiOutputDesc"/> struct.</summary>
public static unsafe partial class DXGI_OUTPUT_DESCTests
{
    /// <summary>Validates that the <see cref = "DxgiOutputDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiOutputDesc>(), Is.EqualTo(sizeof(DxgiOutputDesc)));
    }

    /// <summary>Validates that the <see cref = "DxgiOutputDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiOutputDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiOutputDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxgiOutputDesc), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(DxgiOutputDesc), Is.EqualTo(92));
        }
    }
}
