// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC"]/*'/>
public unsafe partial struct D3D12ShaderTypeDesc
{
    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Class"]/*'/>

    public D3DShaderVariableClass Class;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Type"]/*'/>

    public D3DShaderVariableType Type;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Rows"]/*'/>

    public uint Rows;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Columns"]/*'/>

    public uint Columns;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Elements"]/*'/>

    public uint Elements;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Members"]/*'/>

    public uint Members;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Offset"]/*'/>

    public uint Offset;

    /// <include file='D3D12_SHADER_TYPE_DESC.xml' path='doc/member[@name="D3D12_SHADER_TYPE_DESC.Name"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
}
