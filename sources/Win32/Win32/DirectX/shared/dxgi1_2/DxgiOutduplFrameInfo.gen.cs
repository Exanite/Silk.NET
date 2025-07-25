// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO"]/*'/>
public partial struct DxgiOutduplFrameInfo
{
    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.LastPresentTime"]/*'/>

    public LargeInteger LastPresentTime;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.LastMouseUpdateTime"]/*'/>

    public LargeInteger LastMouseUpdateTime;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.AccumulatedFrames"]/*'/>

    public uint AccumulatedFrames;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.RectsCoalesced"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> RectsCoalesced;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.ProtectedContentMaskedOut"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> ProtectedContentMaskedOut;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.PointerPosition"]/*'/>

    public DxgiOutduplPointerPosition PointerPosition;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.TotalMetadataBufferSize"]/*'/>

    public uint TotalMetadataBufferSize;

    /// <include file='DXGI_OUTDUPL_FRAME_INFO.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO.PointerShapeBufferSize"]/*'/>

    public uint PointerShapeBufferSize;
}
