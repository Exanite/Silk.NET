// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12ResolveVideoMotionVectorHeapInput"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUTTests
{
    /// <summary>Validates that the <see cref = "D3D12ResolveVideoMotionVectorHeapInput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12ResolveVideoMotionVectorHeapInput>(),
            Is.EqualTo(sizeof(D3D12ResolveVideoMotionVectorHeapInput))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12ResolveVideoMotionVectorHeapInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12ResolveVideoMotionVectorHeapInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12ResolveVideoMotionVectorHeapInput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12ResolveVideoMotionVectorHeapInput), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(D3D12ResolveVideoMotionVectorHeapInput), Is.EqualTo(12));
        }
    }
}
