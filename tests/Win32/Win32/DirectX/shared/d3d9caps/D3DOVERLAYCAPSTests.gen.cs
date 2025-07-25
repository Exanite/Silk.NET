// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3Doverlaycaps"/> struct.</summary>
public static unsafe partial class D3DOVERLAYCAPSTests
{
    /// <summary>Validates that the <see cref = "D3Doverlaycaps"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3Doverlaycaps>(), Is.EqualTo(sizeof(D3Doverlaycaps)));
    }

    /// <summary>Validates that the <see cref = "D3Doverlaycaps"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3Doverlaycaps).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3Doverlaycaps"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3Doverlaycaps), Is.EqualTo(12));
    }
}
