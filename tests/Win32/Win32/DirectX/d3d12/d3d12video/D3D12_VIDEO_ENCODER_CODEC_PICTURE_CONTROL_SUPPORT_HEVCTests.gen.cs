// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12VideoEncoderCodecPictureControlSupportHevc"/> struct.</summary>
public static unsafe partial class D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVCTests
{
    /// <summary>Validates that the <see cref = "D3D12VideoEncoderCodecPictureControlSupportHevc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12VideoEncoderCodecPictureControlSupportHevc>(),
            Is.EqualTo(sizeof(D3D12VideoEncoderCodecPictureControlSupportHevc))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12VideoEncoderCodecPictureControlSupportHevc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(D3D12VideoEncoderCodecPictureControlSupportHevc).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "D3D12VideoEncoderCodecPictureControlSupportHevc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12VideoEncoderCodecPictureControlSupportHevc), Is.EqualTo(20));
    }
}
