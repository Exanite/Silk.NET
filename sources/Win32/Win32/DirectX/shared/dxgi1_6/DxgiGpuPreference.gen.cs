// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE"]/*'/>
public enum DxgiGpuPreference
{
    /// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_UNSPECIFIED"]/*'/>

    Unspecified = 0,

    /// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_MINIMUM_POWER"]/*'/>

    MinimumPower = (Unspecified + 1),

    /// <include file='DXGI_GPU_PREFERENCE.xml' path='doc/member[@name="DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE"]/*'/>

    HighPerformance = (MinimumPower + 1),
}
