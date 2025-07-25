// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC"]/*'/>
public unsafe partial struct D3D12ShaderDesc
{
    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.Version"]/*'/>

    public uint Version;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.Creator"]/*'/>

    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.Flags"]/*'/>

    public uint Flags;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.ConstantBuffers"]/*'/>

    public uint ConstantBuffers;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.BoundResources"]/*'/>

    public uint BoundResources;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.InputParameters"]/*'/>

    public uint InputParameters;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.OutputParameters"]/*'/>

    public uint OutputParameters;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.InstructionCount"]/*'/>

    public uint InstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TempRegisterCount"]/*'/>

    public uint TempRegisterCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TempArrayCount"]/*'/>

    public uint TempArrayCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.DefCount"]/*'/>

    public uint DefCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.DclCount"]/*'/>

    public uint DclCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TextureNormalInstructions"]/*'/>

    public uint TextureNormalInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TextureLoadInstructions"]/*'/>

    public uint TextureLoadInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TextureCompInstructions"]/*'/>

    public uint TextureCompInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TextureBiasInstructions"]/*'/>

    public uint TextureBiasInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TextureGradientInstructions"]/*'/>

    public uint TextureGradientInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.FloatInstructionCount"]/*'/>

    public uint FloatInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.IntInstructionCount"]/*'/>

    public uint IntInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.UintInstructionCount"]/*'/>

    public uint UintInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.StaticFlowControlCount"]/*'/>

    public uint StaticFlowControlCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.DynamicFlowControlCount"]/*'/>

    public uint DynamicFlowControlCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.MacroInstructionCount"]/*'/>

    public uint MacroInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.ArrayInstructionCount"]/*'/>

    public uint ArrayInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.CutInstructionCount"]/*'/>

    public uint CutInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.EmitInstructionCount"]/*'/>

    public uint EmitInstructionCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.GSOutputTopology"]/*'/>

    public D3DPrimitiveTopology GSOutputTopology;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.GSMaxOutputVertexCount"]/*'/>

    public uint GSMaxOutputVertexCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.InputPrimitive"]/*'/>

    public D3DPrimitive InputPrimitive;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.PatchConstantParameters"]/*'/>

    public uint PatchConstantParameters;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.cGSInstanceCount"]/*'/>

    public uint CGSInstanceCount;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.cControlPoints"]/*'/>

    public uint CControlPoints;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.HSOutputPrimitive"]/*'/>

    public D3DTessellatorOutputPrimitive HSOutputPrimitive;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.HSPartitioning"]/*'/>

    public D3DTessellatorPartitioning HSPartitioning;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.TessellatorDomain"]/*'/>

    public D3DTessellatorDomain TessellatorDomain;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.cBarrierInstructions"]/*'/>

    public uint CBarrierInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.cInterlockedInstructions"]/*'/>

    public uint CInterlockedInstructions;

    /// <include file='D3D12_SHADER_DESC.xml' path='doc/member[@name="D3D12_SHADER_DESC.cTextureStoreInstructions"]/*'/>

    public uint CTextureStoreInstructions;
}
