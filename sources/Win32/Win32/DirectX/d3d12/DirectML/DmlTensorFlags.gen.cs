// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_TENSOR_FLAGS.xml' path='doc/member[@name="DML_TENSOR_FLAGS"]/*'/>
[Flags]
public enum DmlTensorFlags
{
    /// <include file='DML_TENSOR_FLAGS.xml' path='doc/member[@name="DML_TENSOR_FLAGS.DML_TENSOR_FLAG_NONE"]/*'/>

    None = 0x0,

    /// <include file='DML_TENSOR_FLAGS.xml' path='doc/member[@name="DML_TENSOR_FLAGS.DML_TENSOR_FLAG_OWNED_BY_DML"]/*'/>

    OwnedByDml = 0x1,
}
