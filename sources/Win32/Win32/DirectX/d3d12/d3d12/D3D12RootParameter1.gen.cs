// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1"]/*'/>
public partial struct D3D12RootParameter1
{
    /// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1.ParameterType"]/*'/>

    public D3D12RootParameterType ParameterType;

    /// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_d3d12_L4111_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1.ShaderVisibility"]/*'/>

    public D3D12ShaderVisibility ShaderVisibility;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DescriptorTable"]/*'/>

    [UnscopedRef]
    public ref D3D12RootDescriptorTable1 DescriptorTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.DescriptorTable; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Constants"]/*'/>

    [UnscopedRef]
    public ref D3D12RootConstants Constants
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Constants; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Descriptor"]/*'/>

    [UnscopedRef]
    public ref D3D12RootDescriptor1 Descriptor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Descriptor; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DescriptorTable"]/*'/>

        [FieldOffset(0)]
        public D3D12RootDescriptorTable1 DescriptorTable;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Constants"]/*'/>

        [FieldOffset(0)]
        public D3D12RootConstants Constants;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Descriptor"]/*'/>

        [FieldOffset(0)]
        public D3D12RootDescriptor1 Descriptor;
    }
}
