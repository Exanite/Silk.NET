// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_OPERATOR_DESC.xml' path='doc/member[@name="DML_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlOperatorDesc
{
    /// <include file='DML_OPERATOR_DESC.xml' path='doc/member[@name="DML_OPERATOR_DESC.Type"]/*'/>

    public DmlOperatorType Type;

    /// <include file='DML_OPERATOR_DESC.xml' path='doc/member[@name="DML_OPERATOR_DESC.Desc"]/*'/>

    [NativeTypeName("const void *")]
    public void* Desc;
}
