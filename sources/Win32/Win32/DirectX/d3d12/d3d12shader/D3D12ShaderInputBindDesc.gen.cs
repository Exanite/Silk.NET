// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC"]/*'/>
public unsafe partial struct D3D12ShaderInputBindDesc
{
    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Name"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Type"]/*'/>

    public D3DShaderInputType Type;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.BindPoint"]/*'/>

    public uint BindPoint;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.BindCount"]/*'/>

    public uint BindCount;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.uFlags"]/*'/>

    public uint UFlags;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.ReturnType"]/*'/>

    public D3DResourceReturnType ReturnType;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Dimension"]/*'/>

    public D3DSrvDimension Dimension;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.NumSamples"]/*'/>

    public uint NumSamples;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.Space"]/*'/>

    public uint Space;

    /// <include file='D3D12_SHADER_INPUT_BIND_DESC.xml' path='doc/member[@name="D3D12_SHADER_INPUT_BIND_DESC.uID"]/*'/>

    public uint Uid;
}
