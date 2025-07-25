// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_TRI_STATE.xml' path='doc/member[@name="D3D12_TRI_STATE"]/*'/>
public enum D3D12TriState
{
    /// <include file='D3D12_TRI_STATE.xml' path='doc/member[@name="D3D12_TRI_STATE.D3D12_TRI_STATE_UNKNOWN"]/*'/>

    Unknown = -1,

    /// <include file='D3D12_TRI_STATE.xml' path='doc/member[@name="D3D12_TRI_STATE.D3D12_TRI_STATE_FALSE"]/*'/>

    False = 0,

    /// <include file='D3D12_TRI_STATE.xml' path='doc/member[@name="D3D12_TRI_STATE.D3D12_TRI_STATE_TRUE"]/*'/>

    True = 1,
}
