// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS"]/*'/>
public partial struct D3D12FeatureDataD3D12Options
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.DoublePrecisionFloatShaderOps"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> DoublePrecisionFloatShaderOps;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.OutputMergerLogicOp"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> OutputMergerLogicOp;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.MinPrecisionSupport"]/*'/>

    public D3D12ShaderMinPrecisionSupport MinPrecisionSupport;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.TiledResourcesTier"]/*'/>

    public D3D12TiledResourcesTier TiledResourcesTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ResourceBindingTier"]/*'/>

    public D3D12ResourceBindingTier ResourceBindingTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.PSSpecifiedStencilRefSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> PSSpecifiedStencilRefSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.TypedUAVLoadAdditionalFormats"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> TypedUAVLoadAdditionalFormats;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ROVsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> ROVsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ConservativeRasterizationTier"]/*'/>

    public D3D12ConservativeRasterizationTier ConservativeRasterizationTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.MaxGPUVirtualAddressBitsPerResource"]/*'/>

    public uint MaxGPUVirtualAddressBitsPerResource;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.StandardSwizzle64KBSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> StandardSwizzle64KBSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.CrossNodeSharingTier"]/*'/>

    public D3D12CrossNodeSharingTier CrossNodeSharingTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.CrossAdapterRowMajorTextureSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> CrossAdapterRowMajorTextureSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS.ResourceHeapTier"]/*'/>

    public D3D12ResourceHeapTier ResourceHeapTier;
}
