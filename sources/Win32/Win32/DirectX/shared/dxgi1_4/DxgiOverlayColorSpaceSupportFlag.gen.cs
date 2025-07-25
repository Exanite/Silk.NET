// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum DxgiOverlayColorSpaceSupportFlag
{
    /// <include file='DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG.xml' path='doc/member[@name="DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG.DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG_PRESENT"]/*'/>

    Present = 0x1,
}
