// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DESCRIPTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_DESC"]/*'/>
public partial struct D3D12DescriptorHeapDesc
{
    /// <include file='D3D12_DESCRIPTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_DESC.Type"]/*'/>

    public D3D12DescriptorHeapType Type;

    /// <include file='D3D12_DESCRIPTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_DESC.NumDescriptors"]/*'/>

    public uint NumDescriptors;

    /// <include file='D3D12_DESCRIPTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_DESC.Flags"]/*'/>

    public D3D12DescriptorHeapFlags Flags;

    /// <include file='D3D12_DESCRIPTOR_HEAP_DESC.xml' path='doc/member[@name="D3D12_DESCRIPTOR_HEAP_DESC.NodeMask"]/*'/>

    public uint NodeMask;
}
