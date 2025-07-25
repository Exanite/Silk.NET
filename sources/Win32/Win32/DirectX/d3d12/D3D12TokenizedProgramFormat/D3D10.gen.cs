// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D10
{
    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_TYPE_MASK 0xffff0000")]
    public const uint SbTokenizedProgramTypeMask = 0xffff0000;

    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_TYPE_SHIFT 16")]
    public const int SbTokenizedProgramTypeShift = 16;

    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_MASK 0x000000f0")]
    public const int SbTokenizedProgramMajorVersionMask = 0x000000f0;

    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_SHIFT 4")]
    public const int SbTokenizedProgramMajorVersionShift = 4;

    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION_MASK 0x0000000f")]
    public const int SbTokenizedProgramMinorVersionMask = 0x0000000f;

    [NativeTypeName("#define D3D10_SB_OPCODE_TYPE_MASK 0x00007ff")]
    public const int SbOpcodeTypeMask = 0x00007ff;

    [NativeTypeName("#define D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_MASK 0x7f000000")]
    public const int SbTokenizedInstructionLengthMask = 0x7f000000;

    [NativeTypeName("#define D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_SHIFT 24")]
    public const int SbTokenizedInstructionLengthShift = 24;

    [NativeTypeName("#define D3D10_SB_INSTRUCTION_SATURATE_MASK 0x00002000")]
    public const int SbInstructionSaturateMask = 0x00002000;

    [NativeTypeName("#define D3D10_SB_INSTRUCTION_TEST_BOOLEAN_MASK 0x00040000")]
    public const int SbInstructionTestBooleanMask = 0x00040000;

    [NativeTypeName("#define D3D10_SB_INSTRUCTION_TEST_BOOLEAN_SHIFT 18")]
    public const int SbInstructionTestBooleanShift = 18;

    [NativeTypeName("#define D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_MASK 0x00001800")]
    public const int SbResinfoInstructionReturnTypeMask = 0x00001800;

    [NativeTypeName("#define D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_SHIFT 11")]
    public const int SbResinfoInstructionReturnTypeShift = 11;

    [NativeTypeName("#define D3D10_SB_OPCODE_EXTENDED_MASK 0x80000000")]
    public const uint SbOpcodeExtendedMask = 0x80000000;

    [NativeTypeName("#define D3D10_SB_OPCODE_EXTENDED_SHIFT 31")]
    public const int SbOpcodeExtendedShift = 31;

    [NativeTypeName("#define D3D10_SB_EXTENDED_OPCODE_TYPE_MASK 0x0000003f")]
    public const int SbExtendedOpcodeTypeMask = 0x0000003f;

    [NativeTypeName("#define D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_COORD_MASK (3)")]
    public const int SbImmediateAddressOffsetCoordMask = (3);

    [NativeTypeName("#define D3D10_SB_RESOURCE_RETURN_TYPE_MASK 0x0000000f")]
    public const int SbResourceReturnTypeMask = 0x0000000f;

    [NativeTypeName("#define D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS 0x00000004")]
    public const int SbResourceReturnTypeNumbits = 0x00000004;

    [NativeTypeName("#define D3D10_SB_CUSTOMDATA_CLASS_MASK 0xfffff800")]
    public const uint SbCustomdataClassMask = 0xfffff800;

    [NativeTypeName("#define D3D10_SB_CUSTOMDATA_CLASS_SHIFT 11")]
    public const int SbCustomdataClassShift = 11;

    [NativeTypeName("#define D3D10_SB_OPERAND_NUM_COMPONENTS_MASK 0x00000003")]
    public const int SbOperandNumComponentsMask = 0x00000003;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_MASK 0x0000000c")]
    public const int SbOperand4ComponentSelectionModeMask = 0x0000000c;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_SHIFT 2")]
    public const int SbOperand4ComponentSelectionModeShift = 2;

    [NativeTypeName("#define D3D10_SB_4_COMPONENT_NAME_MASK 3")]
    public const int Sb4ComponentNameMask = 3;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK 0x000000f0")]
    public const int SbOperand4ComponentMaskMask = 0x000000f0;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_SHIFT 4")]
    public const int SbOperand4ComponentMaskShift = 4;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_X 0x00000010")]
    public const int SbOperand4ComponentMaskX = 0x00000010;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_Y 0x00000020")]
    public const int SbOperand4ComponentMaskY = 0x00000020;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_Z 0x00000040")]
    public const int SbOperand4ComponentMaskZ = 0x00000040;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_W 0x00000080")]
    public const int SbOperand4ComponentMaskW = 0x00000080;

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_MASK_R D3D10_SB_OPERAND_4_COMPONENT_MASK_X"
    )]
    public const int SbOperand4ComponentMaskR = 0x00000010;

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_MASK_G D3D10_SB_OPERAND_4_COMPONENT_MASK_Y"
    )]
    public const int SbOperand4ComponentMaskG = 0x00000020;

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_MASK_B D3D10_SB_OPERAND_4_COMPONENT_MASK_Z"
    )]
    public const int SbOperand4ComponentMaskB = 0x00000040;

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_MASK_A D3D10_SB_OPERAND_4_COMPONENT_MASK_W"
    )]
    public const int SbOperand4ComponentMaskA = 0x00000080;

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_MASK_ALL D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK"
    )]
    public const int SbOperand4ComponentMaskAll = 0x000000f0;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MASK 0x00000ff0")]
    public const int SbOperand4ComponentSwizzleMask = 0x00000ff0;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SHIFT 4")]
    public const int SbOperand4ComponentSwizzleShift = 4;

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_NOSWIZZLE ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_X,\\\n                                                                                   D3D10_SB_4_COMPONENT_Y,\\\n                                                                                   D3D10_SB_4_COMPONENT_Z,\\\n                                                                                   D3D10_SB_4_COMPONENT_W)"
    )]
    public const int SbOperand4ComponentNoswizzle = (
        (
            ((int)(D3D10Sb4ComponentName.X) & 3)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEX ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_X,\\\n                                                                                   D3D10_SB_4_COMPONENT_X,\\\n                                                                                   D3D10_SB_4_COMPONENT_X,\\\n                                                                                   D3D10_SB_4_COMPONENT_X)"
    )]
    public const int SbOperand4ComponentReplicatex = (
        (
            ((int)(D3D10Sb4ComponentName.X) & 3)
            | (((int)(D3D10Sb4ComponentName.X) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.X) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.X) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEY ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_Y,\\\n                                                                                   D3D10_SB_4_COMPONENT_Y,\\\n                                                                                   D3D10_SB_4_COMPONENT_Y,\\\n                                                                                   D3D10_SB_4_COMPONENT_Y)"
    )]
    public const int SbOperand4ComponentReplicatey = (
        (
            ((int)(D3D10Sb4ComponentName.Y) & 3)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEZ ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_Z,\\\n                                                                                   D3D10_SB_4_COMPONENT_Z,\\\n                                                                                   D3D10_SB_4_COMPONENT_Z,\\\n                                                                                   D3D10_SB_4_COMPONENT_Z)"
    )]
    public const int SbOperand4ComponentReplicatez = (
        (
            ((int)(D3D10Sb4ComponentName.Z) & 3)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEW ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_W,\\\n                                                                                   D3D10_SB_4_COMPONENT_W,\\\n                                                                                   D3D10_SB_4_COMPONENT_W,\\\n                                                                                   D3D10_SB_4_COMPONENT_W)"
    )]
    public const int SbOperand4ComponentReplicatew = (
        (
            ((int)(D3D10Sb4ComponentName.W) & 3)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATERED D3D10_SB_OPERAND_4_COMPONENT_REPLICATEX"
    )]
    public const int SbOperand4ComponentReplicatered = (
        (
            ((int)(D3D10Sb4ComponentName.X) & 3)
            | (((int)(D3D10Sb4ComponentName.X) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.X) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.X) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEGREEN D3D10_SB_OPERAND_4_COMPONENT_REPLICATEY"
    )]
    public const int SbOperand4ComponentReplicategreen = (
        (
            ((int)(D3D10Sb4ComponentName.Y) & 3)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.Y) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEBLUE D3D10_SB_OPERAND_4_COMPONENT_REPLICATEZ"
    )]
    public const int SbOperand4ComponentReplicateblue = (
        (
            ((int)(D3D10Sb4ComponentName.Z) & 3)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.Z) & 3) << 6)
        ) << 4
    );

    [NativeTypeName(
        "#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEALPHA D3D10_SB_OPERAND_4_COMPONENT_REPLICATEW"
    )]
    public const int SbOperand4ComponentReplicatealpha = (
        (
            ((int)(D3D10Sb4ComponentName.W) & 3)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 2)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 4)
            | (((int)(D3D10Sb4ComponentName.W) & 3) << 6)
        ) << 4
    );

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MASK 0x00000030")]
    public const int SbOperand4ComponentSelect1Mask = 0x00000030;

    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_SHIFT 4")]
    public const int SbOperand4ComponentSelect1Shift = 4;

    [NativeTypeName("#define D3D10_SB_OPERAND_TYPE_MASK 0x000ff000")]
    public const int SbOperandTypeMask = 0x000ff000;

    [NativeTypeName("#define D3D10_SB_OPERAND_TYPE_SHIFT 12")]
    public const int SbOperandTypeShift = 12;

    [NativeTypeName("#define D3D10_SB_OPERAND_INDEX_DIMENSION_MASK 0x00300000")]
    public const int SbOperandIndexDimensionMask = 0x00300000;

    [NativeTypeName("#define D3D10_SB_OPERAND_INDEX_DIMENSION_SHIFT 20")]
    public const int SbOperandIndexDimensionShift = 20;

    [NativeTypeName("#define D3D10_SB_OPERAND_EXTENDED_MASK 0x80000000")]
    public const uint SbOperandExtendedMask = 0x80000000;

    [NativeTypeName("#define D3D10_SB_OPERAND_EXTENDED_SHIFT 31")]
    public const int SbOperandExtendedShift = 31;

    [NativeTypeName("#define D3D10_SB_EXTENDED_OPERAND_TYPE_MASK 0x0000003f")]
    public const int SbExtendedOperandTypeMask = 0x0000003f;

    [NativeTypeName("#define D3D10_SB_OPERAND_MODIFIER_MASK 0x00003fc0")]
    public const int SbOperandModifierMask = 0x00003fc0;

    [NativeTypeName("#define D3D10_SB_OPERAND_MODIFIER_SHIFT 6")]
    public const int SbOperandModifierShift = 6;

    [NativeTypeName("#define D3D10_SB_OPERAND_DOUBLE_EXTENDED_MASK 0x80000000")]
    public const uint SbOperandDoubleExtendedMask = 0x80000000;

    [NativeTypeName("#define D3D10_SB_OPERAND_DOUBLE_EXTENDED_SHIFT 31")]
    public const int SbOperandDoubleExtendedShift = 31;

    [NativeTypeName("#define D3D10_SB_NAME_MASK 0x0000ffff")]
    public const int SbNameMask = 0x0000ffff;

    [NativeTypeName("#define D3D10_SB_GLOBAL_FLAG_REFACTORING_ALLOWED (1<<11)")]
    public const int SbGlobalFlagRefactoringAllowed = (1 << 11);

    [NativeTypeName("#define D3D10_SB_GLOBAL_FLAGS_MASK 0x00fff800")]
    public const int SbGlobalFlagsMask = 0x00fff800;

    [NativeTypeName("#define D3D10_SB_RESOURCE_DIMENSION_MASK 0x0000F800")]
    public const int SbResourceDimensionMask = 0x0000F800;

    [NativeTypeName("#define D3D10_SB_RESOURCE_DIMENSION_SHIFT 11")]
    public const int SbResourceDimensionShift = 11;

    [NativeTypeName("#define D3D10_SB_RESOURCE_SAMPLE_COUNT_MASK 0x07F0000")]
    public const int SbResourceSampleCountMask = 0x07F0000;

    [NativeTypeName("#define D3D10_SB_RESOURCE_SAMPLE_COUNT_SHIFT 16")]
    public const int SbResourceSampleCountShift = 16;

    [NativeTypeName("#define D3D10_SB_SAMPLER_MODE_MASK 0x00007800")]
    public const int SbSamplerModeMask = 0x00007800;

    [NativeTypeName("#define D3D10_SB_SAMPLER_MODE_SHIFT 11")]
    public const int SbSamplerModeShift = 11;

    [NativeTypeName("#define D3D10_SB_INPUT_INTERPOLATION_MODE_MASK 0x00007800")]
    public const int SbInputInterpolationModeMask = 0x00007800;

    [NativeTypeName("#define D3D10_SB_INPUT_INTERPOLATION_MODE_SHIFT 11")]
    public const int SbInputInterpolationModeShift = 11;

    [NativeTypeName("#define D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_MASK 0x00000800")]
    public const int SbConstantBufferAccessPatternMask = 0x00000800;

    [NativeTypeName("#define D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_SHIFT 11")]
    public const int SbConstantBufferAccessPatternShift = 11;

    [NativeTypeName("#define D3D10_SB_GS_INPUT_PRIMITIVE_MASK 0x0001f800")]
    public const int SbGsInputPrimitiveMask = 0x0001f800;

    [NativeTypeName("#define D3D10_SB_GS_INPUT_PRIMITIVE_SHIFT 11")]
    public const int SbGsInputPrimitiveShift = 11;

    [NativeTypeName("#define D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_MASK 0x0001f800")]
    public const int SbGsOutputPrimitiveTopologyMask = 0x0001f800;

    [NativeTypeName("#define D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_SHIFT 11")]
    public const int SbGsOutputPrimitiveTopologyShift = 11;

    [NativeTypeName("#define D3D10_SB_INSTRUCTION_RETURN_TYPE_MASK 0x00001800")]
    public const int SbInstructionReturnTypeMask = 0x00001800;

    [NativeTypeName("#define D3D10_SB_INSTRUCTION_RETURN_TYPE_SHIFT 11")]
    public const int SbInstructionReturnTypeShift = 11;
}
