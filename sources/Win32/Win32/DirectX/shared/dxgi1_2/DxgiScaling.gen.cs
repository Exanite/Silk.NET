// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING"]/*'/>
public enum DxgiScaling
{
    /// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING.DXGI_SCALING_STRETCH"]/*'/>

    Stretch = 0,

    /// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING.DXGI_SCALING_NONE"]/*'/>

    None = 1,

    /// <include file='DXGI_SCALING.xml' path='doc/member[@name="DXGI_SCALING.DXGI_SCALING_ASPECT_RATIO_STRETCH"]/*'/>

    AspectRatioStretch = 2,
}
