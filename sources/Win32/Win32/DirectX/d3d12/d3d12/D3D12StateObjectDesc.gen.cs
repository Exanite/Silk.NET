// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC"]/*'/>
public unsafe partial struct D3D12StateObjectDesc
{
    /// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC.Type"]/*'/>

    public D3D12StateObjectType Type;

    /// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC.NumSubobjects"]/*'/>

    public uint NumSubobjects;

    /// <include file='D3D12_STATE_OBJECT_DESC.xml' path='doc/member[@name="D3D12_STATE_OBJECT_DESC.pSubobjects"]/*'/>

    [NativeTypeName("const D3D12_STATE_SUBOBJECT *")]
    public D3D12StateSubobject* PSubobjects;
}
