// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D11_SB_OPERAND_MIN_PRECISION.xml' path='doc/member[@name="D3D11_SB_OPERAND_MIN_PRECISION"]/*'/>
public enum D3D11SbOperandMinPrecision
{
    /// <include file='D3D11_SB_OPERAND_MIN_PRECISION.xml' path='doc/member[@name="D3D11_SB_OPERAND_MIN_PRECISION.D3D11_SB_OPERAND_MIN_PRECISION_DEFAULT"]/*'/>

    Default = 0,

    /// <include file='D3D11_SB_OPERAND_MIN_PRECISION.xml' path='doc/member[@name="D3D11_SB_OPERAND_MIN_PRECISION.D3D11_SB_OPERAND_MIN_PRECISION_FLOAT_16"]/*'/>

    Float16 = 1,

    /// <include file='D3D11_SB_OPERAND_MIN_PRECISION.xml' path='doc/member[@name="D3D11_SB_OPERAND_MIN_PRECISION.D3D11_SB_OPERAND_MIN_PRECISION_FLOAT_2_8"]/*'/>

    Float2X8 = 2,

    /// <include file='D3D11_SB_OPERAND_MIN_PRECISION.xml' path='doc/member[@name="D3D11_SB_OPERAND_MIN_PRECISION.D3D11_SB_OPERAND_MIN_PRECISION_SINT_16"]/*'/>

    Sint16 = 4,

    /// <include file='D3D11_SB_OPERAND_MIN_PRECISION.xml' path='doc/member[@name="D3D11_SB_OPERAND_MIN_PRECISION.D3D11_SB_OPERAND_MIN_PRECISION_UINT_16"]/*'/>

    Uint16 = 5,
}
