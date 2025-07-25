// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC"]/*'/>
public partial struct D3D12BlendDesc
{
    /// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC.AlphaToCoverageEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AlphaToCoverageEnable;

    /// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC.IndependentBlendEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> IndependentBlendEnable;

    /// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC.RenderTarget"]/*'/>

    [NativeTypeName("D3D12_RENDER_TARGET_BLEND_DESC[8]")]
    public _RenderTarget_e__FixedBuffer RenderTarget;

    /// <include file='_RenderTarget_e__FixedBuffer.xml' path='doc/member[@name="_RenderTarget_e__FixedBuffer"]/*'/>

    [InlineArray(8)]
    public partial struct _RenderTarget_e__FixedBuffer
    {
        public D3D12RenderTargetBlendDesc e0;
    }
}
