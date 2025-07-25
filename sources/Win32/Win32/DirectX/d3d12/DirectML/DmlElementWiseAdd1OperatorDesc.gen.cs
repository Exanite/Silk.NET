// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_ADD1_OPERATOR_DESC"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DmlElementWiseAdd1OperatorDesc
{
    /// <include file='DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.ATensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* ATensor;

    /// <include file='DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.BTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* BTensor;

    /// <include file='DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;

    /// <include file='DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_ADD1_OPERATOR_DESC.FusedActivation"]/*'/>

    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DmlOperatorDesc* FusedActivation;
}
