// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12VideoEncoderAv1RestorationConfig"/> struct.</summary>
public static unsafe partial class D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIGTests
{
    /// <summary>Validates that the <see cref = "D3D12VideoEncoderAv1RestorationConfig"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12VideoEncoderAv1RestorationConfig>(),
            Is.EqualTo(sizeof(D3D12VideoEncoderAv1RestorationConfig))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12VideoEncoderAv1RestorationConfig"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12VideoEncoderAv1RestorationConfig).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12VideoEncoderAv1RestorationConfig"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12VideoEncoderAv1RestorationConfig), Is.EqualTo(24));
    }
}
