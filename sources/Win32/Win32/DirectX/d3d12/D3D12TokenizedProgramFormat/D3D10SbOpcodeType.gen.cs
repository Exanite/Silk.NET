// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE"]/*'/>
public enum D3D10SbOpcodeType
{
    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ADD"]/*'/>

    D10SbOpcodeAdd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_AND"]/*'/>

    D10SbOpcodeAnd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_BREAK"]/*'/>

    D10SbOpcodeBreak,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_BREAKC"]/*'/>

    D10SbOpcodeBreakc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CALL"]/*'/>

    D10SbOpcodeCall,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CALLC"]/*'/>

    D10SbOpcodeCallc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CASE"]/*'/>

    D10SbOpcodeCase,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CONTINUE"]/*'/>

    D10SbOpcodeContinue,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CONTINUEC"]/*'/>

    D10SbOpcodeContinuec,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CUT"]/*'/>

    D10SbOpcodeCut,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DEFAULT"]/*'/>

    D10SbOpcodeDefault,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DERIV_RTX"]/*'/>

    D10SbOpcodeDerivRtx,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DERIV_RTY"]/*'/>

    D10SbOpcodeDerivRty,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DISCARD"]/*'/>

    D10SbOpcodeDiscard,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DIV"]/*'/>

    D10SbOpcodeDiv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DP2"]/*'/>

    D10SbOpcodeDp2,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DP3"]/*'/>

    D10SbOpcodeDp3,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DP4"]/*'/>

    D10SbOpcodeDp4,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ELSE"]/*'/>

    D10SbOpcodeElse,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EMIT"]/*'/>

    D10SbOpcodeEmit,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EMITTHENCUT"]/*'/>

    D10SbOpcodeEmitthencut,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ENDIF"]/*'/>

    D10SbOpcodeEndif,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ENDLOOP"]/*'/>

    D10SbOpcodeEndloop,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ENDSWITCH"]/*'/>

    D10SbOpcodeEndswitch,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EQ"]/*'/>

    D10SbOpcodeEq,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EXP"]/*'/>

    D10SbOpcodeExp,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_FRC"]/*'/>

    D10SbOpcodeFrc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_FTOI"]/*'/>

    D10SbOpcodeFtoi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_FTOU"]/*'/>

    D10SbOpcodeFtou,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_GE"]/*'/>

    D10SbOpcodeGe,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IADD"]/*'/>

    D10SbOpcodeIadd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IF"]/*'/>

    D10SbOpcodeIf,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IEQ"]/*'/>

    D10SbOpcodeIeq,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IGE"]/*'/>

    D10SbOpcodeIge,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ILT"]/*'/>

    D10SbOpcodeIlt,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMAD"]/*'/>

    D10SbOpcodeImad,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMAX"]/*'/>

    D10SbOpcodeImax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMIN"]/*'/>

    D10SbOpcodeImin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMUL"]/*'/>

    D10SbOpcodeImul,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_INE"]/*'/>

    D10SbOpcodeIne,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_INEG"]/*'/>

    D10SbOpcodeIneg,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ISHL"]/*'/>

    D10SbOpcodeIshl,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ISHR"]/*'/>

    D10SbOpcodeIshr,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ITOF"]/*'/>

    D10SbOpcodeItof,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LABEL"]/*'/>

    D10SbOpcodeLabel,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LD"]/*'/>

    D10SbOpcodeLd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LD_MS"]/*'/>

    D10SbOpcodeLdMs,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LOG"]/*'/>

    D10SbOpcodeLog,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LOOP"]/*'/>

    D10SbOpcodeLoop,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LT"]/*'/>

    D10SbOpcodeLt,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MAD"]/*'/>

    D10SbOpcodeMad,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MIN"]/*'/>

    D10SbOpcodeMin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MAX"]/*'/>

    D10SbOpcodeMax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CUSTOMDATA"]/*'/>

    D10SbOpcodeCustomdata,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MOV"]/*'/>

    D10SbOpcodeMov,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MOVC"]/*'/>

    D10SbOpcodeMovc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MUL"]/*'/>

    D10SbOpcodeMul,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_NE"]/*'/>

    D10SbOpcodeNe,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_NOP"]/*'/>

    D10SbOpcodeNop,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_NOT"]/*'/>

    D10SbOpcodeNot,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_OR"]/*'/>

    D10SbOpcodeOr,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RESINFO"]/*'/>

    D10SbOpcodeResinfo,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RET"]/*'/>

    D10SbOpcodeRet,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RETC"]/*'/>

    D10SbOpcodeRetc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_NE"]/*'/>

    D10SbOpcodeRoundNe,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_NI"]/*'/>

