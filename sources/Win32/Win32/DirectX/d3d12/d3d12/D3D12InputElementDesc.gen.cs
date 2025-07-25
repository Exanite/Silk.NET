// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC"]/*'/>
public unsafe partial struct D3D12InputElementDesc
{
    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.SemanticName"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.SemanticIndex"]/*'/>

    public uint SemanticIndex;

    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.InputSlot"]/*'/>

    public uint InputSlot;

    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.AlignedByteOffset"]/*'/>

    public uint AlignedByteOffset;

    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.InputSlotClass"]/*'/>

    public D3D12InputClassification InputSlotClass;

    /// <include file='D3D12_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D3D12_INPUT_ELEMENT_DESC.InstanceDataStepRate"]/*'/>

    public uint InstanceDataStepRate;
}
