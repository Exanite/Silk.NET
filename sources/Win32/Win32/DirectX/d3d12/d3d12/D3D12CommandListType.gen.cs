// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE"]/*'/>
public enum D3D12CommandListType
{
    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_DIRECT"]/*'/>

    Direct = 0,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_BUNDLE"]/*'/>

    Bundle = 1,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_COMPUTE"]/*'/>

    Compute = 2,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_COPY"]/*'/>

    Copy = 3,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_VIDEO_DECODE"]/*'/>

    VideoDecode = 4,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_VIDEO_PROCESS"]/*'/>

    VideoProcess = 5,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_VIDEO_ENCODE"]/*'/>

    VideoEncode = 6,

    /// <include file='D3D12_COMMAND_LIST_TYPE.xml' path='doc/member[@name="D3D12_COMMAND_LIST_TYPE.D3D12_COMMAND_LIST_TYPE_NONE"]/*'/>

    None = -1,
}
