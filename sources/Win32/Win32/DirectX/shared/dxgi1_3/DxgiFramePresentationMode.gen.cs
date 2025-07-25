// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE"]/*'/>
public enum DxgiFramePresentationMode
{
    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_COMPOSED"]/*'/>

    Composed = 0,

    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_OVERLAY"]/*'/>

    Overlay = 1,

    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_NONE"]/*'/>

    None = 2,

    /// <include file='DXGI_FRAME_PRESENTATION_MODE.xml' path='doc/member[@name="DXGI_FRAME_PRESENTATION_MODE.DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE"]/*'/>

    CompositionFailure = 3,
}
