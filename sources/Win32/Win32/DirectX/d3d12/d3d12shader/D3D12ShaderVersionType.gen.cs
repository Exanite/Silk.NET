// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE"]/*'/>
public enum D3D12ShaderVersionType
{
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_PIXEL_SHADER"]/*'/>

    PixelShader = 0,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_VERTEX_SHADER"]/*'/>

    VertexShader = 1,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_GEOMETRY_SHADER"]/*'/>

    GeometryShader = 2,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_HULL_SHADER"]/*'/>

    HullShader = 3,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_DOMAIN_SHADER"]/*'/>

    DomainShader = 4,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_COMPUTE_SHADER"]/*'/>

    ComputeShader = 5,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_LIBRARY"]/*'/>

    Library = 6,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_RAY_GENERATION_SHADER"]/*'/>

    RayGenerationShader = 7,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_INTERSECTION_SHADER"]/*'/>

    IntersectionShader = 8,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_ANY_HIT_SHADER"]/*'/>

    AnyHitShader = 9,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_CLOSEST_HIT_SHADER"]/*'/>

    ClosestHitShader = 10,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_MISS_SHADER"]/*'/>

    MissShader = 11,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_CALLABLE_SHADER"]/*'/>

    CallableShader = 12,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_MESH_SHADER"]/*'/>

    MeshShader = 13,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_AMPLIFICATION_SHADER"]/*'/>

    AmplificationShader = 14,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_NODE_SHADER"]/*'/>

    NodeShader = 15,

    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_RESERVED0"]/*'/>

    Reserved0 = 0xFFF0,
}
