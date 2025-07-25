// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MEMORY_SEGMENT_GROUP.xml' path='doc/member[@name="DXGI_MEMORY_SEGMENT_GROUP"]/*'/>
public enum DxgiMemorySegmentGroup
{
    /// <include file='DXGI_MEMORY_SEGMENT_GROUP.xml' path='doc/member[@name="DXGI_MEMORY_SEGMENT_GROUP.DXGI_MEMORY_SEGMENT_GROUP_LOCAL"]/*'/>

    Local = 0,

    /// <include file='DXGI_MEMORY_SEGMENT_GROUP.xml' path='doc/member[@name="DXGI_MEMORY_SEGMENT_GROUP.DXGI_MEMORY_SEGMENT_GROUP_NON_LOCAL"]/*'/>

    NonLocal = 1,
}
