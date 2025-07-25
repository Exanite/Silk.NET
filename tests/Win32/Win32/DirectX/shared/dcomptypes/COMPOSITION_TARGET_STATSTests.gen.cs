// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "CompositionTargetStats"/> struct.</summary>
public static unsafe partial class COMPOSITION_TARGET_STATSTests
{
    /// <summary>Validates that the <see cref = "CompositionTargetStats"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CompositionTargetStats>(),
            Is.EqualTo(sizeof(CompositionTargetStats))
        );
    }

    /// <summary>Validates that the <see cref = "CompositionTargetStats"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompositionTargetStats).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CompositionTargetStats"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CompositionTargetStats), Is.EqualTo(72));
    }
}
