// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE"]/*'/>
public enum D3D12MetaCommandParameterStage
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_CREATION"]/*'/>

    Creation = 0,

    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION"]/*'/>

    Initialization = 1,

    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION"]/*'/>

    Execution = 2,
}
