// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiSurfaceDesc"/> struct.</summary>
public static unsafe partial class DXGI_SURFACE_DESCTests
{
    /// <summary>Validates that the <see cref = "DxgiSurfaceDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiSurfaceDesc>(), Is.EqualTo(sizeof(DxgiSurfaceDesc)));
    }

    /// <summary>Validates that the <see cref = "DxgiSurfaceDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiSurfaceDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiSurfaceDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiSurfaceDesc), Is.EqualTo(20));
    }
}
