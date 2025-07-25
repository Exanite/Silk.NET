// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlFeatureDataFeatureLevels"/> struct.</summary>
public static unsafe partial class DML_FEATURE_DATA_FEATURE_LEVELSTests
{
    /// <summary>Validates that the <see cref = "DmlFeatureDataFeatureLevels"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlFeatureDataFeatureLevels>(),
            Is.EqualTo(sizeof(DmlFeatureDataFeatureLevels))
        );
    }

    /// <summary>Validates that the <see cref = "DmlFeatureDataFeatureLevels"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlFeatureDataFeatureLevels).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlFeatureDataFeatureLevels"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DmlFeatureDataFeatureLevels), Is.EqualTo(4));
    }
}
