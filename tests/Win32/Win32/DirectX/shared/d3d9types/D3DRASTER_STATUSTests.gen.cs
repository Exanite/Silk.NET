// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DrasterStatus"/> struct.</summary>
public static unsafe partial class D3DRASTER_STATUSTests
{
    /// <summary>Validates that the <see cref = "D3DrasterStatus"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3DrasterStatus>(), Is.EqualTo(sizeof(D3DrasterStatus)));
    }

    /// <summary>Validates that the <see cref = "D3DrasterStatus"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3DrasterStatus).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3DrasterStatus"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3DrasterStatus), Is.EqualTo(8));
    }
}
