// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP"]/*'/>
public enum D3D12StencilOp
{
    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_KEEP"]/*'/>

    Keep = 1,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_ZERO"]/*'/>

    Zero = 2,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_REPLACE"]/*'/>

    Replace = 3,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_INCR_SAT"]/*'/>

    IncrSat = 4,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_DECR_SAT"]/*'/>

    DecrSat = 5,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_INVERT"]/*'/>

    Invert = 6,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_INCR"]/*'/>

    Incr = 7,

    /// <include file='D3D12_STENCIL_OP.xml' path='doc/member[@name="D3D12_STENCIL_OP.D3D12_STENCIL_OP_DECR"]/*'/>

    Decr = 8,
}
