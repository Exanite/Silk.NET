// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY"]/*'/>
public enum D3D12ShaderVisibility
{
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_ALL"]/*'/>

    All = 0,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_VERTEX"]/*'/>

    Vertex = 1,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_HULL"]/*'/>

    Hull = 2,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_DOMAIN"]/*'/>

    Domain = 3,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_GEOMETRY"]/*'/>

    Geometry = 4,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_PIXEL"]/*'/>

    Pixel = 5,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_AMPLIFICATION"]/*'/>

    Amplification = 6,

    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_MESH"]/*'/>

    Mesh = 7,
}
