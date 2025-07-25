// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_BINDING_PROPERTIES.xml' path='doc/member[@name="DML_BINDING_PROPERTIES"]/*'/>
public partial struct DmlBindingProperties
{
    /// <include file='DML_BINDING_PROPERTIES.xml' path='doc/member[@name="DML_BINDING_PROPERTIES.RequiredDescriptorCount"]/*'/>

    public uint RequiredDescriptorCount;

    /// <include file='DML_BINDING_PROPERTIES.xml' path='doc/member[@name="DML_BINDING_PROPERTIES.TemporaryResourceSize"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong TemporaryResourceSize;

    /// <include file='DML_BINDING_PROPERTIES.xml' path='doc/member[@name="DML_BINDING_PROPERTIES.PersistentResourceSize"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong PersistentResourceSize;
}
