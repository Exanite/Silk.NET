// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE"]/*'/>
public enum D3D12RenderPassBeginningAccessType
{
    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_DISCARD"]/*'/>

    Discard = 0,

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE"]/*'/>

    Preserve = (Discard + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR"]/*'/>

    Clear = (Preserve + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_NO_ACCESS"]/*'/>

    NoAccess = (Clear + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER"]/*'/>

    PreserveLocalRender = (NoAccess + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_SRV"]/*'/>

    PreserveLocalSrv = (PreserveLocalRender + 1),

    /// <include file='D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE.D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_PRESERVE_LOCAL_UAV"]/*'/>

    PreserveLocalUav = (PreserveLocalSrv + 1),
}
