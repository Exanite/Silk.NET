// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY"]/*'/>
public enum DxgiComputePreemptionGranularity
{
    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY"]/*'/>

    DmaBufferBoundary = 0,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY"]/*'/>

    DispatchBoundary = 1,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY"]/*'/>

    ThreadGroupBoundary = 2,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY"]/*'/>

    ThreadBoundary = 3,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY"]/*'/>

    InstructionBoundary = 4,
}
