// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.xml' path='doc/member[@name="DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS"]/*'/>
[Flags]
public enum DXGIMultiplaneOverlayYCbCrFlags
{
    /// <include file='DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.xml' path='doc/member[@name="DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_NOMINAL_RANGE"]/*'/>

    CbCrFLAGNominalRange = 0x1,

    /// <include file='DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.xml' path='doc/member[@name="DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_BT709"]/*'/>

    CbCrFLAGBT709 = 0x2,

    /// <include file='DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.xml' path='doc/member[@name="DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS.DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAG_xvYCC"]/*'/>

    CbCrFLAGXvYCC = 0x4,
}
