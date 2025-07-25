// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DauthenticatedchannelQuerycryptosessionInput"/> struct.</summary>
public static unsafe partial class D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUTTests
{
    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelQuerycryptosessionInput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3DauthenticatedchannelQuerycryptosessionInput>(),
            Is.EqualTo(sizeof(D3DauthenticatedchannelQuerycryptosessionInput))
        );
    }

    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelQuerycryptosessionInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(D3DauthenticatedchannelQuerycryptosessionInput).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelQuerycryptosessionInput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3DauthenticatedchannelQuerycryptosessionInput), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(D3DauthenticatedchannelQuerycryptosessionInput), Is.EqualTo(28));
        }
    }
}
