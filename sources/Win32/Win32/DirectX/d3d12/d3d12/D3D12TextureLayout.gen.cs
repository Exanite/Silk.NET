// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT"]/*'/>
public enum D3D12TextureLayout
{
    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_UNKNOWN"]/*'/>

    LayoutUnknown = 0,

    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_ROW_MAJOR"]/*'/>

    LayoutRowMajor = 1,

    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE"]/*'/>

    Layout64KbUndefinedSwizzle = 2,

    /// <include file='D3D12_TEXTURE_LAYOUT.xml' path='doc/member[@name="D3D12_TEXTURE_LAYOUT.D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE"]/*'/>

    Layout64KbStandardSwizzle = 3,
}
