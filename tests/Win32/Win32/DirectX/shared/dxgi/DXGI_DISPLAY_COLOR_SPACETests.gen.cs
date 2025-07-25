// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiDisplayColorSpace"/> struct.</summary>
public static unsafe partial class DXGI_DISPLAY_COLOR_SPACETests
{
    /// <summary>Validates that the <see cref = "DxgiDisplayColorSpace"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DxgiDisplayColorSpace>(),
            Is.EqualTo(sizeof(DxgiDisplayColorSpace))
        );
    }

    /// <summary>Validates that the <see cref = "DxgiDisplayColorSpace"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiDisplayColorSpace).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiDisplayColorSpace"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiDisplayColorSpace), Is.EqualTo(192));
    }
}
