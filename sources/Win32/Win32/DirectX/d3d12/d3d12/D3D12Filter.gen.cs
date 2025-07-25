// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER"]/*'/>
public enum D3D12Filter
{
    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_MIP_POINT"]/*'/>

    MinMagMipPoint = 0,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR"]/*'/>

    MinMagPointMipLinear = 0x1,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>

    MinPointMagLinearMipPoint = 0x4,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR"]/*'/>

    MinPointMagMipLinear = 0x5,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT"]/*'/>

    MinLinearMagMipPoint = 0x10,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>

    MinLinearMagPointMipLinear = 0x11,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT"]/*'/>

    MinMagLinearMipPoint = 0x14,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_MIP_LINEAR"]/*'/>

    MinMagMipLinear = 0x15,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MIN_MAG_ANISOTROPIC_MIP_POINT"]/*'/>

    MinMagAnisotropicMipPoint = 0x54,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_ANISOTROPIC"]/*'/>

    Anisotropic = 0x55,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT"]/*'/>

    ComparisonMinMagMipPoint = 0x80,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR"]/*'/>

    ComparisonMinMagPointMipLinear = 0x81,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>

    ComparisonMinPointMagLinearMipPoint = 0x84,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR"]/*'/>

    ComparisonMinPointMagMipLinear = 0x85,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT"]/*'/>

    ComparisonMinLinearMagMipPoint = 0x90,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>

    ComparisonMinLinearMagPointMipLinear = 0x91,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT"]/*'/>

    ComparisonMinMagLinearMipPoint = 0x94,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR"]/*'/>

    ComparisonMinMagMipLinear = 0x95,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_MIN_MAG_ANISOTROPIC_MIP_POINT"]/*'/>

    ComparisonMinMagAnisotropicMipPoint = 0xd4,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_COMPARISON_ANISOTROPIC"]/*'/>

    ComparisonAnisotropic = 0xd5,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT"]/*'/>

    MinimumMinMagMipPoint = 0x100,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR"]/*'/>

    MinimumMinMagPointMipLinear = 0x101,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>

    MinimumMinPointMagLinearMipPoint = 0x104,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR"]/*'/>

    MinimumMinPointMagMipLinear = 0x105,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT"]/*'/>

    MinimumMinLinearMagMipPoint = 0x110,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>

    MinimumMinLinearMagPointMipLinear = 0x111,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT"]/*'/>

    MinimumMinMagLinearMipPoint = 0x114,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR"]/*'/>

    MinimumMinMagMipLinear = 0x115,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_MIN_MAG_ANISOTROPIC_MIP_POINT"]/*'/>

    MinimumMinMagAnisotropicMipPoint = 0x154,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MINIMUM_ANISOTROPIC"]/*'/>

    MinimumAnisotropic = 0x155,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT"]/*'/>

    MaximumMinMagMipPoint = 0x180,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR"]/*'/>

    MaximumMinMagPointMipLinear = 0x181,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT"]/*'/>

    MaximumMinPointMagLinearMipPoint = 0x184,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR"]/*'/>

    MaximumMinPointMagMipLinear = 0x185,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT"]/*'/>

    MaximumMinLinearMagMipPoint = 0x190,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR"]/*'/>

    MaximumMinLinearMagPointMipLinear = 0x191,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT"]/*'/>

    MaximumMinMagLinearMipPoint = 0x194,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR"]/*'/>

    MaximumMinMagMipLinear = 0x195,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_MIN_MAG_ANISOTROPIC_MIP_POINT"]/*'/>

    MaximumMinMagAnisotropicMipPoint = 0x1d4,

    /// <include file='D3D12_FILTER.xml' path='doc/member[@name="D3D12_FILTER.D3D12_FILTER_MAXIMUM_ANISOTROPIC"]/*'/>

    MaximumAnisotropic = 0x1d5,
}
