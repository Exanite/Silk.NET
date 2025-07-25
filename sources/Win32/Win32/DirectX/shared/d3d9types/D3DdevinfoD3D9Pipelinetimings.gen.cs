// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDEVINFO_D3D9PIPELINETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9PIPELINETIMINGS"]/*'/>
public partial struct D3DdevinfoD3D9Pipelinetimings
{
    /// <include file='D3DDEVINFO_D3D9PIPELINETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9PIPELINETIMINGS.VertexProcessingTimePercent"]/*'/>

    public float VertexProcessingTimePercent;

    /// <include file='D3DDEVINFO_D3D9PIPELINETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9PIPELINETIMINGS.PixelProcessingTimePercent"]/*'/>

    public float PixelProcessingTimePercent;

    /// <include file='D3DDEVINFO_D3D9PIPELINETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9PIPELINETIMINGS.OtherGPUProcessingTimePercent"]/*'/>

    public float OtherGPUProcessingTimePercent;

    /// <include file='D3DDEVINFO_D3D9PIPELINETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9PIPELINETIMINGS.GPUIdleTimePercent"]/*'/>

    public float GPUIdleTimePercent;
}
