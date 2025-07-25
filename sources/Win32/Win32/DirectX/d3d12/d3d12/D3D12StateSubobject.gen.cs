// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATE_SUBOBJECT.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT"]/*'/>
public unsafe partial struct D3D12StateSubobject
{
    /// <include file='D3D12_STATE_SUBOBJECT.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT.Type"]/*'/>

    public D3D12StateSubobjectType Type;

    /// <include file='D3D12_STATE_SUBOBJECT.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT.pDesc"]/*'/>

    [NativeTypeName("const void *")]
    public void* PDesc;
}
