// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDEVINFO_D3D9INTERFACETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9INTERFACETIMINGS"]/*'/>
public partial struct D3DdevinfoD3D9Interfacetimings
{
    /// <include file='D3DDEVINFO_D3D9INTERFACETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9INTERFACETIMINGS.WaitingForGPUToUseApplicationResourceTimePercent"]/*'/>

    public float WaitingForGPUToUseApplicationResourceTimePercent;

    /// <include file='D3DDEVINFO_D3D9INTERFACETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9INTERFACETIMINGS.WaitingForGPUToAcceptMoreCommandsTimePercent"]/*'/>

    public float WaitingForGPUToAcceptMoreCommandsTimePercent;

    /// <include file='D3DDEVINFO_D3D9INTERFACETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9INTERFACETIMINGS.WaitingForGPUToStayWithinLatencyTimePercent"]/*'/>

    public float WaitingForGPUToStayWithinLatencyTimePercent;

    /// <include file='D3DDEVINFO_D3D9INTERFACETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9INTERFACETIMINGS.WaitingForGPUExclusiveResourceTimePercent"]/*'/>

    public float WaitingForGPUExclusiveResourceTimePercent;

    /// <include file='D3DDEVINFO_D3D9INTERFACETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9INTERFACETIMINGS.WaitingForGPUOtherTimePercent"]/*'/>

    public float WaitingForGPUOtherTimePercent;
}
