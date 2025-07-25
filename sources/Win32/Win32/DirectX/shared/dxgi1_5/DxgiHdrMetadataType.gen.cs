// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE"]/*'/>
public enum DxgiHdrMetadataType
{
    /// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE.DXGI_HDR_METADATA_TYPE_NONE"]/*'/>

    None = 0,

    /// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE.DXGI_HDR_METADATA_TYPE_HDR10"]/*'/>

    Hdr10 = 1,

    /// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE.DXGI_HDR_METADATA_TYPE_HDR10PLUS"]/*'/>

    Hdr10Plus = 2,
}
