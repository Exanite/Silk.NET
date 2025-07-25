// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT"]/*'/>
public unsafe partial struct D3D12VideoDecodeFrameArgument
{
    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.Type"]/*'/>

    public D3D12VideoDecodeArgumentType Type;

    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.Size"]/*'/>

    public uint Size;

    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.pData"]/*'/>

    public void* PData;
}
