// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER"]/*'/>
public partial struct D3D12SerializedRaytracingAccelerationStructureHeader
{
    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.DriverMatchingIdentifier"]/*'/>

    public D3D12SerializedDataDriverMatchingIdentifier DriverMatchingIdentifier;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.SerializedSizeInBytesIncludingHeader"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong SerializedSizeInBytesIncludingHeader;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.DeserializedSizeInBytes"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong DeserializedSizeInBytes;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.NumBottomLevelAccelerationStructurePointersAfterHeader"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
}
