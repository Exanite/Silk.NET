// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION"]/*'/>
public enum D3D12MeasurementsAction
{
    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_KEEP_ALL"]/*'/>

    KeepAll = 0,

    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS"]/*'/>

    CommitResults = (KeepAll + 1),

    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_COMMIT_RESULTS_HIGH_PRIORITY"]/*'/>

    CommitResultsHighPriority = (CommitResults + 1),

    /// <include file='D3D12_MEASUREMENTS_ACTION.xml' path='doc/member[@name="D3D12_MEASUREMENTS_ACTION.D3D12_MEASUREMENTS_ACTION_DISCARD_PREVIOUS"]/*'/>

    DiscardPrevious = (CommitResultsHighPriority + 1),
}
