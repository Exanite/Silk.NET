// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS"]/*'/>
public unsafe partial struct D3D12RenderPassEndingAccessResolveParameters
{
    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.pSrcResource"]/*'/>

    public ID3D12Resource PSrcResource;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.pDstResource"]/*'/>

    public ID3D12Resource PDstResource;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.SubresourceCount"]/*'/>

    public uint SubresourceCount;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.pSubresourceParameters"]/*'/>

    [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS *")]
    public D3D12RenderPassEndingAccessResolveSubresourceParameters* PSubresourceParameters;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.ResolveMode"]/*'/>

    public D3D12ResolveMode ResolveMode;

    /// <include file='D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.xml' path='doc/member[@name="D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS.PreserveResolveSource"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> PreserveResolveSource;
}
