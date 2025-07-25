// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiRgb"/> struct.</summary>
public static unsafe partial class DXGI_RGBTests
{
    /// <summary>Validates that the <see cref = "DxgiRgb"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiRgb>(), Is.EqualTo(sizeof(DxgiRgb)));
    }

    /// <summary>Validates that the <see cref = "DxgiRgb"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiRgb).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiRgb"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiRgb), Is.EqualTo(12));
    }
}
