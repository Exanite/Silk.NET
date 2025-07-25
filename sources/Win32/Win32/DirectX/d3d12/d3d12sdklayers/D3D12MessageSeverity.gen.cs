// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY"]/*'/>
public enum D3D12MessageSeverity
{
    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_CORRUPTION"]/*'/>

    Corruption = 0,

    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_ERROR"]/*'/>

    Error = (Corruption + 1),

    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_WARNING"]/*'/>

    Warning = (Error + 1),

    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_INFO"]/*'/>

    Info = (Warning + 1),

    /// <include file='D3D12_MESSAGE_SEVERITY.xml' path='doc/member[@name="D3D12_MESSAGE_SEVERITY.D3D12_MESSAGE_SEVERITY_MESSAGE"]/*'/>

    Message = (Info + 1),
}