    D10SbOpcodeRoundNi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_PI"]/*'/>

    D10SbOpcodeRoundPi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_Z"]/*'/>

    D10SbOpcodeRoundZ,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RSQ"]/*'/>

    D10SbOpcodeRsq,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE"]/*'/>

    D10SbOpcodeSample,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_C"]/*'/>

    D10SbOpcodeSampleC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_C_LZ"]/*'/>

    D10SbOpcodeSampleCLz,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_L"]/*'/>

    D10SbOpcodeSampleL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_D"]/*'/>

    D10SbOpcodeSampleD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_B"]/*'/>

    D10SbOpcodeSampleB,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SQRT"]/*'/>

    D10SbOpcodeSqrt,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SWITCH"]/*'/>

    D10SbOpcodeSwitch,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SINCOS"]/*'/>

    D10SbOpcodeSincos,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UDIV"]/*'/>

    D10SbOpcodeUdiv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ULT"]/*'/>

    D10SbOpcodeUlt,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UGE"]/*'/>

    D10SbOpcodeUge,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMUL"]/*'/>

    D10SbOpcodeUmul,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMAD"]/*'/>

    D10SbOpcodeUmad,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMAX"]/*'/>

    D10SbOpcodeUmax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMIN"]/*'/>

    D10SbOpcodeUmin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_USHR"]/*'/>

    D10SbOpcodeUshr,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UTOF"]/*'/>

    D10SbOpcodeUtof,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_XOR"]/*'/>

    D10SbOpcodeXor,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_RESOURCE"]/*'/>

    D10SbOpcodeDclResource,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_CONSTANT_BUFFER"]/*'/>

    D10SbOpcodeDclConstantBuffer,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_SAMPLER"]/*'/>

    D10SbOpcodeDclSampler,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INDEX_RANGE"]/*'/>

    D10SbOpcodeDclIndexRange,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_GS_OUTPUT_PRIMITIVE_TOPOLOGY"]/*'/>

    D10SbOpcodeDclGsOutputPrimitiveTopology,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_GS_INPUT_PRIMITIVE"]/*'/>

    D10SbOpcodeDclGsInputPrimitive,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_MAX_OUTPUT_VERTEX_COUNT"]/*'/>

    D10SbOpcodeDclMaxOutputVertexCount,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT"]/*'/>

    D10SbOpcodeDclInput,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_SGV"]/*'/>

    D10SbOpcodeDclInputSgv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_SIV"]/*'/>

    D10SbOpcodeDclInputSiv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_PS"]/*'/>

    D10SbOpcodeDclInputPs,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_PS_SGV"]/*'/>

    D10SbOpcodeDclInputPsSgv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_PS_SIV"]/*'/>

    D10SbOpcodeDclInputPsSiv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_OUTPUT"]/*'/>

    D10SbOpcodeDclOutput,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_OUTPUT_SGV"]/*'/>

    D10SbOpcodeDclOutputSgv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_OUTPUT_SIV"]/*'/>

    D10SbOpcodeDclOutputSiv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_TEMPS"]/*'/>

    D10SbOpcodeDclTemps,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INDEXABLE_TEMP"]/*'/>

    D10SbOpcodeDclIndexableTemp,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_GLOBAL_FLAGS"]/*'/>

    D10SbOpcodeDclGlobalFlags,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RESERVED0"]/*'/>

    D10SbOpcodeReserved0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_LOD"]/*'/>

    D10X1SbOpcodeLod,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_GATHER4"]/*'/>

    D10X1SbOpcodeGather4,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_SAMPLE_POS"]/*'/>

    D10X1SbOpcodeSamplePos,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_SAMPLE_INFO"]/*'/>

    D10X1SbOpcodeSampleInfo,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_RESERVED1"]/*'/>

    D10X1SbOpcodeReserved1,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_DECLS"]/*'/>

    D11SbOpcodeHsDecls,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_CONTROL_POINT_PHASE"]/*'/>

    D11SbOpcodeHsControlPointPhase,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_FORK_PHASE"]/*'/>

    D11SbOpcodeHsForkPhase,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_JOIN_PHASE"]/*'/>

    D11SbOpcodeHsJoinPhase,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EMIT_STREAM"]/*'/>

    D11SbOpcodeEmitStream,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_CUT_STREAM"]/*'/>

    D11SbOpcodeCutStream,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EMITTHENCUT_STREAM"]/*'/>

    D11SbOpcodeEmitthencutStream,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_INTERFACE_CALL"]/*'/>

    D11SbOpcodeInterfaceCall,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_BUFINFO"]/*'/>

    D11SbOpcodeBufinfo,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTX_COARSE"]/*'/>

