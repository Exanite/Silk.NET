// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE"]/*'/>
public enum D3D10SbTokenizedProgramType
{
    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D10_SB_PIXEL_SHADER"]/*'/>

    X10SbPixelShader = 0,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D10_SB_VERTEX_SHADER"]/*'/>

    X10SbVertexShader = 1,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D10_SB_GEOMETRY_SHADER"]/*'/>

    X10SbGeometryShader = 2,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_HULL_SHADER"]/*'/>

    X11SbHullShader = 3,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_DOMAIN_SHADER"]/*'/>

    X11SbDomainShader = 4,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_COMPUTE_SHADER"]/*'/>

    X11SbComputeShader = 5,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D12_SB_MESH_SHADER"]/*'/>

    X12SbMeshShader = 13,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D12_SB_AMPLIFICATION_SHADER"]/*'/>

    X12SbAmplificationShader = 14,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_RESERVED0"]/*'/>

    X11SbReserved0 = 0xFFF0,
}
