// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_GLOBAL_BARRIER.xml' path='doc/member[@name="D3D12_GLOBAL_BARRIER"]/*'/>
public partial struct D3D12GlobalBarrier
{
    /// <include file='D3D12_GLOBAL_BARRIER.xml' path='doc/member[@name="D3D12_GLOBAL_BARRIER.SyncBefore"]/*'/>

    public D3D12BarrierSync SyncBefore;

    /// <include file='D3D12_GLOBAL_BARRIER.xml' path='doc/member[@name="D3D12_GLOBAL_BARRIER.SyncAfter"]/*'/>

    public D3D12BarrierSync SyncAfter;

    /// <include file='D3D12_GLOBAL_BARRIER.xml' path='doc/member[@name="D3D12_GLOBAL_BARRIER.AccessBefore"]/*'/>

    public D3D12BarrierAccess AccessBefore;

    /// <include file='D3D12_GLOBAL_BARRIER.xml' path='doc/member[@name="D3D12_GLOBAL_BARRIER.AccessAfter"]/*'/>

    public D3D12BarrierAccess AccessAfter;
}
