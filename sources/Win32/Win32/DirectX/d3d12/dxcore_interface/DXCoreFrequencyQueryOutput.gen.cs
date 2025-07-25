// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreFrequencyQueryOutput.xml' path='doc/member[@name="DXCoreFrequencyQueryOutput"]/*'/>
public partial struct DXCoreFrequencyQueryOutput
{
    /// <include file='DXCoreFrequencyQueryOutput.xml' path='doc/member[@name="DXCoreFrequencyQueryOutput.frequency"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong Frequency;

    /// <include file='DXCoreFrequencyQueryOutput.xml' path='doc/member[@name="DXCoreFrequencyQueryOutput.maxFrequency"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong MaxFrequency;

    /// <include file='DXCoreFrequencyQueryOutput.xml' path='doc/member[@name="DXCoreFrequencyQueryOutput.maxOverclockedFrequency"]/*'/>

    [NativeTypeName("uint64_t")]
    public ulong MaxOverclockedFrequency;
}
