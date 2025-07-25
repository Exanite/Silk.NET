// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE"]/*'/>
public enum DmlIsInfinityMode
{
    /// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE.DML_IS_INFINITY_MODE_EITHER"]/*'/>

    Either = 0,

    /// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE.DML_IS_INFINITY_MODE_POSITIVE"]/*'/>

    Positive = 1,

    /// <include file='DML_IS_INFINITY_MODE.xml' path='doc/member[@name="DML_IS_INFINITY_MODE.DML_IS_INFINITY_MODE_NEGATIVE"]/*'/>

    Negative = 2,
}
