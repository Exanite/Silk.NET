// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12DiscardRegion"/> struct.</summary>
public static unsafe partial class D3D12_DISCARD_REGIONTests
{
    /// <summary>Validates that the <see cref = "D3D12DiscardRegion"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12DiscardRegion>(), Is.EqualTo(sizeof(D3D12DiscardRegion)));
    }

    /// <summary>Validates that the <see cref = "D3D12DiscardRegion"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12DiscardRegion).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12DiscardRegion"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12DiscardRegion), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(D3D12DiscardRegion), Is.EqualTo(16));
        }
    }
}
