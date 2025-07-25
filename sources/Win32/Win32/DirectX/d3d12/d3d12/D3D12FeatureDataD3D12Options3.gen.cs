// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3"]/*'/>
public partial struct D3D12FeatureDataD3D12Options3
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.CopyQueueTimestampQueriesSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> CopyQueueTimestampQueriesSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.CastingFullyTypedFormatSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> CastingFullyTypedFormatSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.WriteBufferImmediateSupportFlags"]/*'/>

    public D3D12CommandListSupportFlags WriteBufferImmediateSupportFlags;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.ViewInstancingTier"]/*'/>

    public D3D12ViewInstancingTier ViewInstancingTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS3.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS3.BarycentricsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> BarycentricsSupported;
}
