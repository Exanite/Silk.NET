// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT"]/*'/>
public partial struct D3D12Viewport
{
    /// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT.TopLeftX"]/*'/>

    public float TopLeftX;

    /// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT.TopLeftY"]/*'/>

    public float TopLeftY;

    /// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT.Width"]/*'/>

    public float Width;

    /// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT.Height"]/*'/>

    public float Height;

    /// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT.MinDepth"]/*'/>

    public float MinDepth;

    /// <include file='D3D12_VIEWPORT.xml' path='doc/member[@name="D3D12_VIEWPORT.MaxDepth"]/*'/>

    public float MaxDepth;
}
