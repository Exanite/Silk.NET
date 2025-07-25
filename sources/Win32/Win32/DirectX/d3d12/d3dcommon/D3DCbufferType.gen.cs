// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE"]/*'/>
public enum D3DCbufferType
{
    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D_CT_CBUFFER"]/*'/>

    DCtCbuffer = 0,

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D_CT_TBUFFER"]/*'/>

    DCtTbuffer = (DCtCbuffer + 1),

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D_CT_INTERFACE_POINTERS"]/*'/>

    DCtInterfacePointers = (DCtTbuffer + 1),

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D_CT_RESOURCE_BIND_INFO"]/*'/>

    DCtResourceBindInfo = (DCtInterfacePointers + 1),

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D10_CT_CBUFFER"]/*'/>

    D10CtCbuffer = DCtCbuffer,

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D10_CT_TBUFFER"]/*'/>

    D10CtTbuffer = DCtTbuffer,

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D11_CT_CBUFFER"]/*'/>

    D11CtCbuffer = DCtCbuffer,

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D11_CT_TBUFFER"]/*'/>

    D11CtTbuffer = DCtTbuffer,

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D11_CT_INTERFACE_POINTERS"]/*'/>

    D11CtInterfacePointers = DCtInterfacePointers,

    /// <include file='D3D_CBUFFER_TYPE.xml' path='doc/member[@name="D3D_CBUFFER_TYPE.D3D11_CT_RESOURCE_BIND_INFO"]/*'/>

    D11CtResourceBindInfo = DCtResourceBindInfo,
}
