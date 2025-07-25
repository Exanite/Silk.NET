// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS"]/*'/>
[Flags]
public enum D3D12RldoFlags
{
    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_SUMMARY"]/*'/>

    Summary = 0x1,

    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_DETAIL"]/*'/>

    Detail = 0x2,

    /// <include file='D3D12_RLDO_FLAGS.xml' path='doc/member[@name="D3D12_RLDO_FLAGS.D3D12_RLDO_IGNORE_INTERNAL"]/*'/>

    IgnoreInternal = 0x4,
}
