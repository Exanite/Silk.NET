// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION"]/*'/>
public enum DmlReduceFunction
{
    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_ARGMAX"]/*'/>

    Argmax,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_ARGMIN"]/*'/>

    Argmin,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_AVERAGE"]/*'/>

    Average,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_L1"]/*'/>

    L1,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_L2"]/*'/>

    L2,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_LOG_SUM"]/*'/>

    LogSum,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_LOG_SUM_EXP"]/*'/>

    LogSumExp,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_MAX"]/*'/>

    Max,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_MIN"]/*'/>

    Min,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_MULTIPLY"]/*'/>

    Multiply,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_SUM"]/*'/>

    Sum,

    /// <include file='DML_REDUCE_FUNCTION.xml' path='doc/member[@name="DML_REDUCE_FUNCTION.DML_REDUCE_FUNCTION_SUM_SQUARE"]/*'/>

    SumSquare,
}
