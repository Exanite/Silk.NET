// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP"]/*'/>
public enum D3D12LogicOp
{
    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_CLEAR"]/*'/>

    Clear = 0,

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_SET"]/*'/>

    Set = (Clear + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_COPY"]/*'/>

    Copy = (Set + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_COPY_INVERTED"]/*'/>

    CopyInverted = (Copy + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_NOOP"]/*'/>

    Noop = (CopyInverted + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_INVERT"]/*'/>

    Invert = (Noop + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_AND"]/*'/>

    And = (Invert + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_NAND"]/*'/>

    Nand = (And + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_OR"]/*'/>

    Or = (Nand + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_NOR"]/*'/>

    Nor = (Or + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_XOR"]/*'/>

    Xor = (Nor + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_EQUIV"]/*'/>

    Equiv = (Xor + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_AND_REVERSE"]/*'/>

    AndReverse = (Equiv + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_AND_INVERTED"]/*'/>

    AndInverted = (AndReverse + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_OR_REVERSE"]/*'/>

    OrReverse = (AndInverted + 1),

    /// <include file='D3D12_LOGIC_OP.xml' path='doc/member[@name="D3D12_LOGIC_OP.D3D12_LOGIC_OP_OR_INVERTED"]/*'/>

    OrInverted = (OrReverse + 1),
}
