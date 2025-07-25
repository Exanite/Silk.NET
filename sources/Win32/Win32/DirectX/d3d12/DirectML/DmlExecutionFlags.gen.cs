// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS"]/*'/>
[Flags]
public enum DmlExecutionFlags
{
    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_ALLOW_HALF_PRECISION_COMPUTATION"]/*'/>

    AllowHalfPrecisionComputation = 0x1,

    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_DISABLE_META_COMMANDS"]/*'/>

    DisableMetaCommands = 0x2,

    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_DESCRIPTORS_VOLATILE"]/*'/>

    DescriptorsVolatile = 0x4,
}
