// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER"]/*'/>
public enum D3D10SbOperandModifier
{
    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_NONE"]/*'/>

    None = 0,

    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_NEG"]/*'/>

    Neg = 1,

    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_ABS"]/*'/>

    Abs = 2,

    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_ABSNEG"]/*'/>

    Absneg = 3,
}
