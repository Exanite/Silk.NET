// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER"]/*'/>
public enum D3D12ShadingRateCombiner
{
    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_PASSTHROUGH"]/*'/>

    Passthrough = 0,

    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_OVERRIDE"]/*'/>

    Override = 1,

    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_MIN"]/*'/>

    Min = 2,

    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_MAX"]/*'/>

    Max = 3,

    /// <include file='D3D12_SHADING_RATE_COMBINER.xml' path='doc/member[@name="D3D12_SHADING_RATE_COMBINER.D3D12_SHADING_RATE_COMBINER_SUM"]/*'/>

    Sum = 4,
}
