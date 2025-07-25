// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE"]/*'/>
public enum D3D10SbExtendedOpcodeType
{
    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D10_SB_EXTENDED_OPCODE_EMPTY"]/*'/>

    X10SbExtendedOpcodeEmpty = 0,

    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D10_SB_EXTENDED_OPCODE_SAMPLE_CONTROLS"]/*'/>

    X10SbExtendedOpcodeSampleControls = 1,

    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D11_SB_EXTENDED_OPCODE_RESOURCE_DIM"]/*'/>

    X11SbExtendedOpcodeResourceDim = 2,

    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D11_SB_EXTENDED_OPCODE_RESOURCE_RETURN_TYPE"]/*'/>

    X11SbExtendedOpcodeResourceReturnType = 3,
}
