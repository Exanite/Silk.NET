// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_DEPTH_SPACE_ORDER.xml' path='doc/member[@name="DML_DEPTH_SPACE_ORDER"]/*'/>
public enum DmlDepthSpaceOrder
{
    /// <include file='DML_DEPTH_SPACE_ORDER.xml' path='doc/member[@name="DML_DEPTH_SPACE_ORDER.DML_DEPTH_SPACE_ORDER_DEPTH_COLUMN_ROW"]/*'/>

    DepthColumnRow,

    /// <include file='DML_DEPTH_SPACE_ORDER.xml' path='doc/member[@name="DML_DEPTH_SPACE_ORDER.DML_DEPTH_SPACE_ORDER_COLUMN_ROW_DEPTH"]/*'/>

    ColumnRowDepth,
}
