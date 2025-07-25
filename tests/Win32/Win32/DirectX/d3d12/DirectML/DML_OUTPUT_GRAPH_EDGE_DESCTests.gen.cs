// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DmlOutputGraphEdgeDesc"/> struct.</summary>
public static unsafe partial class DML_OUTPUT_GRAPH_EDGE_DESCTests
{
    /// <summary>Validates that the <see cref = "DmlOutputGraphEdgeDesc"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DmlOutputGraphEdgeDesc>(),
            Is.EqualTo(sizeof(DmlOutputGraphEdgeDesc))
        );
    }

    /// <summary>Validates that the <see cref = "DmlOutputGraphEdgeDesc"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DmlOutputGraphEdgeDesc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DmlOutputGraphEdgeDesc"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DmlOutputGraphEdgeDesc), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DmlOutputGraphEdgeDesc), Is.EqualTo(16));
        }
    }
}
