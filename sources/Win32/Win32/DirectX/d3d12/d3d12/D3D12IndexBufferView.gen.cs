// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW"]/*'/>
public partial struct D3D12IndexBufferView
{
    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.BufferLocation"]/*'/>

    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong BufferLocation;

    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.SizeInBytes"]/*'/>

    public uint SizeInBytes;

    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.Format"]/*'/>

    public DxgiFormat Format;
}
