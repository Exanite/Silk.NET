// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_PRESENT_PARAMETERS.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS"]/*'/>
public unsafe partial struct DxgiPresentParameters
{
    /// <include file='DXGI_PRESENT_PARAMETERS.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS.DirtyRectsCount"]/*'/>

    public uint DirtyRectsCount;

    /// <include file='DXGI_PRESENT_PARAMETERS.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS.pDirtyRects"]/*'/>

    public RECT* PDirtyRects;

    /// <include file='DXGI_PRESENT_PARAMETERS.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS.pScrollRect"]/*'/>

    public RECT* PScrollRect;

    /// <include file='DXGI_PRESENT_PARAMETERS.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS.pScrollOffset"]/*'/>

    public Point* PScrollOffset;
}
