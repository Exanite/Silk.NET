// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_CACHE_KIND_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_KIND_FLAGS"]/*'/>
[Flags]
public enum D3D12ShaderCacheKindFlags
{
    /// <include file='D3D12_SHADER_CACHE_KIND_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_KIND_FLAGS.D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CACHE_FOR_DRIVER"]/*'/>

    ImplicitD3DCacheForDriver = 0x1,

    /// <include file='D3D12_SHADER_CACHE_KIND_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_KIND_FLAGS.D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_D3D_CONVERSIONS"]/*'/>

    ImplicitD3DConversions = 0x2,

    /// <include file='D3D12_SHADER_CACHE_KIND_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_KIND_FLAGS.D3D12_SHADER_CACHE_KIND_FLAG_IMPLICIT_DRIVER_MANAGED"]/*'/>

    ImplicitDriverManaged = 0x4,

    /// <include file='D3D12_SHADER_CACHE_KIND_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_KIND_FLAGS.D3D12_SHADER_CACHE_KIND_FLAG_APPLICATION_MANAGED"]/*'/>

    ApplicationManaged = 0x8,
}
