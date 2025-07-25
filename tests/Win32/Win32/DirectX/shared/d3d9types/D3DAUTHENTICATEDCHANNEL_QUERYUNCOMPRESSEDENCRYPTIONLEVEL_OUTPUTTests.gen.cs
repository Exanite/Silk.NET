// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput"/> struct.</summary>
public static unsafe partial class D3DAUTHENTICATEDCHANNEL_QUERYUNCOMPRESSEDENCRYPTIONLEVEL_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput>(),
            Is.EqualTo(sizeof(D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput))
        );
    }

    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(
                sizeof(D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput),
                Is.EqualTo(64)
            );
        }
        else
        {
            Assert.That(
                sizeof(D3DauthenticatedchannelQueryuncompressedencryptionlevelOutput),
                Is.EqualTo(60)
            );
        }
    }
}
