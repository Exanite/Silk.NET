// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_PROTECTED_SESSION_STATUS.xml' path='doc/member[@name="D3D12_PROTECTED_SESSION_STATUS"]/*'/>
public enum D3D12ProtectedSessionStatus
{
    /// <include file='D3D12_PROTECTED_SESSION_STATUS.xml' path='doc/member[@name="D3D12_PROTECTED_SESSION_STATUS.D3D12_PROTECTED_SESSION_STATUS_OK"]/*'/>

    Ok = 0,

    /// <include file='D3D12_PROTECTED_SESSION_STATUS.xml' path='doc/member[@name="D3D12_PROTECTED_SESSION_STATUS.D3D12_PROTECTED_SESSION_STATUS_INVALID"]/*'/>

    Invalid = 1,
}
