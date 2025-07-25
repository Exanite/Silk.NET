// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS"]/*'/>
public enum D3D12ShaderCacheControlFlags
{
    /// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS.D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE"]/*'/>

    Disable = 0x1,

    /// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS.D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE"]/*'/>

    Enable = 0x2,

    /// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS.D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR"]/*'/>

    Clear = 0x4,
}
