// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiModeDesc1"/> struct.</summary>
public static unsafe partial class DXGI_MODE_DESC1Tests
{
    /// <summary>Validates that the <see cref = "DxgiModeDesc1"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxgiModeDesc1>(), Is.EqualTo(sizeof(DxgiModeDesc1)));
    }

    /// <summary>Validates that the <see cref = "DxgiModeDesc1"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiModeDesc1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiModeDesc1"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiModeDesc1), Is.EqualTo(32));
    }
}
