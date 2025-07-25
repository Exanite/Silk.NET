// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiRational"/> struct.</summary>
public static unsafe partial class DXGI_RATIONALTests
{
    /// <summary>Validates that the <see cref = "DxgiRational"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiRational>(), Is.EqualTo(sizeof(DxgiRational)));
    }

    /// <summary>Validates that the <see cref = "DxgiRational"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiRational).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiRational"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiRational), Is.EqualTo(8));
    }
}