    D11SbOpcodeDerivRtxCoarse,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTX_FINE"]/*'/>

    D11SbOpcodeDerivRtxFine,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTY_COARSE"]/*'/>

    D11SbOpcodeDerivRtyCoarse,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTY_FINE"]/*'/>

    D11SbOpcodeDerivRtyFine,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_GATHER4_C"]/*'/>

    D11SbOpcodeGather4C,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_GATHER4_PO"]/*'/>

    D11SbOpcodeGather4Po,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_GATHER4_PO_C"]/*'/>

    D11SbOpcodeGather4PoC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_RCP"]/*'/>

    D11SbOpcodeRcp,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_F32TOF16"]/*'/>

    D11SbOpcodeF32Tof16,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_F16TOF32"]/*'/>

    D11SbOpcodeF16Tof32,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_UADDC"]/*'/>

    D11SbOpcodeUaddc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_USUBB"]/*'/>

    D11SbOpcodeUsubb,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_COUNTBITS"]/*'/>

    D11SbOpcodeCountbits,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FIRSTBIT_HI"]/*'/>

    D11SbOpcodeFirstbitHi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FIRSTBIT_LO"]/*'/>

    D11SbOpcodeFirstbitLo,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FIRSTBIT_SHI"]/*'/>

    D11SbOpcodeFirstbitShi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_UBFE"]/*'/>

    D11SbOpcodeUbfe,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IBFE"]/*'/>

    D11SbOpcodeIbfe,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_BFI"]/*'/>

    D11SbOpcodeBfi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_BFREV"]/*'/>

    D11SbOpcodeBfrev,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_SWAPC"]/*'/>

    D11SbOpcodeSwapc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_STREAM"]/*'/>

    D11SbOpcodeDclStream,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_FUNCTION_BODY"]/*'/>

    D11SbOpcodeDclFunctionBody,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_FUNCTION_TABLE"]/*'/>

    D11SbOpcodeDclFunctionTable,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_INTERFACE"]/*'/>

    D11SbOpcodeDclInterface,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_INPUT_CONTROL_POINT_COUNT"]/*'/>

    D11SbOpcodeDclInputControlPointCount,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_OUTPUT_CONTROL_POINT_COUNT"]/*'/>

    D11SbOpcodeDclOutputControlPointCount,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_TESS_DOMAIN"]/*'/>

    D11SbOpcodeDclTessDomain,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_TESS_PARTITIONING"]/*'/>

    D11SbOpcodeDclTessPartitioning,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_TESS_OUTPUT_PRIMITIVE"]/*'/>

    D11SbOpcodeDclTessOutputPrimitive,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_HS_MAX_TESSFACTOR"]/*'/>

    D11SbOpcodeDclHsMaxTessfactor,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_HS_FORK_PHASE_INSTANCE_COUNT"]/*'/>

    D11SbOpcodeDclHsForkPhaseInstanceCount,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_HS_JOIN_PHASE_INSTANCE_COUNT"]/*'/>

    D11SbOpcodeDclHsJoinPhaseInstanceCount,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_THREAD_GROUP"]/*'/>

    D11SbOpcodeDclThreadGroup,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_TYPED"]/*'/>

    D11SbOpcodeDclUnorderedAccessViewTyped,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_RAW"]/*'/>

    D11SbOpcodeDclUnorderedAccessViewRaw,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_STRUCTURED"]/*'/>

    D11SbOpcodeDclUnorderedAccessViewStructured,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_THREAD_GROUP_SHARED_MEMORY_RAW"]/*'/>

    D11SbOpcodeDclThreadGroupSharedMemoryRaw,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_THREAD_GROUP_SHARED_MEMORY_STRUCTURED"]/*'/>

    D11SbOpcodeDclThreadGroupSharedMemoryStructured,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_RESOURCE_RAW"]/*'/>

    D11SbOpcodeDclResourceRaw,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_RESOURCE_STRUCTURED"]/*'/>

    D11SbOpcodeDclResourceStructured,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_LD_UAV_TYPED"]/*'/>

    D11SbOpcodeLdUavTyped,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_STORE_UAV_TYPED"]/*'/>

    D11SbOpcodeStoreUavTyped,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_LD_RAW"]/*'/>

    D11SbOpcodeLdRaw,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_STORE_RAW"]/*'/>

    D11SbOpcodeStoreRaw,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_LD_STRUCTURED"]/*'/>

    D11SbOpcodeLdStructured,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_STORE_STRUCTURED"]/*'/>

    D11SbOpcodeStoreStructured,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_AND"]/*'/>

    D11SbOpcodeAtomicAnd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_OR"]/*'/>

    D11SbOpcodeAtomicOr,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_XOR"]/*'/>

