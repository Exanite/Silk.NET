// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiGammaControlCapabilities"/> struct.</summary>
public static unsafe partial class DXGI_GAMMA_CONTROL_CAPABILITIESTests
{
    /// <summary>Validates that the <see cref = "DxgiGammaControlCapabilities"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DxgiGammaControlCapabilities>(),
            Is.EqualTo(sizeof(DxgiGammaControlCapabilities))
        );
    }

    /// <summary>Validates that the <see cref = "DxgiGammaControlCapabilities"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiGammaControlCapabilities).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiGammaControlCapabilities"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiGammaControlCapabilities), Is.EqualTo(4116));
    }
}
