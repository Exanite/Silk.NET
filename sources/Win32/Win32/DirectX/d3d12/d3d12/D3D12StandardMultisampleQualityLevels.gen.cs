// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS"]/*'/>
public enum D3D12StandardMultisampleQualityLevels
{
    /// <include file='D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS.D3D12_STANDARD_MULTISAMPLE_PATTERN"]/*'/>

    StandardMultisamplePattern = unchecked((int)(0xffffffff)),

    /// <include file='D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS.xml' path='doc/member[@name="D3D12_STANDARD_MULTISAMPLE_QUALITY_LEVELS.D3D12_CENTER_MULTISAMPLE_PATTERN"]/*'/>

    CenterMultisamplePattern = unchecked((int)(0xfffffffe)),
}
