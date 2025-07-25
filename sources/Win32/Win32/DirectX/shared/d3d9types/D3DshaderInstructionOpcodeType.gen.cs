// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE"]/*'/>
public enum D3DshaderInstructionOpcodeType
{
    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_NOP"]/*'/>

    Nop = 0,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MOV"]/*'/>

    Mov,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ADD"]/*'/>

    Add,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SUB"]/*'/>

    Sub,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MAD"]/*'/>

    Mad,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MUL"]/*'/>

    Mul,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RCP"]/*'/>

    Rcp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RSQ"]/*'/>

    Rsq,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DP3"]/*'/>

    DP3,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DP4"]/*'/>

    DP4,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MIN"]/*'/>

    Min,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MAX"]/*'/>

    Max,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SLT"]/*'/>

    Slt,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SGE"]/*'/>

    Sge,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_EXP"]/*'/>

    Exp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LOG"]/*'/>

    Log,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LIT"]/*'/>

    Lit,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DST"]/*'/>

    Dst,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LRP"]/*'/>

    Lrp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_FRC"]/*'/>

    Frc,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M4x4"]/*'/>

    M4X4,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M4x3"]/*'/>

    M4X3,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M3x4"]/*'/>

    M3X4,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M3x3"]/*'/>

    M3X3,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_M3x2"]/*'/>

    M3X2,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CALL"]/*'/>

    Call,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CALLNZ"]/*'/>

    Callnz,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LOOP"]/*'/>

    Loop,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RET"]/*'/>

    Ret,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ENDLOOP"]/*'/>

    Endloop,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LABEL"]/*'/>

    Label,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DCL"]/*'/>

    Dcl,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_POW"]/*'/>

    Pow,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CRS"]/*'/>

    Crs,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SGN"]/*'/>

    Sgn,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ABS"]/*'/>

    Abs,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_NRM"]/*'/>

    Nrm,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SINCOS"]/*'/>

    Sincos,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_REP"]/*'/>

    Rep,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ENDREP"]/*'/>

    Endrep,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_IF"]/*'/>

    If,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_IFC"]/*'/>

    Ifc,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ELSE"]/*'/>

    Else,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_ENDIF"]/*'/>

    Endif,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BREAK"]/*'/>

    Break,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BREAKC"]/*'/>

    Breakc,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_MOVA"]/*'/>

    Mova,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DEFB"]/*'/>

    Defb,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DEFI"]/*'/>

    Defi,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXCOORD"]/*'/>

    Texcoord = 64,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXKILL"]/*'/>

    Texkill,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEX"]/*'/>

    Tex,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXBEM"]/*'/>

    Texbem,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXBEML"]/*'/>

    Texbeml,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXREG2AR"]/*'/>

    Texreg2Ar,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXREG2GB"]/*'/>

    Texreg2Gb,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x2PAD"]/*'/>

    TEXM3X2PAD,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x2TEX"]/*'/>

    TEXM3X2TEX,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3PAD"]/*'/>

    TEXM3X3PAD,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3TEX"]/*'/>

    TEXM3X3TEX,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_RESERVED0"]/*'/>

    Reserved0,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3SPEC"]/*'/>

    TEXM3X3SPEC,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3VSPEC"]/*'/>

    TEXM3X3Vspec,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_EXPP"]/*'/>

    Expp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_LOGP"]/*'/>

    Logp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CND"]/*'/>

    Cnd,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DEF"]/*'/>

    Def,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXREG2RGB"]/*'/>

    Texreg2Rgb,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXDP3TEX"]/*'/>

    Texdp3Tex,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x2DEPTH"]/*'/>

    TEXM3X2Depth,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXDP3"]/*'/>

    Texdp3,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXM3x3"]/*'/>

    TEXM3X3,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXDEPTH"]/*'/>

    Texdepth,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_CMP"]/*'/>

    Cmp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BEM"]/*'/>

    Bem,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DP2ADD"]/*'/>

    Dp2Add,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DSX"]/*'/>

    Dsx,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_DSY"]/*'/>

    Dsy,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXLDD"]/*'/>

    Texldd,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_SETP"]/*'/>

    Setp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_TEXLDL"]/*'/>

    Texldl,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_BREAKP"]/*'/>

    Breakp,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_PHASE"]/*'/>

    Phase = 0xFFFD,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_COMMENT"]/*'/>

    Comment = 0xFFFE,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_END"]/*'/>

    End = 0xFFFF,

    /// <include file='D3DSHADER_INSTRUCTION_OPCODE_TYPE.xml' path='doc/member[@name="D3DSHADER_INSTRUCTION_OPCODE_TYPE.D3DSIO_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
