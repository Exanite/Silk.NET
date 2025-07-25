// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.xml' path='doc/member[@name="D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN"]/*'/>
public enum D3D10SbConstantBufferAccessPattern
{
    /// <include file='D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.xml' path='doc/member[@name="D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.D3D10_SB_CONSTANT_BUFFER_IMMEDIATE_INDEXED"]/*'/>

    ImmediateIndexed = 0,

    /// <include file='D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.xml' path='doc/member[@name="D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN.D3D10_SB_CONSTANT_BUFFER_DYNAMIC_INDEXED"]/*'/>

    DynamicIndexed = 1,
}
