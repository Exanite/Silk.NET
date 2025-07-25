// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using Silk.NET.Win32;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IdxgiFactoryMedia"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDXGIFactoryMediaTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IdxgiFactoryMedia"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IdxgiFactoryMedia).GUID, Is.EqualTo(IID.IdxgiFactoryMedia));
    }

    /// <summary>Validates that the <see cref = "IdxgiFactoryMedia"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IdxgiFactoryMedia>(), Is.EqualTo(sizeof(IdxgiFactoryMedia)));
    }

    /// <summary>Validates that the <see cref = "IdxgiFactoryMedia"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IdxgiFactoryMedia).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IdxgiFactoryMedia"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IdxgiFactoryMedia), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IdxgiFactoryMedia), Is.EqualTo(4));
        }
    }
}
