// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEVICE_FACTORY_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FACTORY_FLAGS"]/*'/>
[Flags]
public enum D3D12DeviceFactoryFlags
{
    /// <include file='D3D12_DEVICE_FACTORY_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FACTORY_FLAGS.D3D12_DEVICE_FACTORY_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_DEVICE_FACTORY_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FACTORY_FLAGS.D3D12_DEVICE_FACTORY_FLAG_ALLOW_RETURNING_EXISTING_DEVICE"]/*'/>

    AllowReturningExistingDevice = 0x1,

    /// <include file='D3D12_DEVICE_FACTORY_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FACTORY_FLAGS.D3D12_DEVICE_FACTORY_FLAG_ALLOW_RETURNING_INCOMPATIBLE_EXISTING_DEVICE"]/*'/>

    AllowReturningIncompatibleExistingDevice = 0x2,

    /// <include file='D3D12_DEVICE_FACTORY_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FACTORY_FLAGS.D3D12_DEVICE_FACTORY_FLAG_DISALLOW_STORING_NEW_DEVICE_AS_SINGLETON"]/*'/>

    DisallowStoringNewDeviceAsSingleton = 0x4,
}
