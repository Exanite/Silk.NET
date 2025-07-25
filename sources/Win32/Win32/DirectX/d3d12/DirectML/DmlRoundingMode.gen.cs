// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE"]/*'/>
public enum DmlRoundingMode
{
    /// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE.DML_ROUNDING_MODE_HALVES_TO_NEAREST_EVEN"]/*'/>

    HalvesToNearestEven,

    /// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE.DML_ROUNDING_MODE_TOWARD_ZERO"]/*'/>

    TowardZero,

    /// <include file='DML_ROUNDING_MODE.xml' path='doc/member[@name="DML_ROUNDING_MODE.DML_ROUNDING_MODE_TOWARD_INFINITY"]/*'/>

    TowardInfinity,
}
