// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3Dvector"/> struct.</summary>
public static unsafe partial class D3DVECTORTests
{
    /// <summary>Validates that the <see cref = "D3Dvector"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3Dvector>(), Is.EqualTo(sizeof(D3Dvector)));
    }

    /// <summary>Validates that the <see cref = "D3Dvector"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3Dvector).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3Dvector"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3Dvector), Is.EqualTo(12));
    }
}
