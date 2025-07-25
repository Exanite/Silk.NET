// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_HIT_KIND.xml' path='doc/member[@name="D3D12_HIT_KIND"]/*'/>
public enum D3D12HitKind
{
    /// <include file='D3D12_HIT_KIND.xml' path='doc/member[@name="D3D12_HIT_KIND.D3D12_HIT_KIND_TRIANGLE_FRONT_FACE"]/*'/>

    FrontFace = 0xfe,

    /// <include file='D3D12_HIT_KIND.xml' path='doc/member[@name="D3D12_HIT_KIND.D3D12_HIT_KIND_TRIANGLE_BACK_FACE"]/*'/>

    BackFace = 0xff,
}
