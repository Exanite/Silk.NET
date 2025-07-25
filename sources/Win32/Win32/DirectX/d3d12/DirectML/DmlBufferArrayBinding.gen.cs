// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_BUFFER_ARRAY_BINDING.xml' path='doc/member[@name="DML_BUFFER_ARRAY_BINDING"]/*'/>
public unsafe partial struct DmlBufferArrayBinding
{
    /// <include file='DML_BUFFER_ARRAY_BINDING.xml' path='doc/member[@name="DML_BUFFER_ARRAY_BINDING.BindingCount"]/*'/>

    public uint BindingCount;

    /// <include file='DML_BUFFER_ARRAY_BINDING.xml' path='doc/member[@name="DML_BUFFER_ARRAY_BINDING.Bindings"]/*'/>

    [NativeTypeName("const DML_BUFFER_BINDING *")]
    public DmlBufferBinding* Bindings;
}
