// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "CompositionTargetId"/> struct.</summary>
[SupportedOSPlatform("windows10.0.22000.0")]
public static unsafe partial class COMPOSITION_TARGET_IDTests
{
    /// <summary>Validates that the <see cref = "CompositionTargetId"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CompositionTargetId>(), Is.EqualTo(sizeof(CompositionTargetId)));
    }

    /// <summary>Validates that the <see cref = "CompositionTargetId"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompositionTargetId).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CompositionTargetId"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CompositionTargetId), Is.EqualTo(28));
    }
}
