// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12SubresourceFootprint"/> struct.</summary>
public static unsafe partial class D3D12_SUBRESOURCE_FOOTPRINTTests
{
    /// <summary>Validates that the <see cref = "D3D12SubresourceFootprint"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12SubresourceFootprint>(),
            Is.EqualTo(sizeof(D3D12SubresourceFootprint))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12SubresourceFootprint"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12SubresourceFootprint).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12SubresourceFootprint"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12SubresourceFootprint), Is.EqualTo(20));
    }
}
