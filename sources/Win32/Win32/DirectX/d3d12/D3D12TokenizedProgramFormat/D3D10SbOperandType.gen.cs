// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE"]/*'/>
public enum D3D10SbOperandType
{
    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_TEMP"]/*'/>

    X10SbOperandTypeTemp = 0,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_INPUT"]/*'/>

    X10SbOperandTypeInput = 1,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_OUTPUT"]/*'/>

    X10SbOperandTypeOutput = 2,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_INDEXABLE_TEMP"]/*'/>

    X10SbOperandTypeIndexableTemp = 3,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_IMMEDIATE32"]/*'/>

    X10SbOperandTypeImmediate32 = 4,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_IMMEDIATE64"]/*'/>

    X10SbOperandTypeImmediate64 = 5,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_SAMPLER"]/*'/>

    X10SbOperandTypeSampler = 6,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_RESOURCE"]/*'/>

    X10SbOperandTypeResource = 7,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_CONSTANT_BUFFER"]/*'/>

    X10SbOperandTypeConstantBuffer = 8,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_IMMEDIATE_CONSTANT_BUFFER"]/*'/>

    X10SbOperandTypeImmediateConstantBuffer = 9,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_LABEL"]/*'/>

    X10SbOperandTypeLabel = 10,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_INPUT_PRIMITIVEID"]/*'/>

    X10SbOperandTypeInputPrimitiveid = 11,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_OUTPUT_DEPTH"]/*'/>

    X10SbOperandTypeOutputDepth = 12,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_NULL"]/*'/>

    X10SbOperandTypeNull = 13,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_RASTERIZER"]/*'/>

    X10SbOperandTypeRasterizer = 14,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D10_SB_OPERAND_TYPE_OUTPUT_COVERAGE_MASK"]/*'/>

    X10SbOperandTypeOutputCoverageMask = 15,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_STREAM"]/*'/>

    X11SbOperandTypeStream = 16,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_FUNCTION_BODY"]/*'/>

    X11SbOperandTypeFunctionBody = 17,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_FUNCTION_TABLE"]/*'/>

    X11SbOperandTypeFunctionTable = 18,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INTERFACE"]/*'/>

    X11SbOperandTypeInterface = 19,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_FUNCTION_INPUT"]/*'/>

    X11SbOperandTypeFunctionInput = 20,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_FUNCTION_OUTPUT"]/*'/>

    X11SbOperandTypeFunctionOutput = 21,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_OUTPUT_CONTROL_POINT_ID"]/*'/>

    X11SbOperandTypeOutputControlPointId = 22,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_FORK_INSTANCE_ID"]/*'/>

    X11SbOperandTypeInputForkInstanceId = 23,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_JOIN_INSTANCE_ID"]/*'/>

    X11SbOperandTypeInputJoinInstanceId = 24,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_CONTROL_POINT"]/*'/>

    X11SbOperandTypeInputControlPoint = 25,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_OUTPUT_CONTROL_POINT"]/*'/>

    X11SbOperandTypeOutputControlPoint = 26,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_PATCH_CONSTANT"]/*'/>

    X11SbOperandTypeInputPatchConstant = 27,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_DOMAIN_POINT"]/*'/>

    X11SbOperandTypeInputDomainPoint = 28,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_THIS_POINTER"]/*'/>

    X11SbOperandTypeThisPointer = 29,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_UNORDERED_ACCESS_VIEW"]/*'/>

    X11SbOperandTypeUnorderedAccessView = 30,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_THREAD_GROUP_SHARED_MEMORY"]/*'/>

    X11SbOperandTypeThreadGroupSharedMemory = 31,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_THREAD_ID"]/*'/>

    X11SbOperandTypeInputThreadId = 32,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_THREAD_GROUP_ID"]/*'/>

    X11SbOperandTypeInputThreadGroupId = 33,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_THREAD_ID_IN_GROUP"]/*'/>

    X11SbOperandTypeInputThreadIdInGroup = 34,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_COVERAGE_MASK"]/*'/>

    X11SbOperandTypeInputCoverageMask = 35,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_THREAD_ID_IN_GROUP_FLATTENED"]/*'/>

    X11SbOperandTypeInputThreadIdInGroupFlattened = 36,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INPUT_GS_INSTANCE_ID"]/*'/>

    X11SbOperandTypeInputGsInstanceId = 37,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_OUTPUT_DEPTH_GREATER_EQUAL"]/*'/>

    X11SbOperandTypeOutputDepthGreaterEqual = 38,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_OUTPUT_DEPTH_LESS_EQUAL"]/*'/>

    X11SbOperandTypeOutputDepthLessEqual = 39,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_CYCLE_COUNTER"]/*'/>

    X11SbOperandTypeCycleCounter = 40,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_OUTPUT_STENCIL_REF"]/*'/>

    X11SbOperandTypeOutputStencilRef = 41,

    /// <include file='D3D10_SB_OPERAND_TYPE.xml' path='doc/member[@name="D3D10_SB_OPERAND_TYPE.D3D11_SB_OPERAND_TYPE_INNER_COVERAGE"]/*'/>

    X11SbOperandTypeInnerCoverage = 42,
}
