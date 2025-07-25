// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FILL_MODE.xml' path='doc/member[@name="D3D12_FILL_MODE"]/*'/>
public enum D3D12FillMode
{
    /// <include file='D3D12_FILL_MODE.xml' path='doc/member[@name="D3D12_FILL_MODE.D3D12_FILL_MODE_WIREFRAME"]/*'/>

    Wireframe = 2,

    /// <include file='D3D12_FILL_MODE.xml' path='doc/member[@name="D3D12_FILL_MODE.D3D12_FILL_MODE_SOLID"]/*'/>

    Solid = 3,
}
