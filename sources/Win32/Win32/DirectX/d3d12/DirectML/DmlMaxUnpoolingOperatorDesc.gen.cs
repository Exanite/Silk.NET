// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_MAX_UNPOOLING_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_UNPOOLING_OPERATOR_DESC"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DmlMaxUnpoolingOperatorDesc
{
    /// <include file='DML_MAX_UNPOOLING_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_UNPOOLING_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_MAX_UNPOOLING_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_UNPOOLING_OPERATOR_DESC.IndicesTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* IndicesTensor;

    /// <include file='DML_MAX_UNPOOLING_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_UNPOOLING_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;
}
