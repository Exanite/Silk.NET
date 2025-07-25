// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC"]/*'/>
public enum D3D12ComparisonFunc
{
    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NEVER"]/*'/>

    Never = 1,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_LESS"]/*'/>

    Less = 2,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_EQUAL"]/*'/>

    Equal = 3,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_LESS_EQUAL"]/*'/>

    LessEqual = 4,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_GREATER"]/*'/>

    Greater = 5,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_NOT_EQUAL"]/*'/>

    NotEqual = 6,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_GREATER_EQUAL"]/*'/>

    GreaterEqual = 7,

    /// <include file='D3D12_COMPARISON_FUNC.xml' path='doc/member[@name="D3D12_COMPARISON_FUNC.D3D12_COMPARISON_FUNC_ALWAYS"]/*'/>

    Always = 8,
}
