// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS"]/*'/>
[Flags]
public enum D3D12HeapFlags
{
    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_SHARED"]/*'/>

    Shared = 0x1,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_DENY_BUFFERS"]/*'/>

    DenyBuffers = 0x4,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_DISPLAY"]/*'/>

    AllowDisplay = 0x8,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER"]/*'/>

    SharedCrossAdapter = 0x20,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES"]/*'/>

    DenyRtDsTextures = 0x40,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES"]/*'/>

    DenyNonRtDsTextures = 0x80,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_HARDWARE_PROTECTED"]/*'/>

    HardwareProtected = 0x100,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH"]/*'/>

    AllowWriteWatch = 0x200,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS"]/*'/>

    AllowShaderAtomics = 0x400,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_CREATE_NOT_RESIDENT"]/*'/>

    CreateNotResident = 0x800,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_CREATE_NOT_ZEROED"]/*'/>

    CreateNotZeroed = 0x1000,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_TOOLS_USE_MANUAL_WRITE_TRACKING"]/*'/>

    ToolsUseManualWriteTracking = 0x2000,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES"]/*'/>

    AllowAllBuffersAndTextures = 0,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS"]/*'/>

    AllowOnlyBuffers = 0xc0,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES"]/*'/>

    AllowOnlyNonRtDsTextures = 0x44,

    /// <include file='D3D12_HEAP_FLAGS.xml' path='doc/member[@name="D3D12_HEAP_FLAGS.D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES"]/*'/>

    AllowOnlyRtDsTextures = 0x84,
}
