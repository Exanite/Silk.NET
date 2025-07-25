// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER"]/*'/>
public unsafe partial struct D3D12ResourceTransitionBarrier
{
    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.pResource"]/*'/>

    public ID3D12Resource PResource;

    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.Subresource"]/*'/>

    public uint Subresource;

    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.StateBefore"]/*'/>

    public D3D12ResourceStates StateBefore;

    /// <include file='D3D12_RESOURCE_TRANSITION_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_TRANSITION_BARRIER.StateAfter"]/*'/>

    public D3D12ResourceStates StateAfter;
}
