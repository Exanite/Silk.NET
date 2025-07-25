// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1"]/*'/>
public partial struct D3D12RootDescriptor1
{
    /// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1.ShaderRegister"]/*'/>

    public uint ShaderRegister;

    /// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1.RegisterSpace"]/*'/>

    public uint RegisterSpace;

    /// <include file='D3D12_ROOT_DESCRIPTOR1.xml' path='doc/member[@name="D3D12_ROOT_DESCRIPTOR1.Flags"]/*'/>

    public D3D12RootDescriptorFlags Flags;
}
