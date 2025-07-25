// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MULTIPLE_FENCE_WAIT_FLAGS.xml' path='doc/member[@name="D3D12_MULTIPLE_FENCE_WAIT_FLAGS"]/*'/>
[Flags]
public enum D3D12MultipleFenceWaitFlags
{
    /// <include file='D3D12_MULTIPLE_FENCE_WAIT_FLAGS.xml' path='doc/member[@name="D3D12_MULTIPLE_FENCE_WAIT_FLAGS.D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_MULTIPLE_FENCE_WAIT_FLAGS.xml' path='doc/member[@name="D3D12_MULTIPLE_FENCE_WAIT_FLAGS.D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY"]/*'/>

    Any = 0x1,

    /// <include file='D3D12_MULTIPLE_FENCE_WAIT_FLAGS.xml' path='doc/member[@name="D3D12_MULTIPLE_FENCE_WAIT_FLAGS.D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL"]/*'/>

    All = 0,
}
