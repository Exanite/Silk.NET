// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE"]/*'/>
public enum D3D10SbRegisterComponentType
{
    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_UINT32"]/*'/>

    Uint32 = 1,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_SINT32"]/*'/>

    Sint32 = 2,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_FLOAT32"]/*'/>

    Float32 = 3,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_UINT16"]/*'/>

    Uint16 = 4,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_SINT16"]/*'/>

    Sint16 = 5,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_FLOAT16"]/*'/>

    Float16 = 6,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_UINT64"]/*'/>

    Uint64 = 7,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_SINT64"]/*'/>

    Sint64 = 8,

    /// <include file='D3D10_SB_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D10_SB_REGISTER_COMPONENT_TYPE.D3D10_SB_REGISTER_COMPONENT_FLOAT64"]/*'/>

    Float64 = 9,
}
