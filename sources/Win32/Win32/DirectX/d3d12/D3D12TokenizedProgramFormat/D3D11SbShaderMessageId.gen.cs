// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D11_SB_SHADER_MESSAGE_ID.xml' path='doc/member[@name="D3D11_SB_SHADER_MESSAGE_ID"]/*'/>
public enum D3D11SbShaderMessageId
{
    /// <include file='D3D11_SB_SHADER_MESSAGE_ID.xml' path='doc/member[@name="D3D11_SB_SHADER_MESSAGE_ID.D3D11_SB_SHADER_MESSAGE_ID_MESSAGE"]/*'/>

    Message = 0x00200102,

    /// <include file='D3D11_SB_SHADER_MESSAGE_ID.xml' path='doc/member[@name="D3D11_SB_SHADER_MESSAGE_ID.D3D11_SB_SHADER_MESSAGE_ID_ERROR"]/*'/>

    Error = 0x00200103,
}
