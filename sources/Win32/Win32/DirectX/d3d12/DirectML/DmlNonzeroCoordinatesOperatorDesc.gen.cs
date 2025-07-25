// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_NONZERO_COORDINATES_OPERATOR_DESC.xml' path='doc/member[@name="DML_NONZERO_COORDINATES_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlNonzeroCoordinatesOperatorDesc
{
    /// <include file='DML_NONZERO_COORDINATES_OPERATOR_DESC.xml' path='doc/member[@name="DML_NONZERO_COORDINATES_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_NONZERO_COORDINATES_OPERATOR_DESC.xml' path='doc/member[@name="DML_NONZERO_COORDINATES_OPERATOR_DESC.OutputCountTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputCountTensor;

    /// <include file='DML_NONZERO_COORDINATES_OPERATOR_DESC.xml' path='doc/member[@name="DML_NONZERO_COORDINATES_OPERATOR_DESC.OutputCoordinatesTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputCoordinatesTensor;
}
