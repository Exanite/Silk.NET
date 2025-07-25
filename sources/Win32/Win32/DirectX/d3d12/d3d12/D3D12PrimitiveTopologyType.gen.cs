// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE"]/*'/>
public enum D3D12PrimitiveTopologyType
{
    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_UNDEFINED"]/*'/>

    Undefined = 0,

    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_POINT"]/*'/>

    Point = 1,

    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_LINE"]/*'/>

    Line = 2,

    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE"]/*'/>

    Triangle = 3,

    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_PATCH"]/*'/>

    Patch = 4,
}
