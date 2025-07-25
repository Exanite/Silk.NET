// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY"]/*'/>
public partial struct D3D12VideoProcessLumaKey
{
    /// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY.Enable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Enable;

    /// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY.Lower"]/*'/>

    public float Lower;

    /// <include file='D3D12_VIDEO_PROCESS_LUMA_KEY.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUMA_KEY.Upper"]/*'/>

    public float Upper;
}
