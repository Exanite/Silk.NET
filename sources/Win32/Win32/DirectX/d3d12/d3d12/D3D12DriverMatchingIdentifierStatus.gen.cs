// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.xml' path='doc/member[@name="D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS"]/*'/>
public enum D3D12DriverMatchingIdentifierStatus
{
    /// <include file='D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.xml' path='doc/member[@name="D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.D3D12_DRIVER_MATCHING_IDENTIFIER_COMPATIBLE_WITH_DEVICE"]/*'/>

    CompatibleWithDevice = 0,

    /// <include file='D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.xml' path='doc/member[@name="D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.D3D12_DRIVER_MATCHING_IDENTIFIER_UNSUPPORTED_TYPE"]/*'/>

    UnsupportedType = 0x1,

    /// <include file='D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.xml' path='doc/member[@name="D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.D3D12_DRIVER_MATCHING_IDENTIFIER_UNRECOGNIZED"]/*'/>

    Unrecognized = 0x2,

    /// <include file='D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.xml' path='doc/member[@name="D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_VERSION"]/*'/>

    IncompatibleVersion = 0x3,

    /// <include file='D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.xml' path='doc/member[@name="D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS.D3D12_DRIVER_MATCHING_IDENTIFIER_INCOMPATIBLE_TYPE"]/*'/>

    IncompatibleType = 0x4,
}
