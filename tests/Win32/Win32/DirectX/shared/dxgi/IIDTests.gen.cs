// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Win32.IID;

namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IdxgiObject"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIObjectTest()
    {
        Assert.That(
            IdxgiObject,
            Is.EqualTo(
                new Guid(0xaec22fb8, 0x76f3, 0x4639, 0x9b, 0xe0, 0x28, 0xeb, 0x43, 0xa6, 0x7a, 0x2e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiDeviceSubObject"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDeviceSubObjectTest()
    {
        Assert.That(
            IdxgiDeviceSubObject,
            Is.EqualTo(
                new Guid(0x3d3e0379, 0xf9de, 0x4d58, 0xbb, 0x6c, 0x18, 0xd6, 0x29, 0x92, 0xf1, 0xa6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiResource"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIResourceTest()
    {
        Assert.That(
            IdxgiResource,
            Is.EqualTo(
                new Guid(0x035f3ab4, 0x482e, 0x4e50, 0xb4, 0x1f, 0x8a, 0x7f, 0x8b, 0xd8, 0x96, 0x0b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiKeyedMutex"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIKeyedMutexTest()
    {
        Assert.That(
            IdxgiKeyedMutex,
            Is.EqualTo(
                new Guid(0x9d8e1289, 0xd7b3, 0x465f, 0x81, 0x26, 0x25, 0x0e, 0x34, 0x9a, 0xf8, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiSurface"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGISurfaceTest()
    {
        Assert.That(
            IdxgiSurface,
            Is.EqualTo(
                new Guid(0xcafcb56c, 0x6ac3, 0x4889, 0xbf, 0x47, 0x9e, 0x23, 0xbb, 0xd2, 0x60, 0xec)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiSurface1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGISurface1Test()
    {
        Assert.That(
            IdxgiSurface1,
            Is.EqualTo(
                new Guid(0x4AE63092, 0x6327, 0x4c1b, 0x80, 0xAE, 0xBF, 0xE1, 0x2E, 0xA3, 0x2B, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiAdapter"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIAdapterTest()
    {
        Assert.That(
            IdxgiAdapter,
            Is.EqualTo(
                new Guid(0x2411e7e1, 0x12ac, 0x4ccf, 0xbd, 0x14, 0x97, 0x98, 0xe8, 0x53, 0x4d, 0xc0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiOutput"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIOutputTest()
    {
        Assert.That(
            IdxgiOutput,
            Is.EqualTo(
                new Guid(0xae02eedb, 0xc735, 0x4690, 0x8d, 0x52, 0x5a, 0x8d, 0xc2, 0x02, 0x13, 0xaa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiSwapChain"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGISwapChainTest()
    {
        Assert.That(
            IdxgiSwapChain,
            Is.EqualTo(
                new Guid(0x310d36a0, 0xd2e7, 0x4c0a, 0xaa, 0x04, 0x6a, 0x9d, 0x23, 0xb8, 0x88, 0x6a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiFactory"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIFactoryTest()
    {
        Assert.That(
            IdxgiFactory,
            Is.EqualTo(
                new Guid(0x7b7166ec, 0x21c7, 0x44ae, 0xb2, 0x1a, 0xc9, 0xae, 0x32, 0x1a, 0xe3, 0x69)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiDevice"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDeviceTest()
    {
        Assert.That(
            IdxgiDevice,
            Is.EqualTo(
                new Guid(0x54ec77fa, 0x1377, 0x44e6, 0x8c, 0x32, 0x88, 0xfd, 0x5f, 0x44, 0xc8, 0x4c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiFactory1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIFactory1Test()
    {
        Assert.That(
            IdxgiFactory1,
            Is.EqualTo(
                new Guid(0x770aae78, 0xf26f, 0x4dba, 0xa8, 0x29, 0x25, 0x3c, 0x83, 0xd1, 0xb3, 0x87)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiAdapter1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIAdapter1Test()
    {
        Assert.That(
            IdxgiAdapter1,
            Is.EqualTo(
                new Guid(0x29038f61, 0x3839, 0x4626, 0x91, 0xfd, 0x08, 0x68, 0x79, 0x01, 0x1a, 0x05)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IdxgiDevice1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDevice1Test()
    {
        Assert.That(
            IdxgiDevice1,
            Is.EqualTo(
                new Guid(0x77db970f, 0x6276, 0x48ba, 0xba, 0x28, 0x07, 0x01, 0x43, 0xb4, 0x39, 0x2c)
            )
        );
    }
}
