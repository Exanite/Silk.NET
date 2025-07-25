// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST"]/*'/>
public unsafe partial struct D3D12MemcpyDest
{
    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.pData"]/*'/>

    public void* PData;

    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.RowPitch"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint RowPitch;

    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.SlicePitch"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint SlicePitch;
}
