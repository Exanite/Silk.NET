// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_PIPELINE_CONFIG1.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_CONFIG1"]/*'/>
public partial struct D3D12RaytracingPipelineConfig1
{
    /// <include file='D3D12_RAYTRACING_PIPELINE_CONFIG1.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_CONFIG1.MaxTraceRecursionDepth"]/*'/>

    public uint MaxTraceRecursionDepth;

    /// <include file='D3D12_RAYTRACING_PIPELINE_CONFIG1.xml' path='doc/member[@name="D3D12_RAYTRACING_PIPELINE_CONFIG1.Flags"]/*'/>

    public D3D12RaytracingPipelineFlags Flags;
}
