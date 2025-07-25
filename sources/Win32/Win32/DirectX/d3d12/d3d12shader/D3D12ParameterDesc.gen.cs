// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC"]/*'/>
public unsafe partial struct D3D12ParameterDesc
{
    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Name"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.SemanticName"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* SemanticName;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Type"]/*'/>

    public D3DShaderVariableType Type;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Class"]/*'/>

    public D3DShaderVariableClass Class;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Rows"]/*'/>

    public uint Rows;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Columns"]/*'/>

    public uint Columns;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.InterpolationMode"]/*'/>

    public D3DInterpolationMode InterpolationMode;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.Flags"]/*'/>

    public D3DParameterFlags Flags;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstInRegister"]/*'/>

    public uint FirstInRegister;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstInComponent"]/*'/>

    public uint FirstInComponent;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstOutRegister"]/*'/>

    public uint FirstOutRegister;

    /// <include file='D3D12_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_PARAMETER_DESC.FirstOutComponent"]/*'/>

    public uint FirstOutComponent;
}
