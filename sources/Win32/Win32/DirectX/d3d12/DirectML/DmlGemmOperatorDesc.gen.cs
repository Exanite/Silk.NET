// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlGemmOperatorDesc
{
    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.ATensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* ATensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.BTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* BTensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.CTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* CTensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.TransA"]/*'/>

    public DmlMatrixTransform TransA;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.TransB"]/*'/>

    public DmlMatrixTransform TransB;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.Alpha"]/*'/>

    public float Alpha;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.Beta"]/*'/>

    public float Beta;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.FusedActivation"]/*'/>

    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DmlOperatorDesc* FusedActivation;
}
