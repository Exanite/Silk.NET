// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC"]/*'/>
public partial struct D3D12DispatchRaysDesc
{
    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.RayGenerationShaderRecord"]/*'/>

    public D3D12GpuVirtualAddressRange RayGenerationShaderRecord;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.MissShaderTable"]/*'/>

    public D3D12GpuVirtualAddressRangeAndStride MissShaderTable;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.HitGroupTable"]/*'/>

    public D3D12GpuVirtualAddressRangeAndStride HitGroupTable;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.CallableShaderTable"]/*'/>

    public D3D12GpuVirtualAddressRangeAndStride CallableShaderTable;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.Width"]/*'/>

    public uint Width;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.Height"]/*'/>

    public uint Height;

    /// <include file='D3D12_DISPATCH_RAYS_DESC.xml' path='doc/member[@name="D3D12_DISPATCH_RAYS_DESC.Depth"]/*'/>

    public uint Depth;
}
