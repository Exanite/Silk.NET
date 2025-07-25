// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12FeatureDataVideoExtensionCommandSupport
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.CommandId"]/*'/>

    public Guid CommandId;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.pInputData"]/*'/>

    [NativeTypeName("const void *")]
    public void* PInputData;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.InputDataSizeInBytes"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint InputDataSizeInBytes;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.pOutputData"]/*'/>

    public void* POutputData;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT.OutputDataSizeInBytes"]/*'/>

    [NativeTypeName("SIZE_T")]
    public nuint OutputDataSizeInBytes;
}
