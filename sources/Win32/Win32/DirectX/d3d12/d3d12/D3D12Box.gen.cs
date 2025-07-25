// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX"]/*'/>
public partial struct D3D12Box
{
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.left"]/*'/>

    public uint Left;

    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.top"]/*'/>

    public uint Top;

    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.front"]/*'/>

    public uint Front;

    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.right"]/*'/>

    public uint Right;

    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.bottom"]/*'/>

    public uint Bottom;

    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.back"]/*'/>

    public uint Back;
}
