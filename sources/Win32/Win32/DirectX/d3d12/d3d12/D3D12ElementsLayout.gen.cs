// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_ELEMENTS_LAYOUT.xml' path='doc/member[@name="D3D12_ELEMENTS_LAYOUT"]/*'/>
public enum D3D12ElementsLayout
{
    /// <include file='D3D12_ELEMENTS_LAYOUT.xml' path='doc/member[@name="D3D12_ELEMENTS_LAYOUT.D3D12_ELEMENTS_LAYOUT_ARRAY"]/*'/>

    Array = 0,

    /// <include file='D3D12_ELEMENTS_LAYOUT.xml' path='doc/member[@name="D3D12_ELEMENTS_LAYOUT.D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS"]/*'/>

    ArrayOfPointers = 0x1,
}
