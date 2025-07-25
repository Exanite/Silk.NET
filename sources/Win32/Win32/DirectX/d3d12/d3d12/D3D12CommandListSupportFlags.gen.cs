// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum D3D12CommandListSupportFlags
{
    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT"]/*'/>

    Direct = (1 << D3D12CommandListType.Direct),

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE"]/*'/>

    Bundle = (1 << D3D12CommandListType.Bundle),

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE"]/*'/>

    Compute = (1 << D3D12CommandListType.Compute),

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY"]/*'/>

    Copy = (1 << D3D12CommandListType.Copy),

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE"]/*'/>

    VideoDecode = (1 << D3D12CommandListType.VideoDecode),

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS"]/*'/>

    VideoProcess = (1 << D3D12CommandListType.VideoProcess),

    /// <include file='D3D12_COMMAND_LIST_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_COMMAND_LIST_SUPPORT_FLAGS.D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE"]/*'/>

    VideoEncode = (1 << D3D12CommandListType.VideoEncode),
}
