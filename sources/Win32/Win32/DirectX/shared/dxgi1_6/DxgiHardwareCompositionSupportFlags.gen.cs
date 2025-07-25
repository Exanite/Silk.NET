// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum DxgiHardwareCompositionSupportFlags
{
    /// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_FULLSCREEN"]/*'/>

    Fullscreen = 1,

    /// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_WINDOWED"]/*'/>

    Windowed = 2,

    /// <include file='DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.xml' path='doc/member[@name="DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS.DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG_CURSOR_STRETCHED"]/*'/>

    CursorStretched = 4,
}
