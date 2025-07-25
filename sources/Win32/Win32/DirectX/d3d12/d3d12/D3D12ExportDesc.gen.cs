// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC"]/*'/>
public unsafe partial struct D3D12ExportDesc
{
    /// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC.Name"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC.ExportToRename"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* ExportToRename;

    /// <include file='D3D12_EXPORT_DESC.xml' path='doc/member[@name="D3D12_EXPORT_DESC.Flags"]/*'/>

    public D3D12ExportFlags Flags;
}