    D11SbOpcodeAtomicXor,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_CMP_STORE"]/*'/>

    D11SbOpcodeAtomicCmpStore,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_IADD"]/*'/>

    D11SbOpcodeAtomicIadd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_IMAX"]/*'/>

    D11SbOpcodeAtomicImax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_IMIN"]/*'/>

    D11SbOpcodeAtomicImin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_UMAX"]/*'/>

    D11SbOpcodeAtomicUmax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_UMIN"]/*'/>

    D11SbOpcodeAtomicUmin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_ALLOC"]/*'/>

    D11SbOpcodeImmAtomicAlloc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_CONSUME"]/*'/>

    D11SbOpcodeImmAtomicConsume,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_IADD"]/*'/>

    D11SbOpcodeImmAtomicIadd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_AND"]/*'/>

    D11SbOpcodeImmAtomicAnd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_OR"]/*'/>

    D11SbOpcodeImmAtomicOr,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_XOR"]/*'/>

    D11SbOpcodeImmAtomicXor,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_EXCH"]/*'/>

    D11SbOpcodeImmAtomicExch,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_CMP_EXCH"]/*'/>

    D11SbOpcodeImmAtomicCmpExch,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_IMAX"]/*'/>

    D11SbOpcodeImmAtomicImax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_IMIN"]/*'/>

    D11SbOpcodeImmAtomicImin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_UMAX"]/*'/>

    D11SbOpcodeImmAtomicUmax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_UMIN"]/*'/>

    D11SbOpcodeImmAtomicUmin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_SYNC"]/*'/>

    D11SbOpcodeSync,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DADD"]/*'/>

    D11SbOpcodeDadd,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMAX"]/*'/>

    D11SbOpcodeDmax,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMIN"]/*'/>

    D11SbOpcodeDmin,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMUL"]/*'/>

    D11SbOpcodeDmul,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DEQ"]/*'/>

    D11SbOpcodeDeq,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DGE"]/*'/>

    D11SbOpcodeDge,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DLT"]/*'/>

    D11SbOpcodeDlt,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DNE"]/*'/>

    D11SbOpcodeDne,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMOV"]/*'/>

    D11SbOpcodeDmov,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMOVC"]/*'/>

    D11SbOpcodeDmovc,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DTOF"]/*'/>

    D11SbOpcodeDtof,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FTOD"]/*'/>

    D11SbOpcodeFtod,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EVAL_SNAPPED"]/*'/>

    D11SbOpcodeEvalSnapped,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EVAL_SAMPLE_INDEX"]/*'/>

    D11SbOpcodeEvalSampleIndex,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EVAL_CENTROID"]/*'/>

    D11SbOpcodeEvalCentroid,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_GS_INSTANCE_COUNT"]/*'/>

    D11SbOpcodeDclGsInstanceCount,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ABORT"]/*'/>

    D11SbOpcodeAbort,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DEBUG_BREAK"]/*'/>

    D11SbOpcodeDebugBreak,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_RESERVED0"]/*'/>

    D11SbOpcodeReserved0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DDIV"]/*'/>

    D11X1SbOpcodeDdiv,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DFMA"]/*'/>

    D11X1SbOpcodeDfma,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DRCP"]/*'/>

    D11X1SbOpcodeDrcp,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_MSAD"]/*'/>

    D11X1SbOpcodeMsad,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DTOI"]/*'/>

    D11X1SbOpcodeDtoi,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DTOU"]/*'/>

    D11X1SbOpcodeDtou,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_ITOD"]/*'/>

    D11X1SbOpcodeItod,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_UTOD"]/*'/>

    D11X1SbOpcodeUtod,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_RESERVED0"]/*'/>

    D11X1SbOpcodeReserved0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeGather4Feedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_C_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeGather4CFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_PO_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeGather4PoFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_PO_C_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeGather4PoCFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeLdFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_MS_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeLdMsFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_UAV_TYPED_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeLdUavTypedFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_RAW_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeLdRawFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_STRUCTURED_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeLdStructuredFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_L_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeSampleLFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_C_LZ_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeSampleCLzFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_CLAMP_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeSampleClampFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_B_CLAMP_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeSampleBClampFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_D_CLAMP_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeSampleDClampFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_C_CLAMP_FEEDBACK"]/*'/>

    Dwddm1X3SbOpcodeSampleCClampFeedback,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_CHECK_ACCESS_FULLY_MAPPED"]/*'/>

    Dwddm1X3SbOpcodeCheckAccessFullyMapped,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_RESERVED0"]/*'/>

    Dwddm1X3SbOpcodeReserved0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_NUM_OPCODES"]/*'/>

    D10SbNumOpcodes,
}
