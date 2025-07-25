// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_check_feature_support.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe struct CD3DX12FeatureSupport : IDisposable
{
    private ID3D12Device MPDevice;
    private HResult MHStatus;
    private D3D12FeatureDataD3D12Options MDOptions;
    private D3DFeatureLevel MEMaxFeatureLevel;
    private D3D12FeatureDataGpuVirtualAddressSupport MDGpuvaSupport;
    private D3D12FeatureDataShaderModel MDShaderModel;
    private D3D12FeatureDataD3D12Options1 MDOptions1;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT>")]
    private D3D12FeatureDataProtectedResourceSessionSupport* MDProtectedResourceSessionSupport;
    private D3D12FeatureDataRootSignature MDRootSignature;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_ARCHITECTURE1>")]
    private D3D12FeatureDataArchitecture1* MDArchitecture1;
    private D3D12FeatureDataD3D12Options2 MDOptions2;
    private D3D12FeatureDataShaderCache MDShaderCache;
    private D3D12FeatureDataCommandQueuePriority MDCommandQueuePriority;
    private D3D12FeatureDataD3D12Options3 MDOptions3;
    private D3D12FeatureDataExistingHeaps MDExistingHeaps;
    private D3D12FeatureDataD3D12Options4 MDOptions4;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_SERIALIZATION>")]
    private D3D12FeatureDataSerialization* MDSerialization;
    private D3D12FeatureDataCrossNode MDCrossNode;
    private D3D12FeatureDataD3D12Options5 MDOptions5;
    private D3D12FeatureDataDisplayable MDDisplayable;
    private D3D12FeatureDataD3D12Options6 MDOptions6;
    private D3D12FeatureDataD3D12Options7 MDOptions7;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT>")]
    private D3D12FeatureDataProtectedResourceSessionTypeCount* MDProtectedResourceSessionTypeCount;

    [NativeTypeName("std::vector<ProtectedResourceSessionTypesLocal>")]
    private ProtectedResourceSessionTypesLocal* MDProtectedResourceSessionTypes;
    private D3D12FeatureDataD3D12Options8 MDOptions8;
    private D3D12FeatureDataD3D12Options9 MDOptions9;
    private D3D12FeatureDataD3D12Options10 MDOptions10;
    private D3D12FeatureDataD3D12Options11 MDOptions11;
    private D3D12FeatureDataD3D12Options12 MDOptions12;
    private D3D12FeatureDataD3D12Options13 MDOptions13;
    private D3D12FeatureDataD3D12Options14 MDOptions14;
    private D3D12FeatureDataD3D12Options15 MDOptions15;
    private D3D12FeatureDataD3D12Options16 MDOptions16;
    private D3D12FeatureDataD3D12Options17 MDOptions17;
    private D3D12FeatureDataD3D12Options18 MDOptions18;
    private D3D12FeatureDataD3D12Options19 MDOptions19;
    private D3D12FeatureDataD3D12Options20 MDOptions20;

    // Default constructor that creates an empty object
    public CD3DX12FeatureSupport()
    {
        MHStatus = E_INVALIDARG;
    }

    [NativeTypeName(
        "struct ProtectedResourceSessionTypesLocal : D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES"
    )]
    [NativeInheritance("D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES")]
    private struct ProtectedResourceSessionTypesLocal
    {
        public D3D12FeatureDataProtectedResourceSessionTypes Base;

        [NativeTypeName("std::vector<GUID>")]
        public Guid* TypeVec;

        [UnscopedRef]
        public ref uint NodeIndex => ref Base.NodeIndex;

        [UnscopedRef]
        public ref uint Count => ref Base.Count;

        [UnscopedRef]
        public ref Guid* pTypes => ref Base.PTypes;
    }

    // D3D12_OPTIONS6
    public readonly MaybeBool<int> AdditionalShadingRatesSupported() =>
        MDOptions6.AdditionalShadingRatesSupported;

    // D3D12_OPTIONS14
    public readonly MaybeBool<int> AdvancedTextureOpsSupported() =>
        MDOptions14.AdvancedTextureOpsSupported;

    public readonly MaybeBool<int> AlphaBlendFactorSupported() =>
        MDOptions13.AlphaBlendFactorSupported;

    public readonly MaybeBool<int> AnisoFilterWithPointMipSupported() =>
        MDOptions19.AnisoFilterWithPointMipSupported;

    // D3D12_OPTIONS11
    public readonly MaybeBool<int> AtomicInt64OnDescriptorHeapResourceSupported() =>
        MDOptions11.AtomicInt64OnDescriptorHeapResourceSupported;

    public readonly MaybeBool<int> AtomicInt64OnGroupSharedSupported() =>
        MDOptions9.AtomicInt64OnGroupSharedSupported;

    public readonly BOOL AtomicInt64OnTypedResourceSupported() =>
        MDOptions9.AtomicInt64OnTypedResourceSupported;

    public readonly MaybeBool<int> BackgroundProcessingSupported() =>
        MDOptions6.BackgroundProcessingSupported;

    public readonly MaybeBool<int> BarycentricsSupported() => MDOptions3.BarycentricsSupported;

    public readonly MaybeBool<int> CacheCoherentUMA(uint NodeIndex = 0) =>
        MDArchitecture1[NodeIndex].CacheCoherentUMA;

    public readonly MaybeBool<int> CastingFullyTypedFormatSupported() =>
        MDOptions3.CastingFullyTypedFormatSupported;

    // COMMAND_QUEUE_PRIORITY
    public MaybeBool<int> CommandQueuePrioritySupported(
        D3D12CommandListType CommandListType,
        uint Priority
    )
    {
        MDCommandQueuePriority.CommandListType = CommandListType;
        MDCommandQueuePriority.Priority = Priority;
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.CommandQueuePriority,
                        &pThis->MDCommandQueuePriority,
                        (uint)(sizeof(D3D12FeatureDataCommandQueuePriority))
                    )
                )
            )
            {
                return false;
            }
        }
        return MDCommandQueuePriority.PriorityForTypeIsSupported;
    }

    // D3D12_OPTIONS20
    public readonly BOOL ComputeOnlyWriteWatchSupported() =>
        MDOptions20.ComputeOnlyWriteWatchSupported;

    public readonly D3D12ConservativeRasterizationTier ConservativeRasterizationTier() =>
        MDOptions.ConservativeRasterizationTier;

    // D3D12_OPTIONS3
    public readonly MaybeBool<int> CopyQueueTimestampQueriesSupported() =>
        MDOptions3.CopyQueueTimestampQueriesSupported;

    public readonly MaybeBool<int> CrossAdapterRowMajorTextureSupported() =>
        MDOptions.CrossAdapterRowMajorTextureSupported;

    // CROSS_NODE
    // CrossNodeSharingTier handled in D3D12Options
    public readonly MaybeBool<int> CrossNodeAtomicShaderInstructions() =>
        MDCrossNode.AtomicShaderInstructions;

    public readonly D3D12CrossNodeSharingTier CrossNodeSharingTier()
    {
        if (MDCrossNode.SharingTier > D3D12CrossNodeSharingTier.TierNotSupported)
        {
            return MDCrossNode.SharingTier;
        }
        else
        {
            return MDOptions.CrossNodeSharingTier;
        }
    }

    // D3D12_OPTIONS2
    public readonly MaybeBool<int> DepthBoundsTestSupported() =>
        MDOptions2.DepthBoundsTestSupported;

    public readonly MaybeBool<int> DerivativesInMeshAndAmplificationShadersSupported() =>
        MDOptions9.DerivativesInMeshAndAmplificationShadersSupported;

    // DISPLAYABLE
    public readonly MaybeBool<int> DisplayableTexture() => MDDisplayable.DisplayableTexture;

    public void Dispose()
    {
        NativeMemory.Free(MDProtectedResourceSessionSupport);
        MDProtectedResourceSessionSupport = null;
        NativeMemory.Free(MDArchitecture1);
        MDArchitecture1 = null;
        NativeMemory.Free(MDSerialization);
        MDSerialization = null;
        NativeMemory.Free(MDProtectedResourceSessionTypeCount);
        MDProtectedResourceSessionTypeCount = null;
        if (MDProtectedResourceSessionTypes != null)
        {
            uint uNodeCount = MPDevice.GetNodeCount();
            for (nuint NodeIndex = 0; NodeIndex < uNodeCount; NodeIndex++)
            {
                NativeMemory.Free(MDProtectedResourceSessionTypes[NodeIndex].TypeVec);
            }
            NativeMemory.Free(MDProtectedResourceSessionTypes);
            MDProtectedResourceSessionTypes = null;
        }
    }

    // Getter functions for each feature class
    // D3D12_OPTIONS
    public readonly MaybeBool<int> DoublePrecisionFloatShaderOps() =>
        MDOptions.DoublePrecisionFloatShaderOps;

    // D3D12_OPTIONS16
    public readonly MaybeBool<int> DynamicDepthBiasSupported() =>
        MDOptions16.DynamicDepthBiasSupported;

    public readonly MaybeBool<int> DynamicIndexBufferStripCutSupported() =>
        MDOptions15.DynamicIndexBufferStripCutSupported;

    public readonly BOOL EnhancedBarriersSupported() => MDOptions12.EnhancedBarriersSupported;

    // EXISTING_HEAPS
    public readonly MaybeBool<int> ExistingHeapsSupported() => MDExistingHeaps.Supported;

    public readonly MaybeBool<int> ExpandedComputeResourceStates() =>
        MDOptions1.ExpandedComputeResourceStates;

    // FORMAT_INFO
    public readonly HResult FormatInfo(
        DxgiFormat Format,
        [NativeTypeName("UINT8 &")] out byte PlaneCount
    )
    {
        D3D12FeatureDataFormatInfo dFormatInfo;
        dFormatInfo.Format = Format;
        HResult result = MPDevice.CheckFeatureSupport(
            D3D12Feature.FormatInfo,
            &dFormatInfo,
            (uint)(sizeof(D3D12FeatureDataFormatInfo))
        );
        if (Windows.Failed(result))
        {
            PlaneCount = 0;
        }
        else
        {
            PlaneCount = dFormatInfo.PlaneCount;
        }
        return result;
    }

    // FORMAT_SUPPORT
    public readonly HRESULT FormatSupport(
        DxgiFormat Format,
        [NativeTypeName("D3D12_FORMAT_SUPPORT1 &")] out D3D12FormatSupport1 Support1,
        [NativeTypeName("D3D12_FORMAT_SUPPORT2 &")] out D3D12FormatSupport2 Support2
    )
    {
        D3D12FeatureDataFormatSupport dFormatSupport;
        dFormatSupport.Format = Format;
        // It is possible that the function call returns an error
        HResult result = MPDevice.CheckFeatureSupport(
            D3D12Feature.FormatSupport,
            &dFormatSupport,
            (uint)(sizeof(D3D12FeatureDataFormatSupport))
        );
        Support1 = dFormatSupport.Support1;
        Support2 = dFormatSupport.Support2; // Two outputs. Probably better just to take in the struct as an argument?
        return result;
    }

    // Retrieves the status of the object. If an error occurred in the initialization process, the function returns the error code.
    public readonly HResult GetStatus() => MHStatus;

    public readonly MaybeBool<int> GPUUploadHeapSupported() => MDOptions16.GPUUploadHeapSupported;

    // SERIALIZATION
    public readonly D3D12HeapSerializationTier HeapSerializationTier(uint NodeIndex = 0) =>
        MDSerialization[NodeIndex].HeapSerializationTier;

    // ROOT_SIGNATURE
    public readonly D3DRootSignatureVersion HighestRootSignatureVersion() =>
        MDRootSignature.HighestVersion;

    // SHADER_MODEL
    public readonly D3DShaderModel HighestShaderModel() => MDShaderModel.HighestShaderModel;

    public readonly BOOL IndependentFrontAndBackStencilRefMaskSupported() =>
        MDOptions14.IndependentFrontAndBackStencilRefMaskSupported;

    // Initialize data from the given device
    public HResult Init(ID3D12Device pDevice)
    {
        if (pDevice.LpVtbl == null)
        {
            MHStatus = E_INVALIDARG;
            return MHStatus;
        }
        MPDevice = pDevice;
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            // Initialize static feature support data structures
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options,
                        &pThis->MDOptions,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options))
                    )
                )
            )
            {
                MDOptions = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.GpuVirtualAddressSupport,
                        &pThis->MDGpuvaSupport,
                        (uint)(sizeof(D3D12FeatureDataGpuVirtualAddressSupport))
                    )
                )
            )
            {
                MDGpuvaSupport = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options1,
                        &pThis->MDOptions1,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options1))
                    )
                )
            )
            {
                MDOptions1 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options2,
                        &pThis->MDOptions2,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options2))
                    )
                )
            )
            {
                MDOptions2 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.ShaderCache,
                        &pThis->MDShaderCache,
                        (uint)(sizeof(D3D12FeatureDataShaderCache))
                    )
                )
            )
            {
                MDShaderCache = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options3,
                        &pThis->MDOptions3,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options3))
                    )
                )
            )
            {
                MDOptions3 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.ExistingHeaps,
                        &pThis->MDExistingHeaps,
                        (uint)(sizeof(D3D12FeatureDataExistingHeaps))
                    )
                )
            )
            {
                MDExistingHeaps = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options4,
                        &pThis->MDOptions4,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options4))
                    )
                )
            )
            {
                MDOptions4 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.CrossNode,
                        &pThis->MDCrossNode,
                        (uint)(sizeof(D3D12FeatureDataCrossNode))
                    )
                )
            )
            {
                MDCrossNode = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options5,
                        &pThis->MDOptions5,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options5))
                    )
                )
            )
            {
                MDOptions5 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.Displayable,
                        &pThis->MDDisplayable,
                        (uint)(sizeof(D3D12FeatureDataDisplayable))
                    )
                )
            )
            {
                MDDisplayable = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options6,
                        &pThis->MDOptions6,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options6))
                    )
                )
            )
            {
                MDOptions6 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options7,
                        &pThis->MDOptions7,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options7))
                    )
                )
            )
            {
                MDOptions7 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options8,
                        &pThis->MDOptions8,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options8))
                    )
                )
            )
            {
                MDOptions8 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options9,
                        &pThis->MDOptions9,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options9))
                    )
                )
            )
            {
                MDOptions9 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options10,
                        &pThis->MDOptions10,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options10))
                    )
                )
            )
            {
                MDOptions10 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options11,
                        &pThis->MDOptions11,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options11))
                    )
                )
            )
            {
                MDOptions11 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options12,
                        &pThis->MDOptions12,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options12))
                    )
                )
            )
            {
                MDOptions12 = default;
                MDOptions12.MSPrimitivesPipelineStatisticIncludesCulledPrimitives =
                    D3D12TriState.Unknown;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options13,
                        &pThis->MDOptions13,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options13))
                    )
                )
            )
            {
                MDOptions13 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options14,
                        &pThis->MDOptions14,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options14))
                    )
                )
            )
            {
                MDOptions14 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options15,
                        &pThis->MDOptions15,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options15))
                    )
                )
            )
            {
                MDOptions15 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options16,
                        &pThis->MDOptions16,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options16))
                    )
                )
            )
            {
                MDOptions16 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options17,
                        &pThis->MDOptions17,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options17))
                    )
                )
            )
            {
                MDOptions17 = default;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options18,
                        &pThis->MDOptions18,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options18))
                    )
                )
            )
            {
                MDOptions18.RenderPassesValid = false;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options19,
                        &pThis->MDOptions19,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options19))
                    )
                )
            )
            {
                MDOptions19 = default;
                MDOptions19.SupportedSampleCountsWithNoOutputs = 1;
                MDOptions19.MaxSamplerDescriptorHeapSize = D3D12.MaxShaderVisibleSamplerHeapSize;
                MDOptions19.MaxSamplerDescriptorHeapSizeWithStaticSamplers =
                    D3D12.MaxShaderVisibleSamplerHeapSize;
                MDOptions19.MaxViewDescriptorHeapSize =
                    D3D12.MaxShaderVisibleDescriptorHeapSizeTier1;
            }
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.D3D12Options20,
                        &pThis->MDOptions20,
                        (uint)(sizeof(D3D12FeatureDataD3D12Options20))
                    )
                )
            )
            {
                MDOptions20 = default;
            }
        }
        // Initialize per-node feature support data structures
        uint uNodeCount = MPDevice.GetNodeCount();
        NativeMemory.Free(MDProtectedResourceSessionSupport);
        MDProtectedResourceSessionSupport = (D3D12FeatureDataProtectedResourceSessionSupport*)(
            NativeMemory.Alloc(
                uNodeCount,
                (uint)(sizeof(D3D12FeatureDataProtectedResourceSessionSupport))
            )
        );
        NativeMemory.Free(MDArchitecture1);
        MDArchitecture1 = (D3D12FeatureDataArchitecture1*)(
            NativeMemory.Alloc(uNodeCount, (uint)(sizeof(D3D12FeatureDataArchitecture1)))
        );
        NativeMemory.Free(MDSerialization);
        MDSerialization = (D3D12FeatureDataSerialization*)(
            NativeMemory.Alloc(uNodeCount, (uint)(sizeof(D3D12FeatureDataSerialization)))
        );
        NativeMemory.Free(MDProtectedResourceSessionTypeCount);
        MDProtectedResourceSessionTypeCount = (D3D12FeatureDataProtectedResourceSessionTypeCount*)(
            NativeMemory.Alloc(
                uNodeCount,
                (uint)(sizeof(D3D12FeatureDataProtectedResourceSessionTypeCount))
            )
        );
        NativeMemory.Free(MDProtectedResourceSessionTypes);
        MDProtectedResourceSessionTypes = (ProtectedResourceSessionTypesLocal*)(
            NativeMemory.Alloc(uNodeCount, (uint)(sizeof(ProtectedResourceSessionTypesLocal)))
        );
        for (uint NodeIndex = 0; NodeIndex < uNodeCount; NodeIndex++)
        {
            MDProtectedResourceSessionSupport[NodeIndex].NodeIndex = NodeIndex;
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.ProtectedResourceSessionSupport,
                        &MDProtectedResourceSessionSupport[NodeIndex],
                        (uint)(sizeof(D3D12FeatureDataProtectedResourceSessionSupport))
                    )
                )
            )
            {
                MDProtectedResourceSessionSupport[NodeIndex].Support =
                    D3D12ProtectedResourceSessionSupportFlags.None;
            }
            MDArchitecture1[NodeIndex].NodeIndex = NodeIndex;
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.Architecture1,
                        &MDArchitecture1[NodeIndex],
                        (uint)(sizeof(D3D12FeatureDataArchitecture1))
                    )
                )
            )
            {
                D3D12FeatureDataArchitecture dArchLocal = default;
                dArchLocal.NodeIndex = NodeIndex;
                if (
                    Windows.Failed(
                        MPDevice.CheckFeatureSupport(
                            D3D12Feature.Architecture,
                            &dArchLocal,
                            (uint)(sizeof(D3D12FeatureDataArchitecture))
                        )
                    )
                )
                {
                    dArchLocal.TileBasedRenderer = false;
                    dArchLocal.Uma = false;
                    dArchLocal.CacheCoherentUMA = false;
                }
                MDArchitecture1[NodeIndex].TileBasedRenderer = dArchLocal.TileBasedRenderer;
                MDArchitecture1[NodeIndex].Uma = dArchLocal.Uma;
                MDArchitecture1[NodeIndex].CacheCoherentUMA = dArchLocal.CacheCoherentUMA;
                MDArchitecture1[NodeIndex].IsolatedMMU = false;
            }
            MDSerialization[NodeIndex].NodeIndex = NodeIndex;
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.Serialization,
                        &MDSerialization[NodeIndex],
                        (uint)(sizeof(D3D12FeatureDataSerialization))
                    )
                )
            )
            {
                MDSerialization[NodeIndex].HeapSerializationTier = D3D12HeapSerializationTier.Tier0;
            }
            MDProtectedResourceSessionTypeCount[NodeIndex].NodeIndex = NodeIndex;
            if (
                Windows.Failed(
                    MPDevice.CheckFeatureSupport(
                        D3D12Feature.ProtectedResourceSessionTypeCount,
                        &MDProtectedResourceSessionTypeCount[NodeIndex],
                        (uint)(sizeof(D3D12FeatureDataProtectedResourceSessionTypeCount))
                    )
                )
            )
            {
                MDProtectedResourceSessionTypeCount[NodeIndex].Count = 0;
            }
            // Special procedure to initialize local protected resource session types structs
            // Must wait until session type count initialized
            _ = QueryProtectedResourceSessionTypes(
                NodeIndex,
                MDProtectedResourceSessionTypeCount[NodeIndex].Count
            );
        }
        // Initialize features that requires highest version check
        if (Windows.Failed(MHStatus = QueryHighestShaderModel()))
        {
            return MHStatus;
        }
        if (Windows.Failed(MHStatus = QueryHighestRootSignatureVersion()))
        {
            return MHStatus;
        }
        // Initialize Feature Levels data
        if (Windows.Failed(MHStatus = QueryHighestFeatureLevel()))
        {
            return MHStatus;
        }
        return MHStatus;
    }

    public readonly BOOL Int64ShaderOps() => MDOptions1.Int64ShaderOps;

    public readonly MaybeBool<int> InvertedViewportDepthFlipsZSupported() =>
        MDOptions13.InvertedViewportDepthFlipsZSupported;

    public readonly MaybeBool<int> InvertedViewportHeightFlipsYSupported() =>
        MDOptions13.InvertedViewportHeightFlipsYSupported;

    public readonly MaybeBool<int> IsolatedMMU(uint NodeIndex = 0) =>
        MDArchitecture1[NodeIndex].IsolatedMMU;

    public readonly BOOL ManualWriteTrackingResourceSupported() =>
        MDOptions17.ManualWriteTrackingResourceSupported;

    // GPU_VIRTUAL_ADDRESS_SUPPORT
    public readonly uint MaxGPUVirtualAddressBitsPerProcess() =>
        MDGpuvaSupport.MaxGPUVirtualAddressBitsPerProcess;

    public readonly uint MaxGPUVirtualAddressBitsPerResource()
    {
        if (MDOptions.MaxGPUVirtualAddressBitsPerResource > 0)
        {
            return MDOptions.MaxGPUVirtualAddressBitsPerResource;
        }
        else
        {
            return MDGpuvaSupport.MaxGPUVirtualAddressBitsPerResource;
        }
    }

    public readonly uint MaxSamplerDescriptorHeapSize() => MDOptions19.MaxSamplerDescriptorHeapSize;

    public readonly uint MaxSamplerDescriptorHeapSizeWithStaticSamplers() =>
        MDOptions19.MaxSamplerDescriptorHeapSizeWithStaticSamplers;

    // FEATURE_LEVELS
    public readonly D3DFeatureLevel MaxSupportedFeatureLevel() => MEMaxFeatureLevel;

    public readonly uint MaxViewDescriptorHeapSize() => MDOptions19.MaxViewDescriptorHeapSize;

    public readonly MaybeBool<int> MeshShaderPerPrimitiveShadingRateSupported() =>
        MDOptions10.MeshShaderPerPrimitiveShadingRateSupported;

    // D3D12_OPTIONS9
    public readonly MaybeBool<int> MeshShaderPipelineStatsSupported() =>
        MDOptions9.MeshShaderPipelineStatsSupported;

    public readonly MaybeBool<int> MeshShaderSupportsFullRangeRenderTargetArrayIndex() =>
        MDOptions9.MeshShaderSupportsFullRangeRenderTargetArrayIndex;

    // D3D12_OPTIONS7
    public readonly D3D12MeshShaderTier MeshShaderTier() => MDOptions7.MeshShaderTier;

    public readonly D3D12ShaderMinPrecisionSupport MinPrecisionSupport() =>
        MDOptions.MinPrecisionSupport;

    // D3D12_OPTIONS19
    public readonly BOOL MismatchingOutputDimensionsSupported() =>
        MDOptions19.MismatchingOutputDimensionsSupported;

    // D3D12_OPTIONS4
    public readonly BOOL MSAA64KBAlignedTextureSupported() =>
        MDOptions4.MSAA64KBAlignedTextureSupported;

    // D3D12_OPTIONS12
    public readonly D3D12TriState MSPrimitivesPipelineStatisticIncludesCulledPrimitives() =>
        MDOptions12.MSPrimitivesPipelineStatisticIncludesCulledPrimitives;

    // MUTLTISAMPLE_QUALITY_LEVELS
    public readonly HResult MultisampleQualityLevels(
        DxgiFormat Format,
        uint SampleCount,
        D3D12MultisampleQualityLevelFlags Flags,
        [NativeTypeName("UINT &")] out uint NumQualityLevels
    )
    {
        D3D12FeatureDataMultisampleQualityLevels dMultisampleQualityLevels;
        dMultisampleQualityLevels.Format = Format;
        dMultisampleQualityLevels.SampleCount = SampleCount;
        dMultisampleQualityLevels.Flags = Flags;
        HResult result = MPDevice.CheckFeatureSupport(
            D3D12Feature.MultisampleQualityLevels,
            &dMultisampleQualityLevels,
            (uint)(sizeof(D3D12FeatureDataMultisampleQualityLevels))
        );
        if (SUCCEEDED(result))
        {
            NumQualityLevels = dMultisampleQualityLevels.NumQualityLevels;
        }
        else
        {
            NumQualityLevels = 0;
        }
        return result;
    }

    public readonly MaybeBool<int> NarrowQuadrilateralLinesSupported() =>
        MDOptions19.NarrowQuadrilateralLinesSupported;

    public readonly BOOL Native16BitShaderOpsSupported() =>
        MDOptions4.Native16BitShaderOpsSupported;

    // D3D12_OPTIONS17
    public readonly MaybeBool<int> NonNormalizedCoordinateSamplersSupported() =>
        MDOptions17.NonNormalizedCoordinateSamplersSupported;

    public readonly MaybeBool<int> OutputMergerLogicOp() => MDOptions.OutputMergerLogicOp;

    public readonly MaybeBool<int> PerPrimitiveShadingRateSupportedWithViewportIndexing() =>
        MDOptions6.PerPrimitiveShadingRateSupportedWithViewportIndexing;

    public readonly BOOL PointSamplingAddressesNeverRoundUp() =>
        MDOptions19.PointSamplingAddressesNeverRoundUp;

    public readonly D3D12ProgrammableSamplePositionsTier ProgrammableSamplePositionsTier() =>
        MDOptions2.ProgrammableSamplePositionsTier;

    // PROTECTED_RESOURCE_SESSION_SUPPORT
    public readonly D3D12ProtectedResourceSessionSupportFlags ProtectedResourceSessionSupport(
        uint NodeIndex = 0
    ) => MDProtectedResourceSessionSupport[NodeIndex].Support;

    // PROTECTED_RESOURCE_SESSION_TYPE_COUNT
    public readonly uint ProtectedResourceSessionTypeCount(uint NodeIndex = 0) =>
        MDProtectedResourceSessionTypeCount[NodeIndex].Count;

    // PROTECTED_RESOURCE_SESSION_TYPES
    [return: NativeTypeName("std::vector<GUID>")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly Ptr<Guid> ProtectedResourceSessionTypes(uint NodeIndex = 0) =>
        (Guid*)ProtectedResourceSessionTypesRaw(NodeIndex);

    // PROTECTED_RESOURCE_SESSION_TYPES
    [return: NativeTypeName("std::vector<GUID>")]
    public readonly Guid* ProtectedResourceSessionTypesRaw(uint NodeIndex = 0) =>
        MDProtectedResourceSessionTypes[NodeIndex].TypeVec;

    public readonly BOOL PSSpecifiedStencilRefSupported() =>
        MDOptions.PSSpecifiedStencilRefSupported;

    // Helper function to decide the highest feature level
    private HResult QueryHighestFeatureLevel()
    {
        HResult result;
        // Check against a list of all feature levels present in d3dcommon.h
        // Needs to be updated for future feature levels
        const int numLevels = 12;
        D3DFeatureLevel* allLevels =
            stackalloc D3DFeatureLevel[numLevels] {
                D3DFeatureLevel.Level12X2,
                D3DFeatureLevel.Level12X1,
                D3DFeatureLevel.Level12X0,
                D3DFeatureLevel.Level11X1,
                D3DFeatureLevel.Level11X0,
                D3DFeatureLevel.Level10X1,
                D3DFeatureLevel.Level10X0,
                D3DFeatureLevel.Level9X3,
                D3DFeatureLevel.Level9X2,
                D3DFeatureLevel.Level9X1,
                D3DFeatureLevel.Level1X0Core,
                D3DFeatureLevel.Level1X0Generic,
            };
        D3D12FeatureDataFeatureLevels dFeatureLevel;
        dFeatureLevel.NumFeatureLevels = numLevels;
        dFeatureLevel.PFeatureLevelsRequested = allLevels;
        result = MPDevice.CheckFeatureSupport(
            D3D12Feature.FeatureLevels,
            &dFeatureLevel,
            (uint)(sizeof(D3D12FeatureDataFeatureLevels))
        );
        if (SUCCEEDED(result))
        {
            MEMaxFeatureLevel = dFeatureLevel.MaxSupportedFeatureLevel;
        }
        else
        {
            MEMaxFeatureLevel = (D3DFeatureLevel)(0);
            if (result == DXGI_ERROR_UNSUPPORTED)
            {
                // Indicates that none supported. Continue initialization
                result = S_OK;
            }
        }
        return result;
    }

    // Helper function to decide the highest root signature supported
    // Must be updated whenever a new root signature version is added to the d3d12.h header
    private HRESULT QueryHighestRootSignatureVersion()
    {
        HResult result;
        const int numRootSignatureVersions = 4;
        D3DRootSignatureVersion* allRootSignatureVersions =
            stackalloc D3DRootSignatureVersion[numRootSignatureVersions] {
                D3DRootSignatureVersion.Version1X2,
                D3DRootSignatureVersion.Version1X1,
                D3DRootSignatureVersion.Version1X0,
                D3DRootSignatureVersion.Version1,
            };
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            for (nuint i = 0; i < numRootSignatureVersions; i++)
            {
                MDRootSignature.HighestVersion = allRootSignatureVersions[i];
                result = MPDevice.CheckFeatureSupport(
                    D3D12Feature.RootSignature,
                    &pThis->MDRootSignature,
                    (uint)(sizeof(D3D12FeatureDataRootSignature))
                );
                if (result != E_INVALIDARG)
                {
                    if (Windows.Failed(result))
                    {
                        MDRootSignature.HighestVersion = (D3DRootSignatureVersion)(0);
                    }
                    // If succeeded, the highest version is already written into the member struct
                    return result;
                }
            }
        }
        MDRootSignature.HighestVersion = (D3DRootSignatureVersion)(0);
        return S_OK;
    }

    // Helper function to decide the highest shader model supported by the system
    // Stores the result in m_dShaderModel
    // Must be updated whenever a new shader model is added to the d3d12.h header
    private HResult QueryHighestShaderModel()
    {
        // Check support in descending order
        HResult result;
        const int numModelVersions = 10;
        D3DShaderModel* allModelVersions =
            stackalloc D3DShaderModel[numModelVersions] {
                D3DShaderModel.ShaderModel6X8,
                D3DShaderModel.ShaderModel6X7,
                D3DShaderModel.ShaderModel6X6,
                D3DShaderModel.ShaderModel6X5,
                D3DShaderModel.ShaderModel6X4,
                D3DShaderModel.ShaderModel6X3,
                D3DShaderModel.ShaderModel6X2,
                D3DShaderModel.ShaderModel6X1,
                D3DShaderModel.ShaderModel6X0,
                D3DShaderModel.ShaderModel5X1,
            };
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            for (nuint i = 0; i < numModelVersions; i++)
            {
                MDShaderModel.HighestShaderModel = allModelVersions[i];
                result = MPDevice.CheckFeatureSupport(
                    D3D12Feature.ShaderModel,
                    &pThis->MDShaderModel,
                    (uint)(sizeof(D3D12FeatureDataShaderModel))
                );
                if (result != E_INVALIDARG)
                {
                    // Indicates that the version is recognizable by the runtime and stored in the struct
                    // Also terminate on unexpected error code
                    if (Windows.Failed(result))
                    {
                        MDShaderModel.HighestShaderModel = (D3DShaderModel)(0);
                    }
                    return result;
                }
            }
        }
        MDShaderModel.HighestShaderModel = (D3DShaderModel)(0);
        return S_OK;
    }

    // QUERY_META_COMMAND
    public readonly HResult QueryMetaCommand(
        [NativeTypeName("D3D12_FEATURE_DATA_QUERY_META_COMMAND &")]
            out D3D12FeatureDataQueryMetaCommand dQueryMetaCommand
    )
    {
        fixed (D3D12FeatureDataQueryMetaCommand* pQueryMetaCommand = &dQueryMetaCommand)
        {
            return MPDevice.CheckFeatureSupport(
                D3D12Feature.QueryMetaCommand,
                pQueryMetaCommand,
                (uint)(sizeof(D3D12FeatureDataQueryMetaCommand))
            );
        }
    }

    // Helper function to initialize local protected resource session types structs
    private HResult QueryProtectedResourceSessionTypes(uint NodeIndex, uint Count)
    {
        ref ProtectedResourceSessionTypesLocal CurrentPRSTypes =
            ref MDProtectedResourceSessionTypes[NodeIndex];
        CurrentPRSTypes.NodeIndex = NodeIndex;
        CurrentPRSTypes.Count = Count;
        NativeMemory.Free(CurrentPRSTypes.TypeVec);
        CurrentPRSTypes.TypeVec = (Guid*)(
            NativeMemory.Alloc(CurrentPRSTypes.Count, (uint)(sizeof(Guid)))
        );
        CurrentPRSTypes.pTypes = CurrentPRSTypes.TypeVec;
        HResult result = MPDevice.CheckFeatureSupport(
            D3D12Feature.ProtectedResourceSessionTypes,
            &MDProtectedResourceSessionTypes[NodeIndex],
            (uint)(sizeof(D3D12FeatureDataProtectedResourceSessionTypes))
        );
        if (Windows.Failed(result))
        {
            // Resize TypeVec to empty
            NativeMemory.Free(CurrentPRSTypes.TypeVec);
            CurrentPRSTypes.TypeVec = null;
        }
        return result;
    }

    public readonly MaybeBool<int> RasterizerDesc2Supported() =>
        MDOptions19.RasterizerDesc2Supported;

    public readonly D3D12RaytracingTier RaytracingTier() => MDOptions5.RaytracingTier;

    public readonly MaybeBool<int> RelaxedFormatCastingSupported() =>
        MDOptions12.RelaxedFormatCastingSupported;

    public readonly D3D12RenderPassTier RenderPassesTier() => MDOptions5.RenderPassesTier;

    // D3D12_OPTIONS18
    public readonly MaybeBool<int> RenderPassesValid() => MDOptions18.RenderPassesValid;

    public readonly D3D12ResourceBindingTier ResourceBindingTier() => MDOptions.ResourceBindingTier;

    public readonly D3D12ResourceHeapTier ResourceHeapTier() => MDOptions.ResourceHeapTier;

    public readonly MaybeBool<int> ROVsSupported() => MDOptions.ROVsSupported;

    public readonly D3D12SamplerFeedbackTier SamplerFeedbackTier() =>
        MDOptions7.SamplerFeedbackTier;

    // SHADER_CACHE
    public readonly D3D12ShaderCacheSupportFlags ShaderCacheSupportFlags() =>
        MDShaderCache.SupportFlags;

    public readonly uint ShadingRateImageTileSize() => MDOptions6.ShadingRateImageTileSize;

    public readonly D3D12SharedResourceCompatibilityTier SharedResourceCompatibilityTier() =>
        MDOptions4.SharedResourceCompatibilityTier;

    // D3D12_OPTIONS5
    public readonly MaybeBool<int> SRVOnlyTiledResourceTier3() =>
        MDOptions5.SRVOnlyTiledResourceTier3;

    public readonly BOOL StandardSwizzle64KBSupported() => MDOptions.StandardSwizzle64KBSupported;

    public readonly uint SupportedSampleCountsWithNoOutputs() =>
        MDOptions19.SupportedSampleCountsWithNoOutputs;

    public readonly MaybeBool<int> TextureCopyBetweenDimensionsSupported() =>
        MDOptions13.TextureCopyBetweenDimensionsSupported;

    // ARCHITECTURE1
    public readonly BOOL TileBasedRenderer(uint NodeIndex = 0) =>
        MDArchitecture1[NodeIndex].TileBasedRenderer;

    public readonly D3D12TiledResourcesTier TiledResourcesTier() => MDOptions.TiledResourcesTier;

    public readonly uint TotalLaneCount() => MDOptions1.TotalLaneCount;

    // D3D12_OPTIONS15
    public readonly MaybeBool<int> TriangleFanSupported() => MDOptions15.TriangleFanSupported;

    public readonly MaybeBool<int> TypedUAVLoadAdditionalFormats() =>
        MDOptions.TypedUAVLoadAdditionalFormats;

    public readonly MaybeBool<int> UMA(uint NodeIndex = 0) => MDArchitecture1[NodeIndex].Uma;

    // D3D12_OPTIONS8
    public readonly MaybeBool<int> UnalignedBlockTexturesSupported() =>
        MDOptions8.UnalignedBlockTexturesSupported;

    // D3D12_OPTIONS13
    public readonly BOOL UnrestrictedBufferTextureCopyPitchSupported() =>
        MDOptions13.UnrestrictedBufferTextureCopyPitchSupported;

    public readonly MaybeBool<int> UnrestrictedVertexElementAlignmentSupported() =>
        MDOptions13.UnrestrictedVertexElementAlignmentSupported;

    // D3D12_OPTIONS10
    public readonly MaybeBool<int> VariableRateShadingSumCombinerSupported() =>
        MDOptions10.VariableRateShadingSumCombinerSupported;

    public readonly D3D12VariableShadingRateTier VariableShadingRateTier() =>
        MDOptions6.VariableShadingRateTier;

    public readonly D3D12ViewInstancingTier ViewInstancingTier() => MDOptions3.ViewInstancingTier;

    public readonly MaybeBool<int> VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation() =>
        MDOptions.VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

    public readonly uint WaveLaneCountMax() => MDOptions1.WaveLaneCountMax;

    public readonly uint WaveLaneCountMin() => MDOptions1.WaveLaneCountMin;

    public readonly D3D12WaveMmaTier WaveMMATier() => MDOptions9.WaveMMATier;

    // D3D12_OPTIONS1
    public readonly MaybeBool<int> WaveOps() => MDOptions1.WaveOps;

    public readonly BOOL WriteableMSAATexturesSupported() =>
        MDOptions14.WriteableMSAATexturesSupported;

    public readonly D3D12CommandListSupportFlags WriteBufferImmediateSupportFlags() =>
        MDOptions3.WriteBufferImmediateSupportFlags;
}
