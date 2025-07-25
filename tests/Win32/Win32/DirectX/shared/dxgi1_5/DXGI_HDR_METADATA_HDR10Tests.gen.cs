// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DxgiHdrMetadataHdr10"/> struct.</summary>
public static unsafe partial class DXGI_HDR_METADATA_HDR10Tests
{
    /// <summary>Validates that the <see cref = "DxgiHdrMetadataHdr10"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DxgiHdrMetadataHdr10>(),
            Is.EqualTo(sizeof(DxgiHdrMetadataHdr10))
        );
    }

    /// <summary>Validates that the <see cref = "DxgiHdrMetadataHdr10"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxgiHdrMetadataHdr10).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxgiHdrMetadataHdr10"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxgiHdrMetadataHdr10), Is.EqualTo(28));
    }
}
