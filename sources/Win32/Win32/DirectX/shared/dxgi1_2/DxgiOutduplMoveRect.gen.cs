// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTDUPL_MOVE_RECT.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT"]/*'/>
public partial struct DxgiOutduplMoveRect
{
    /// <include file='DXGI_OUTDUPL_MOVE_RECT.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT.SourcePoint"]/*'/>

    public Point SourcePoint;

    /// <include file='DXGI_OUTDUPL_MOVE_RECT.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT.DestinationRect"]/*'/>

    public RECT DestinationRect;
}
