// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE"]/*'/>
public enum DmlPaddingMode
{
    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_CONSTANT"]/*'/>

    Constant,

    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_EDGE"]/*'/>

    Edge,

    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_REFLECTION"]/*'/>

    Reflection,

    /// <include file='DML_PADDING_MODE.xml' path='doc/member[@name="DML_PADDING_MODE.DML_PADDING_MODE_SYMMETRIC"]/*'/>

    Symmetric,
}
