// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DmlResampleOperatorDesc
{
    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.InterpolationMode"]/*'/>

    public DmlInterpolationMode InterpolationMode;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.ScaleCount"]/*'/>

    public uint ScaleCount;

    /// <include file='DML_RESAMPLE_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_OPERATOR_DESC.Scales"]/*'/>

    [NativeTypeName("const FLOAT *")]
    public float* Scales;
}
