// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC"]/*'/>
public unsafe partial struct D3D12ExistingCollectionDesc
{
    /// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC.pExistingCollection"]/*'/>

    public ID3D12StateObject PExistingCollection;

    /// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC.NumExports"]/*'/>

    public uint NumExports;

    /// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC.pExports"]/*'/>

    [NativeTypeName("const D3D12_EXPORT_DESC *")]
    public D3D12ExportDesc* PExports;
}
