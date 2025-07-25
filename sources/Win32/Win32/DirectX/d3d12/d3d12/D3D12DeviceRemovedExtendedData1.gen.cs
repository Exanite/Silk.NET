// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1"]/*'/>
public partial struct D3D12DeviceRemovedExtendedData1
{
    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1.DeviceRemovedReason"]/*'/>

    public HResult DeviceRemovedReason;

    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1.AutoBreadcrumbsOutput"]/*'/>

    public D3D12DredAutoBreadcrumbsOutput AutoBreadcrumbsOutput;

    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1.PageFaultOutput"]/*'/>

    public D3D12DredPageFaultOutput PageFaultOutput;
}
