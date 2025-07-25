// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE"]/*'/>
public enum D3D12FilterReductionType
{
    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_STANDARD"]/*'/>

    Standard = 0,

    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_COMPARISON"]/*'/>

    Comparison = 1,

    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_MINIMUM"]/*'/>

    Minimum = 2,

    /// <include file='D3D12_FILTER_REDUCTION_TYPE.xml' path='doc/member[@name="D3D12_FILTER_REDUCTION_TYPE.D3D12_FILTER_REDUCTION_TYPE_MAXIMUM"]/*'/>

    Maximum = 3,
}
