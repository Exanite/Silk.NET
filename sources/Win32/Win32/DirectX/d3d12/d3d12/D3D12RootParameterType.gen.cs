// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE"]/*'/>
public enum D3D12RootParameterType
{
    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE"]/*'/>

    TypeDescriptorTable = 0,

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS"]/*'/>

    Type32BitConstants = (TypeDescriptorTable + 1),

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_CBV"]/*'/>

    TypeCbv = (Type32BitConstants + 1),

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_SRV"]/*'/>

    TypeSrv = (TypeCbv + 1),

    /// <include file='D3D12_ROOT_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER_TYPE.D3D12_ROOT_PARAMETER_TYPE_UAV"]/*'/>

    TypeUav = (TypeSrv + 1),
}
