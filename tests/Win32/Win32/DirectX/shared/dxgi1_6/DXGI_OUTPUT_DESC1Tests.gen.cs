// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiOutputDesc1"/> struct.</summary>
public static unsafe partial class DXGI_OUTPUT_DESC1Tests
{
    /// <summary>Validates that the <see cref = "DxgiOutputDesc1"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiOutputDesc1>(), Is.EqualTo(sizeof(DxgiOutputDesc1)));
    }

    /// <summary>Validates that the <see cref = "DxgiOutputDesc1"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiOutputDesc1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiOutputDesc1"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxgiOutputDesc1), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(DxgiOutputDesc1), Is.EqualTo(144));
        }
    }
}
