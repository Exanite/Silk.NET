// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC"]/*'/>
public unsafe partial struct DmlBufferTensorDesc
{
    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.DataType"]/*'/>

    public DmlTensorDataType DataType;

    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.Flags"]/*'/>

    public DmlTensorFlags Flags;

    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.DimensionCount"]/*'/>

    public uint DimensionCount;

    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.Sizes"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* Sizes;

    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.Strides"]/*'/>

    [NativeTypeName("const UINT *")]
    public uint* Strides;

    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.TotalTensorSizeInBytes"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong TotalTensorSizeInBytes;

    /// <include file='DML_BUFFER_TENSOR_DESC.xml' path='doc/member[@name="DML_BUFFER_TENSOR_DESC.GuaranteedBaseOffsetAlignment"]/*'/>

    public uint GuaranteedBaseOffsetAlignment;
}
