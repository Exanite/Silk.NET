// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DESCRIPTOR_RANGE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE"]/*'/>
public partial struct D3D12DescriptorRange
{
    /// <include file='D3D12_DESCRIPTOR_RANGE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE.RangeType"]/*'/>

    public D3D12DescriptorRangeType RangeType;

    /// <include file='D3D12_DESCRIPTOR_RANGE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE.NumDescriptors"]/*'/>

    public uint NumDescriptors;

    /// <include file='D3D12_DESCRIPTOR_RANGE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE.BaseShaderRegister"]/*'/>

    public uint BaseShaderRegister;

    /// <include file='D3D12_DESCRIPTOR_RANGE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE.RegisterSpace"]/*'/>

    public uint RegisterSpace;

    /// <include file='D3D12_DESCRIPTOR_RANGE.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE.OffsetInDescriptorsFromTableStart"]/*'/>

    public uint OffsetInDescriptorsFromTableStart;
}
