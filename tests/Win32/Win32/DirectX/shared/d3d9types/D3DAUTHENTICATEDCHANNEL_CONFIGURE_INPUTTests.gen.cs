// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DauthenticatedchannelConfigureInput"/> struct.</summary>
public static unsafe partial class D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUTTests
{
    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelConfigureInput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3DauthenticatedchannelConfigureInput>(),
            Is.EqualTo(sizeof(D3DauthenticatedchannelConfigureInput))
        );
    }

    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelConfigureInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3DauthenticatedchannelConfigureInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3DauthenticatedchannelConfigureInput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3DauthenticatedchannelConfigureInput), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(D3DauthenticatedchannelConfigureInput), Is.EqualTo(40));
        }
    }
}
