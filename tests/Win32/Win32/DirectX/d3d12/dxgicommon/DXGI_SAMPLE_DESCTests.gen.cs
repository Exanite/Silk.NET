// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiSampleDesc"/> struct.</summary>
public static unsafe partial class DXGI_SAMPLE_DESCTests
{
    /// <summary>Validates that the <see cref = "DxgiSampleDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiSampleDesc>(), Is.EqualTo(sizeof(DxgiSampleDesc)));
    }

    /// <summary>Validates that the <see cref = "DxgiSampleDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiSampleDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiSampleDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiSampleDesc), Is.EqualTo(8));
    }
}
