// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE"]/*'/>
public enum D3D12IndexBufferStripCutValue
{
    /// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED"]/*'/>

    ValueDisabled = 0,

    /// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF"]/*'/>

    Value0XFFFF = 1,

    /// <include file='D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_STRIP_CUT_VALUE.D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF"]/*'/>

    Value0XFfffffff = 2,
}
