// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE"]/*'/>
public enum D3D12TextureAddressMode
{
    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_WRAP"]/*'/>

    Wrap = 1,

    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_MIRROR"]/*'/>

    Mirror = 2,

    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_CLAMP"]/*'/>

    Clamp = 3,

    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_BORDER"]/*'/>

    Border = 4,

    /// <include file='D3D12_TEXTURE_ADDRESS_MODE.xml' path='doc/member[@name="D3D12_TEXTURE_ADDRESS_MODE.D3D12_TEXTURE_ADDRESS_MODE_MIRROR_ONCE"]/*'/>

    MirrorOnce = 5,
}
