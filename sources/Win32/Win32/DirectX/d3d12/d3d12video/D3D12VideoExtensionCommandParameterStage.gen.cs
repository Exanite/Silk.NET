// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12VideoExtensionCommandParameterStage
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CREATION"]/*'/>

    Creation = 0,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_INITIALIZATION"]/*'/>

    Initialization = 1,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_EXECUTION"]/*'/>

    Execution = 2,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_INPUT"]/*'/>

    CapsInput = 3,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_OUTPUT"]/*'/>

    CapsOutput = 4,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_INPUT"]/*'/>

    DeviceExecuteInput = 5,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_OUTPUT"]/*'/>

    DeviceExecuteOutput = 6,
}
