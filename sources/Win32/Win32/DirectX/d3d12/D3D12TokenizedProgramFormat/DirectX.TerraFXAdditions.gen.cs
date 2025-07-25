// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static uint D3D10SbImmediateAddressOffsetMask(uint Coord) =>
        0x0000000Fu << D3D10SbImmediateAddressOffsetShift(Coord);

    public static int D3D10SbImmediateAddressOffsetShift(uint Coord) =>
        9 + 4 * ((int)(Coord) & D3D10.SbImmediateAddressOffsetCoordMask);

    public static uint D3D10SbOperand4ComponentMask(int ComponentName) =>
        (1u << (D3D10.SbOperand4ComponentMaskShift + ComponentName))
        & D3D10.SbOperand4ComponentMaskMask;

    public static uint D3D10SbOperandIndexRepresentationMask(int Dim) =>
        0x3u << D3D10SbOperandIndexRepresentationShift(Dim);

    public static int D3D10SbOperandIndexRepresentationShift(int Dim) => 22 + 3 * (Dim & 3);

    public static D3D10SbConstantBufferAccessPattern DecodeD3D10SbConstantBufferAccessPattern(
        uint OpcodeToken0
    ) =>
        (D3D10SbConstantBufferAccessPattern)(
            (OpcodeToken0 & D3D10.SbConstantBufferAccessPatternMask)
            >> D3D10.SbConstantBufferAccessPatternShift
        );

    public static D3D10SbCustomdataClass DecodeD3D10SbCustomdataClass(uint CustomDataDescTok) =>
        (D3D10SbCustomdataClass)(
            (CustomDataDescTok & D3D10.SbCustomdataClassMask) >> D3D10.SbCustomdataClassShift
        );

    public static D3D10SbExtendedOpcodeType DecodeD3D10SbExtendedOpcodeType(uint OpcodeToken1) =>
        (D3D10SbExtendedOpcodeType)(OpcodeToken1 & D3D10.SbExtendedOpcodeTypeMask);

    public static D3D10SbExtendedOperandType DecodeD3D10SbExtendedOperandType(uint OperandToken1) =>
        (D3D10SbExtendedOperandType)(OperandToken1 & D3D10.SbExtendedOperandTypeMask);

    public static uint DecodeD3D10SbGlobalFlags(uint OpcodeToken0) =>
        OpcodeToken0 & D3D10.SbGlobalFlagsMask;

    public static D3D10SbPrimitive DecodeD3D10SbGsInputPrimitive(uint OpcodeToken0) =>
        (D3D10SbPrimitive)(
            (OpcodeToken0 & D3D10.SbGsInputPrimitiveMask) >> D3D10.SbGsInputPrimitiveShift
        );

    public static D3D10SbPrimitiveTopology DecodeD3D10SbGsOutputPrimitiveTopology(
        uint OpcodeToken0
    ) =>
        (D3D10SbPrimitiveTopology)(
            (OpcodeToken0 & D3D10.SbGsOutputPrimitiveTopologyMask)
            >> D3D10.SbGsOutputPrimitiveTopologyShift
        );

    public static D3D10SbInterpolationMode DecodeD3D10SbInputInterpolationMode(uint OpcodeToken0) =>
        (D3D10SbInterpolationMode)(
            (OpcodeToken0 & D3D10.SbInputInterpolationModeMask)
            >> D3D10.SbInputInterpolationModeShift
        );

    public static D3D10SbInstructionReturnType DecodeD3D10SbInstructionReturnType(
        uint OpcodeToken0
    ) =>
        (D3D10SbInstructionReturnType)(
            (OpcodeToken0 & D3D10.SbInstructionReturnTypeMask) >> D3D10.SbInstructionReturnTypeShift
        );

    public static D3D10SbInstructionTestBoolean DecodeD3D10SbInstructionTestBoolean(
        uint OpcodeToken0
    ) =>
        (D3D10SbInstructionTestBoolean)(
            (OpcodeToken0 & D3D10.SbInstructionTestBooleanMask)
            >> D3D10.SbInstructionTestBooleanShift
        );

    public static D3D10SbName DecodeD3D10SbName(uint NameToken) =>
        (D3D10SbName)(NameToken & D3D10.SbNameMask);

    public static D3D10SbOpcodeType DecodeD3D10SbOpcodeType(uint OpcodeToken0) =>
        (D3D10SbOpcodeType)(OpcodeToken0 & D3D10.SbOpcodeTypeMask);

    public static uint DecodeD3D10SbOperand4ComponentMask(uint OperandToken0) =>
        OperandToken0 & D3D10.SbOperand4ComponentMaskMask;

    public static D3D10Sb4ComponentName DecodeD3D10SbOperand4ComponentSelect1(uint OperandToken0) =>
        (D3D10Sb4ComponentName)(
            (OperandToken0 & D3D10.SbOperand4ComponentSelect1Mask)
            >> D3D10.SbOperand4ComponentSelect1Shift
        );

    public static D3D10SbOperand4ComponentSelectionMode DecodeD3D10SbOperand4ComponentSelectionMode(
        uint OperandToken0
    ) =>
        (D3D10SbOperand4ComponentSelectionMode)(
            (OperandToken0 & D3D10.SbOperand4ComponentSelectionModeMask)
            >> D3D10.SbOperand4ComponentSelectionModeShift
        );

    public static uint DecodeD3D10SbOperand4ComponentSwizzle(uint OperandToken0) =>
        OperandToken0 & D3D10.SbOperand4ComponentSwizzleMask;

    public static D3D10Sb4ComponentName DecodeD3D10SbOperand4ComponentSwizzleSource(
        uint OperandToken0,
        int DestComp
    ) =>
        (D3D10Sb4ComponentName)(
            (
                OperandToken0
                >> (
                    D3D10.SbOperand4ComponentSwizzleShift
                    + 2 * ((DestComp) & D3D10.Sb4ComponentNameMask)
                )
            ) & D3D10.Sb4ComponentNameMask
        );

    public static D3D10SbOperandIndexDimension DecodeD3D10SbOperandIndexDimension(
        uint OperandToken0
    ) =>
        (D3D10SbOperandIndexDimension)(
            (OperandToken0 & D3D10.SbOperandIndexDimensionMask)
            >> D3D10.SbOperandIndexDimensionShift
        );

    public static D3D10SbOperandIndexRepresentation DecodeD3D10SbOperandIndexRepresentation(
        int Dim,
        uint OperandToken0
    ) =>
        (D3D10SbOperandIndexRepresentation)(
            (OperandToken0 & D3D10SbOperandIndexRepresentationMask(Dim))
            >> D3D10SbOperandIndexRepresentationShift(Dim)
        );

    public static D3D10SbOperandModifier DecodeD3D10SbOperandModifier(uint OperandToken1) =>
        (D3D10SbOperandModifier)(
            (OperandToken1 & D3D10.SbOperandModifierMask) >> D3D10.SbOperandModifierShift
        );

    public static D3D10SbOperandNumComponents DecodeD3D10SbOperandNumComponents(
        uint OperandToken0
    ) => ((D3D10SbOperandNumComponents)(OperandToken0 & D3D10.SbOperandNumComponentsMask));

    public static D3D10SbOperandType DecodeD3D10SbOperandType(uint OperandToken0) =>
        (D3D10SbOperandType)((OperandToken0 & D3D10.SbOperandTypeMask) >> D3D10.SbOperandTypeShift);

    public static D3D10SbResinfoInstructionReturnType DecodeD3D10SbResinfoInstructionReturnType(
        uint OpcodeToken0
    ) =>
        (D3D10SbResinfoInstructionReturnType)(
            (OpcodeToken0 & D3D10.SbResinfoInstructionReturnTypeMask)
            >> D3D10.SbResinfoInstructionReturnTypeShift
        );

    public static D3D10SbResourceDimension DecodeD3D10SbResourceDimension(uint OpcodeToken0) =>
        (D3D10SbResourceDimension)(
            (OpcodeToken0 & D3D10.SbResourceDimensionMask) >> D3D10.SbResourceDimensionShift
        );

    public static D3D10SbResourceReturnType DecodeD3D10SbResourceReturnType(
        uint ResourceReturnTypeToken,
        int Component
    ) =>
        (D3D10SbResourceReturnType)(
            (ResourceReturnTypeToken >> (Component * D3D10.SbResourceReturnTypeNumbits))
            & D3D10.SbResourceReturnTypeMask
        );

    public static uint DecodeD3D10SbResourceSampleCount(uint OpcodeToken0) =>
        (uint)(
            (OpcodeToken0 & D3D10.SbResourceSampleCountMask) >> D3D10.SbResourceSampleCountShift
        );

    public static D3D10SbSamplerMode DecodeD3D10SbSamplerMode(uint OpcodeToken0) =>
        (D3D10SbSamplerMode)((OpcodeToken0 & D3D10.SbSamplerModeMask) >> D3D10.SbSamplerModeShift);

    public static uint DecodeD3D10SbTokenizedInstructionLength(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D10.SbTokenizedInstructionLengthMask)
        >> D3D10.SbTokenizedInstructionLengthShift;

    public static uint DecodeD3D10SbTokenizedProgramLength(uint LenTok) => LenTok;

    public static uint DecodeD3D10SbTokenizedProgramMajorVersion(uint VerTok) =>
        (VerTok & D3D10.SbTokenizedProgramMajorVersionMask)
        >> D3D10.SbTokenizedProgramMajorVersionShift;

    public static uint DecodeD3D10SbTokenizedProgramMinorVersion(uint VerTok) =>
        VerTok & D3D10.SbTokenizedProgramMinorVersionMask;

    public static D3D10SbTokenizedProgramType DecodeD3D10SbTokenizedProgramType(uint VerTok) =>
        (
            (D3D10SbTokenizedProgramType)(
                (VerTok & D3D10.SbTokenizedProgramTypeMask) >> D3D10.SbTokenizedProgramTypeShift
            )
        );

    public static uint DecodeD3D11SbAccessCoherencyFlags(uint OperandToken0) =>
        OperandToken0 & D3D11.SbAccessCoherencyMask;

    public static D3D10SbResourceDimension DecodeD3D11SbExtendedResourceDimension(
        uint OpcodeTokenN
    ) =>
        (D3D10SbResourceDimension)(
            ((OpcodeTokenN) & D3D11.SbExtendedResourceDimensionMask)
            >> D3D11.SbExtendedResourceDimensionShift
        );

    public static uint DecodeD3D11SbExtendedResourceDimensionStructureStride(uint OpcodeTokenN) =>
        (OpcodeTokenN & D3D11.SbExtendedResourceDimensionStructureStrideMask)
        >> D3D11.SbExtendedResourceDimensionStructureStrideShift;

    public static D3D10SbResourceReturnType DecodeD3D11SbExtendedResourceReturnType(
        uint OpcodeTokenN,
        int Component
    ) =>
        (D3D10SbResourceReturnType)(
            (
                OpcodeTokenN
                >> (
                    Component * D3D10.SbResourceReturnTypeNumbits
                    + D3D11.SbExtendedResourceReturnTypeShift
                )
            ) & D3D10.SbResourceReturnTypeMask
        );

    public static uint DecodeD3D11SbInputControlPointCount(uint OpcodeToken0) =>
        (uint)(
            (OpcodeToken0 & D3D11.SbInputControlPointCountMask)
            >> D3D11.SbInputControlPointCountShift
        );

    public static uint DecodeD3D11SbInstructionPreciseValues(uint OpcodeToken0) =>
        (
            (OpcodeToken0 & D3D11.SbInstructionPreciseValuesMask)
            >> D3D11.SbInstructionPreciseValuesShift
        );

    public static uint DecodeD3D11SbInterfaceArrayLength(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D11.SbInterfaceArrayLengthMask) >> D3D11.SbInterfaceArrayLengthShift;

    public static bool DecodeD3D11SbInterfaceIndexedBit(uint OpcodeToken0) =>
        ((OpcodeToken0 & D3D11.SbInterfaceIndexedBitMask) >> D3D11.SbInterfaceIndexedBitShift) != 0;

    public static uint DecodeD3D11SbInterfaceTableLength(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D11.SbInterfaceTableLengthMask) >> D3D11.SbInterfaceTableLengthShift;

    public static D3D11SbOperandMinPrecision DecodeD3D11SbOperandMinPrecision(uint OperandToken1) =>
        (
            (D3D11SbOperandMinPrecision)(
                ((OperandToken1) & D3D11.SbOperandMinPrecisionMask)
                >> D3D11.SbOperandMinPrecisionShift
            )
        );

    public static uint DecodeD3D11SbOutputControlPointCount(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D11.SbOutputControlPointCountMask)
        >> D3D11.SbOutputControlPointCountShift;

    public static uint DecodeD3D11SbResourceFlags(uint OperandToken0) =>
        OperandToken0 & D3D11.SbResourceFlagsMask;

    public static uint DecodeD3D11SbSyncFlags(uint OperandToken0) =>
        OperandToken0 & D3D11.SbSyncFlagsMask;

    public static D3D11SbTessellatorDomain DecodeD3D11SbTessDomain(uint OpcodeToken0) =>
        (D3D11SbTessellatorDomain)(
            (OpcodeToken0 & D3D11.SbTessDomainMask) >> D3D11.SbTessDomainShift
        );

    public static D3D11SbTessellatorOutputPrimitive DecodeD3D11SbTessOutputPrimitive(
        uint OpcodeToken0
    ) =>
        (D3D11SbTessellatorOutputPrimitive)(
            (OpcodeToken0 & D3D11.SbTessOutputPrimitiveMask) >> D3D11.SbTessOutputPrimitiveShift
        );

    public static D3D11SbTessellatorPartitioning DecodeD3D11SbTessPartitioning(uint OpcodeToken0) =>
        (D3D11SbTessellatorPartitioning)(
            (OpcodeToken0 & D3D11.SbTessPartitioningMask) >> D3D11.SbTessPartitioningShift
        );

    public static uint DecodeD3D11SbUavFlags(uint OperandToken0) =>
        OperandToken0 & D3D11.SbUavFlagsMask;

    public static uint DecodeD3D12SbOperandNonUniform(uint OperandToken1) =>
        (OperandToken1 & D3D12.SbOperandNonUniformMask) >> D3D12.SbOperandNonUniformShift;

    public static int DecodeImmediateD3D10SbAddressOffset(uint Coord, uint OpcodeToken1) =>
        (int)(
            (OpcodeToken1 & D3D10SbImmediateAddressOffsetMask(Coord))
            >> (D3D10SbImmediateAddressOffsetShift(Coord))
        );

    public static bool DecodeIsD3D10SbInstructionSaturateEnabled(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D10.SbInstructionSaturateMask) != 0;

    public static bool DecodeIsD3D10SbOpcodeExtended(uint OpcodeToken0) =>
        ((OpcodeToken0 & D3D10.SbOpcodeExtendedMask) >> D3D10.SbOpcodeExtendedShift) != 0;

    public static bool DecodeIsD3D10SbOperandDoubleExtended(uint OperandToken1) =>
        ((OperandToken1 & D3D10.SbOperandDoubleExtendedMask) >> D3D10.SbOperandDoubleExtendedShift)
        != 0;

    public static bool DecodeIsD3D10SbOperandExtended(uint OperandToken0) =>
        ((OperandToken0 & D3D10.SbOperandExtendedMask) >> D3D10.SbOperandExtendedShift) != 0;

    public static uint EncodeD3D10SbCustomdataClass(D3D10SbCustomdataClass CustomDataClass) =>
        EncodeD3D10SbOpcodeType(D3D10SbOpcodeType.D10SbOpcodeCustomdata)
        | (((uint)(CustomDataClass) << D3D10.SbCustomdataClassShift) & D3D10.SbCustomdataClassMask);

    public static uint EncodeD3D10SbD3D10SbConstantBufferAccessPattern(
        D3D10SbConstantBufferAccessPattern AccessPattern
    ) =>
        ((uint)(AccessPattern) << D3D10.SbConstantBufferAccessPatternShift)
        & D3D10.SbConstantBufferAccessPatternMask;

    public static uint EncodeD3D10SbExtendedOpcodeType(D3D10SbExtendedOpcodeType ExtOpcodeType) =>
        (uint)(ExtOpcodeType) & D3D10.SbExtendedOpcodeTypeMask;

    public static uint EncodeD3D10SbExtendedOperandModifier(D3D10SbOperandModifier SourceMod) =>
        (((uint)(SourceMod) << D3D10.SbOperandModifierShift) & D3D10.SbOperandModifierMask)
        | EncodeD3D10SbExtendedOperandType(D3D10SbExtendedOperandType.Modifier)
        | EncodeD3D10SbOperandDoubleExtended(false);

    public static uint EncodeD3D10SbExtendedOperandType(
        D3D10SbExtendedOperandType ExtOperandType
    ) => (uint)(ExtOperandType) & D3D10.SbExtendedOperandTypeMask;

    public static uint EncodeD3D10SbGlobalFlags(uint Flags) => Flags & D3D10.SbGlobalFlagsMask;

    public static uint EncodeD3D10SbGsInputPrimitive(D3D10SbPrimitive Prim) =>
        ((uint)(Prim) << D3D10.SbGsInputPrimitiveShift) & D3D10.SbGsInputPrimitiveMask;

    public static uint EncodeD3D10SbGsOutputPrimitiveTopology(
        D3D10SbPrimitiveTopology PrimTopology
    ) =>
        ((uint)(PrimTopology) << D3D10.SbGsOutputPrimitiveTopologyShift)
        & D3D10.SbGsOutputPrimitiveTopologyMask;

    public static uint EncodeD3D10SbInputInterpolationMode(
        D3D10SbInterpolationMode InterpolationMode
    ) =>
        ((uint)(InterpolationMode) << D3D10.SbInputInterpolationModeShift)
        & D3D10.SbInputInterpolationModeMask;

    public static uint EncodeD3D10SbInstructionReturnType(
        D3D10SbInstructionReturnType ReturnType
    ) =>
        ((uint)(ReturnType) << D3D10.SbInstructionReturnTypeShift)
        & D3D10.SbInstructionReturnTypeMask;

    public static uint EncodeD3D10SbInstructionSaturate(bool bSat) =>
        bSat ? D3D10.SbInstructionSaturateMask : 0u;

    public static uint EncodeD3D10SbInstructionTestBoolean(D3D10SbInstructionTestBoolean Boolean) =>
        ((uint)(Boolean) << D3D10.SbInstructionTestBooleanShift)
        & D3D10.SbInstructionTestBooleanMask;

    public static uint EncodeD3D10SbName(D3D10SbName Name) => (uint)(Name) & D3D10.SbNameMask;

    public static uint EncodeD3D10SbOpcodeExtended(bool bExtended) =>
        bExtended ? D3D10.SbOpcodeExtendedMask : 0u;

    public static uint EncodeD3D10SbOpcodeType(D3D10SbOpcodeType OpcodeName) =>
        (uint)(OpcodeName) & D3D10.SbOpcodeTypeMask;

    public static uint EncodeD3D10SbOperand4ComponentMask(uint ComponentMask) =>
        ComponentMask & D3D10.SbOperand4ComponentMaskMask;

    public static uint EncodeD3D10SbOperand4ComponentSelect1(D3D10Sb4ComponentName SelectedComp) =>
        ((uint)(SelectedComp) << D3D10.SbOperand4ComponentSelect1Shift)
        & D3D10.SbOperand4ComponentSelect1Mask;

    public static uint EncodeD3D10SbOperand4ComponentSelectionMode(
        D3D10SbOperand4ComponentSelectionMode SelectionMode
    ) =>
        ((uint)(SelectionMode) << D3D10.SbOperand4ComponentSelectionModeShift)
        & D3D10.SbOperand4ComponentSelectionModeMask;

    public static uint EncodeD3D10SbOperand4ComponentSwizzle(
        D3D10Sb4ComponentName XSrc,
        D3D10Sb4ComponentName YSrc,
        D3D10Sb4ComponentName ZSrc,
        D3D10Sb4ComponentName WSrc
    ) =>
        (
            ((uint)(XSrc) & D3D10.Sb4ComponentNameMask)
            | (((uint)(YSrc) & D3D10.Sb4ComponentNameMask) << 2)
            | (((uint)(ZSrc) & D3D10.Sb4ComponentNameMask) << 4)
            | (((uint)(WSrc) & D3D10.Sb4ComponentNameMask) << 6)
        ) << D3D10.SbOperand4ComponentSwizzleShift;

    public static uint EncodeD3D10SbOperandDoubleExtended(bool bExtended) =>
        bExtended ? D3D10.SbOperandDoubleExtendedMask : 0;

    public static uint EncodeD3D10SbOperandExtended(bool bExtended) =>
        bExtended ? D3D10.SbOperandExtendedMask : 0u;

    public static uint EncodeD3D10SbOperandIndexDimension(
        D3D10SbOperandIndexDimension OperandIndexDim
    ) =>
        ((uint)(OperandIndexDim) << D3D10.SbOperandIndexDimensionShift)
        & D3D10.SbOperandIndexDimensionMask;

    public static uint EncodeD3D10SbOperandIndexRepresentation(
        int Dim,
        D3D10SbOperandIndexRepresentation IndexRepresentation
    ) =>
        ((uint)(IndexRepresentation) << D3D10SbOperandIndexRepresentationShift(Dim))
        & D3D10SbOperandIndexRepresentationMask(Dim);

    public static uint EncodeD3D10SbOperandNumComponents(D3D10SbOperandNumComponents NumComp) =>
        (uint)(NumComp) & D3D10.SbOperandNumComponentsMask;

    public static uint EncodeD3D10SbOperandType(D3D10SbOperandType OperandType) =>
        ((uint)(OperandType) << D3D10.SbOperandTypeShift) & D3D10.SbOperandTypeMask;

    public static uint EncodeD3D10SbResinfoInstructionReturnType(
        D3D10SbResinfoInstructionReturnType ReturnType
    ) =>
        ((uint)(ReturnType) << D3D10.SbResinfoInstructionReturnTypeShift)
        & D3D10.SbResinfoInstructionReturnTypeMask;

    public static uint EncodeD3D10SbResourceDimension(D3D10SbResourceDimension ResourceDim) =>
        ((uint)(ResourceDim) << D3D10.SbResourceDimensionShift) & D3D10.SbResourceDimensionMask;

    public static uint EncodeD3D10SbResourceReturnType(
        D3D10SbResourceReturnType ReturnType,
        int Component
    ) =>
        ((uint)(ReturnType) & D3D10.SbResourceReturnTypeMask)
        << (Component * D3D10.SbResourceReturnTypeNumbits);

    public static uint EncodeD3D10SbResourceSampleCount(uint SampleCount) =>
        (((SampleCount > 127) ? 127 : SampleCount) << D3D10.SbResourceSampleCountShift)
        & D3D10.SbResourceSampleCountMask;

    public static uint EncodeD3D10SbSamplerMode(D3D10SbSamplerMode SamplerMode) =>
        ((uint)(SamplerMode) << D3D10.SbSamplerModeShift) & D3D10.SbSamplerModeMask;

    public static uint EncodeD3D10SbTokenizedInstructionLength(uint Length) =>
        (Length << D3D10.SbTokenizedInstructionLengthShift)
        & D3D10.SbTokenizedInstructionLengthMask;

    public static uint EncodeD3D10SbTokenizedProgramLength(uint Length) => Length;

    public static uint EncodeD3D10SbTokenizedProgramVersionToken(
        D3D10SbTokenizedProgramType ProgType,
        uint MajorVer,
        uint MinorVer
    ) =>
        (((uint)(ProgType) << D3D10.SbTokenizedProgramTypeShift) & D3D10.SbTokenizedProgramTypeMask)
        | (
            (
                (MajorVer << D3D10.SbTokenizedProgramMajorVersionShift)
                & D3D10.SbTokenizedProgramMajorVersionMask
            )
        )
        | (MinorVer & D3D10.SbTokenizedProgramMinorVersionMask);

    public static uint EncodeD3D11SbAccessCoherencyFlags(uint Flags) =>
        Flags & D3D11.SbAccessCoherencyMask;

    public static uint EncodeD3D11SbExtendedResourceDimension(
        D3D10SbResourceDimension ResourceDim
    ) =>
        ((uint)(ResourceDim) << D3D11.SbExtendedResourceDimensionShift)
        & D3D11.SbExtendedResourceDimensionMask;

    public static uint EncodeD3D11SbExtendedResourceDimensionStructureStride(uint Stride) =>
        (Stride << D3D11.SbExtendedResourceDimensionStructureStrideShift)
        & D3D11.SbExtendedResourceDimensionStructureStrideMask;

    public static uint EncodeD3D11SbExtendedResourceReturnType(
        D3D10SbResourceReturnType ReturnType,
        int Component
    ) =>
        ((uint)(ReturnType) & D3D10.SbResourceReturnTypeMask)
        << (
            Component * D3D10.SbResourceReturnTypeNumbits + D3D11.SbExtendedResourceReturnTypeShift
        );

    public static uint EncodeD3D11SbInputControlPointCount(uint Count) =>
        (Count << D3D11.SbInputControlPointCountShift) & D3D11.SbInputControlPointCountMask;

    public static uint EncodeD3D11SbInstructionPreciseValues(uint ComponentMask) =>
        (ComponentMask << D3D11.SbInstructionPreciseValuesShift)
        & D3D11.SbInstructionPreciseValuesMask;

    public static uint EncodeD3D11SbInterfaceArrayLength(uint ArrayLength) =>
        (ArrayLength << D3D11.SbInterfaceArrayLengthShift) & D3D11.SbInterfaceArrayLengthMask;

    public static uint EncodeD3D11SbInterfaceIndexedBit(bool IndexedBit) =>
        ((IndexedBit ? 1u : 0u) << D3D11.SbInterfaceIndexedBitShift)
        & D3D11.SbInterfaceIndexedBitMask;

    public static uint EncodeD3D11SbInterfaceTableLength(uint TableLength) =>
        (TableLength << D3D11.SbInterfaceTableLengthShift) & D3D11.SbInterfaceTableLengthMask;

    public static uint EncodeD3D11SbOperandMinPrecision(D3D11SbOperandMinPrecision MinPrecision) =>
        ((uint)(MinPrecision) << D3D11.SbOperandMinPrecisionShift)
        & D3D11.SbOperandMinPrecisionMask;

    public static uint EncodeD3D11SbOutputControlPointCount(uint Count) =>
        (Count << D3D11.SbOutputControlPointCountShift) & D3D11.SbOutputControlPointCountMask;

    public static uint EncodeD3D11SbResourceFlags(uint Flags) => Flags & D3D11.SbResourceFlagsMask;

    public static uint EncodeD3D11SbSyncFlags(uint Flags) => Flags & D3D11.SbSyncFlagsMask;

    public static uint EncodeD3D11SbTessDomain(D3D11SbTessellatorDomain Domain) =>
        ((uint)(Domain) << D3D11.SbTessDomainShift) & D3D11.SbTessDomainMask;

    public static uint EncodeD3D11SbTessOutputPrimitive(
        D3D11SbTessellatorOutputPrimitive OutputPrimitive
    ) =>
        ((uint)(OutputPrimitive) << D3D11.SbTessOutputPrimitiveShift)
        & D3D11.SbTessOutputPrimitiveMask;

    public static uint EncodeD3D11SbTessPartitioning(D3D11SbTessellatorPartitioning Partitioning) =>
        ((uint)(Partitioning) << D3D11.SbTessPartitioningShift) & D3D11.SbTessPartitioningMask;

    public static uint EncodeD3D11SbUavFlags(uint Flags) => Flags & D3D11.SbUavFlagsMask;

    public static uint EncodeD3D12SbOperandNonUniform(uint NonUniform) =>
        (NonUniform << D3D12.SbOperandNonUniformShift) & D3D12.SbOperandNonUniformMask;

    public static uint EncodeImmediateD3D10SbAddressOffset(uint Coord, int ImmediateOffset) =>
        (uint)(ImmediateOffset << D3D10SbImmediateAddressOffsetShift(Coord))
        & D3D10SbImmediateAddressOffsetMask(Coord);
}
