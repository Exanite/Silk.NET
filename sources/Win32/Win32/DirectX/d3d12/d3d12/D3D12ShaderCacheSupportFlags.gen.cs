// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum D3D12ShaderCacheSupportFlags
{
    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO"]/*'/>

    SinglePso = 0x1,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_LIBRARY"]/*'/>

    Library = 0x2,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE"]/*'/>

    AutomaticInprocCache = 0x4,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE"]/*'/>

    AutomaticDiskCache = 0x8,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_DRIVER_MANAGED_CACHE"]/*'/>

    DriverManagedCache = 0x10,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_SHADER_CONTROL_CLEAR"]/*'/>

    ShaderControlClear = 0x20,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_SHADER_SESSION_DELETE"]/*'/>

    ShaderSessionDelete = 0x40,
}
