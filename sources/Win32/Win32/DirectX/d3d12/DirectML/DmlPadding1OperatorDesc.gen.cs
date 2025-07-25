// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlPadding1OperatorDesc
{
    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.PaddingMode"]/*'/>

    public DmlPaddingMode PaddingMode;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.PaddingValueDataType"]/*'/>

    public DmlTensorDataType PaddingValueDataType;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.PaddingValue"]/*'/>

    public DmlScalarUnion PaddingValue;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.DimensionCount"]/*'/>

    public uint DimensionCount;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.StartPadding"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    /// <include file='DML_PADDING1_OPERATOR_DESC.xml' path='doc/member[@name="DML_PADDING1_OPERATOR_DESC.EndPadding"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* EndPadding;
}
