// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12VideoExtensionCommandParameterInfo
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.Name"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.Type"]/*'/>

    public D3D12VideoExtensionCommandParameterType Type;

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO.Flags"]/*'/>

    public D3D12VideoExtensionCommandParameterFlags Flags;
}
