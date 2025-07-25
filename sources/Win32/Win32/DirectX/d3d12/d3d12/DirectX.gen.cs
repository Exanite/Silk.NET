// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("const UUID")]
    public static ref readonly Guid D3D12ExperimentalShaderModels
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x57,
                0xF5,
                0x76,
                0x3A,
                0xF1,
                0xF5,
                0x40,
                0xB2,
                0x97,
                0x81,
                0xCE,
                0x9E,
                0x18,
                0x93,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const UUID")]
    public static ref readonly Guid D3D12TiledResourceTier4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x72,
                0xC4,
                0xC9,
                0x1A,
                0xA8,
                0x56,
                0x4F,
                0x8C,
                0x5B,
                0xC5,
                0x10,
                0x39,
                0xD6,
                0x94,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CreateDevice"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "_D3D12CreateDevice")]
    private static extern HResult D3D12CreateDevice(
        IUnknown.Native* pAdapter,
        D3DFeatureLevel MinimumFeatureLevel,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppDevice
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "_D3D12CreateDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HResult D3D12CreateDevice(
        Ref<IUnknown.Native> pAdapter,
        D3DFeatureLevel MinimumFeatureLevel,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppDevice
    )
    {
        fixed (void** __dsl_ppDevice = ppDevice)
        fixed (Guid* __dsl_riid = riid)
        fixed (IUnknown.Native* __dsl_pAdapter = pAdapter)
        {
            return (HResult)D3D12CreateDevice(
                __dsl_pAdapter,
                MinimumFeatureLevel,
                __dsl_riid,
                __dsl_ppDevice
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12SerializeRootSignature"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "_D3D12SerializeRootSignature")]
    private static extern HResult D3D12SerializeRootSignature(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
            D3D12RootSignatureDesc* pRootSignature,
        D3DRootSignatureVersion Version,
        ID3DBlob.Native** ppBlob,
        ID3DBlob.Native** ppErrorBlob
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "_D3D12SerializeRootSignature")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HResult D3D12SerializeRootSignature(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
            Ref<D3D12RootSignatureDesc> pRootSignature,
        D3DRootSignatureVersion Version,
        Ref2D<ID3DBlob.Native> ppBlob,
        Ref2D<ID3DBlob.Native> ppErrorBlob
    )
    {
        fixed (ID3DBlob.Native** __dsl_ppErrorBlob = ppErrorBlob)
        fixed (ID3DBlob.Native** __dsl_ppBlob = ppBlob)
        fixed (D3D12RootSignatureDesc* __dsl_pRootSignature = pRootSignature)
        {
            return (HResult)D3D12SerializeRootSignature(
                __dsl_pRootSignature,
                Version,
                __dsl_ppBlob,
                __dsl_ppErrorBlob
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12SerializeVersionedRootSignature"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "_D3D12SerializeVersionedRootSignature")]
    private static extern HResult D3D12SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            D3D12VersionedRootSignatureDesc* pRootSignature,
        ID3DBlob.Native** ppBlob,
        ID3DBlob.Native** ppErrorBlob
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "_D3D12SerializeVersionedRootSignature")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HResult D3D12SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            Ref<D3D12VersionedRootSignatureDesc> pRootSignature,
        Ref2D<ID3DBlob.Native> ppBlob,
        Ref2D<ID3DBlob.Native> ppErrorBlob
    )
    {
        fixed (ID3DBlob.Native** __dsl_ppErrorBlob = ppErrorBlob)
        fixed (ID3DBlob.Native** __dsl_ppBlob = ppBlob)
        fixed (D3D12VersionedRootSignatureDesc* __dsl_pRootSignature = pRootSignature)
        {
            return (HResult)D3D12SerializeVersionedRootSignature(
                __dsl_pRootSignature,
                __dsl_ppBlob,
                __dsl_ppErrorBlob
            );
        }
    }

    public static HResult D3D12CreateDevice(
        IUnknown pAdapter,
        D3DFeatureLevel MinimumFeatureLevel,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppDevice
    ) => D3D12CreateDevice(pAdapter.lpVtbl, MinimumFeatureLevel, riid, ppDevice);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12CreateDevice(
        IUnknown pAdapter,
        D3DFeatureLevel MinimumFeatureLevel,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppDevice
    )
    {
        fixed (void** __dsl_ppDevice = ppDevice)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)D3D12CreateDevice(
                pAdapter,
                MinimumFeatureLevel,
                __dsl_riid,
                __dsl_ppDevice
            );
        }
    }

    [Transformed]
    public static HResult D3D12CreateDevice<TCom>(
        IUnknown pAdapter,
        D3DFeatureLevel MinimumFeatureLevel,
        out TCom ppDevice
    )
        where TCom : unmanaged, IComVtbl
    {
        ppDevice = default;
        return D3D12CreateDevice(
            pAdapter,
            MinimumFeatureLevel,
            TCom.NativeGuid,
            ppDevice.GetAddressOf()
        );
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CreateRootSignatureDeserializer"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "D3D12CreateRootSignatureDeserializer")]
    public static extern HResult D3D12CreateRootSignatureDeserializer(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes,
        [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface,
        void** ppRootSignatureDeserializer
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12CreateRootSignatureDeserializer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12CreateRootSignatureDeserializer(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes,
        [NativeTypeName("const IID &")] Ref<Guid> pRootSignatureDeserializerInterface,
        Ref2D ppRootSignatureDeserializer
    )
    {
        fixed (void** __dsl_ppRootSignatureDeserializer = ppRootSignatureDeserializer)
        fixed (
            Guid* __dsl_pRootSignatureDeserializerInterface = pRootSignatureDeserializerInterface
        )
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            return (HResult)D3D12CreateRootSignatureDeserializer(
                __dsl_pSrcData,
                SrcDataSizeInBytes,
                __dsl_pRootSignatureDeserializerInterface,
                __dsl_ppRootSignatureDeserializer
            );
        }
    }

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12CreateRootSignatureDeserializer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12CreateRootSignatureDeserializer<TCom>(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes,
        out TCom ppRootSignatureDeserializer
    )
        where TCom : unmanaged, IComVtbl
    {
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            ppRootSignatureDeserializer = default;
            return D3D12CreateRootSignatureDeserializer(
                __dsl_pSrcData,
                SrcDataSizeInBytes,
                TCom.NativeGuid,
                ppRootSignatureDeserializer.GetAddressOf()
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CreateVersionedRootSignatureDeserializer"]/*'/>

    [DllImport(
        "d3d12",
        ExactSpelling = true,
        EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer"
    )]
    public static extern HResult D3D12CreateVersionedRootSignatureDeserializer(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes,
        [NativeTypeName("const IID &")] Guid* pRootSignatureDeserializerInterface,
        void** ppRootSignatureDeserializer
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12CreateVersionedRootSignatureDeserializer(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes,
        [NativeTypeName("const IID &")] Ref<Guid> pRootSignatureDeserializerInterface,
        Ref2D ppRootSignatureDeserializer
    )
    {
        fixed (void** __dsl_ppRootSignatureDeserializer = ppRootSignatureDeserializer)
        fixed (
            Guid* __dsl_pRootSignatureDeserializerInterface = pRootSignatureDeserializerInterface
        )
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            return (HResult)D3D12CreateVersionedRootSignatureDeserializer(
                __dsl_pSrcData,
                SrcDataSizeInBytes,
                __dsl_pRootSignatureDeserializerInterface,
                __dsl_ppRootSignatureDeserializer
            );
        }
    }

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12CreateVersionedRootSignatureDeserializer<TCom>(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSizeInBytes,
        out TCom ppRootSignatureDeserializer
    )
        where TCom : unmanaged, IComVtbl
    {
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            ppRootSignatureDeserializer = default;
            return D3D12CreateVersionedRootSignatureDeserializer(
                __dsl_pSrcData,
                SrcDataSizeInBytes,
                TCom.NativeGuid,
                ppRootSignatureDeserializer.GetAddressOf()
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12EnableExperimentalFeatures"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "D3D12EnableExperimentalFeatures")]
    public static extern HResult D3D12EnableExperimentalFeatures(
        uint NumFeatures,
        [NativeTypeName("const IID *")] Guid* pIIDs,
        void* pConfigurationStructs,
        uint* pConfigurationStructSizes
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12EnableExperimentalFeatures")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12EnableExperimentalFeatures(
        uint NumFeatures,
        [NativeTypeName("const IID *")] Ref<Guid> pIIDs,
        Ref pConfigurationStructs,
        Ref<uint> pConfigurationStructSizes
    )
    {
        fixed (uint* __dsl_pConfigurationStructSizes = pConfigurationStructSizes)
        fixed (void* __dsl_pConfigurationStructs = pConfigurationStructs)
        fixed (Guid* __dsl_pIIDs = pIIDs)
        {
            return (HResult)D3D12EnableExperimentalFeatures(
                NumFeatures,
                __dsl_pIIDs,
                __dsl_pConfigurationStructs,
                __dsl_pConfigurationStructSizes
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetDebugInterface"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "D3D12GetDebugInterface")]
    public static extern HResult D3D12GetDebugInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvDebug
    );

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12GetDebugInterface")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12GetDebugInterface(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppvDebug
    )
    {
        fixed (void** __dsl_ppvDebug = ppvDebug)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)D3D12GetDebugInterface(__dsl_riid, __dsl_ppvDebug);
        }
    }

    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12GetDebugInterface")]
    public static HResult D3D12GetDebugInterface<TCom>(out TCom ppvDebug)
        where TCom : unmanaged, IComVtbl
    {
        ppvDebug = default;
        return D3D12GetDebugInterface(TCom.NativeGuid, ppvDebug.GetAddressOf());
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetInterface"]/*'/>

    [DllImport("d3d12", ExactSpelling = true, EntryPoint = "D3D12GetInterface")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern HResult D3D12GetInterface(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvDebug
    );

    [SupportedOSPlatform("windows10.0.19043.0")]
    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12GetInterface")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12GetInterface(
        [NativeTypeName("const IID &")] Ref<Guid> rclsid,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppvDebug
    )
    {
        fixed (void** __dsl_ppvDebug = ppvDebug)
        fixed (Guid* __dsl_riid = riid)
        fixed (Guid* __dsl_rclsid = rclsid)
        {
            return (HResult)D3D12GetInterface(__dsl_rclsid, __dsl_riid, __dsl_ppvDebug);
        }
    }

    [SupportedOSPlatform("windows10.0.19043.0")]
    [Transformed]
    [NativeFunction("d3d12", EntryPoint = "D3D12GetInterface")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12GetInterface<TCom>(
        [NativeTypeName("const IID &")] Ref<Guid> rclsid,
        out TCom ppvDebug
    )
        where TCom : unmanaged, IComVtbl
    {
        fixed (Guid* __dsl_rclsid = rclsid)
        {
            ppvDebug = default;
            return D3D12GetInterface(__dsl_rclsid, TCom.NativeGuid, ppvDebug.GetAddressOf());
        }
    }

    public static HResult D3D12SerializeRootSignature(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
            D3D12RootSignatureDesc* pRootSignature,
        D3DRootSignatureVersion Version,
        ID3DBlob* ppBlob,
        ID3DBlob* ppErrorBlob
    ) =>
        D3D12SerializeRootSignature(pRootSignature, Version, &ppBlob->LpVtbl, &ppErrorBlob->LpVtbl);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12SerializeRootSignature(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")]
            Ref<D3D12RootSignatureDesc> pRootSignature,
        D3DRootSignatureVersion Version,
        Ref<ID3DBlob> ppBlob,
        Ref<ID3DBlob> ppErrorBlob
    )
    {
        fixed (ID3DBlob* __dsl_ppErrorBlob = ppErrorBlob)
        fixed (ID3DBlob* __dsl_ppBlob = ppBlob)
        fixed (D3D12RootSignatureDesc* __dsl_pRootSignature = pRootSignature)
        {
            return (HResult)D3D12SerializeRootSignature(
                __dsl_pRootSignature,
                Version,
                __dsl_ppBlob,
                __dsl_ppErrorBlob
            );
        }
    }

    public static HResult D3D12SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            D3D12VersionedRootSignatureDesc* pRootSignature,
        ID3DBlob* ppBlob,
        ID3DBlob* ppErrorBlob
    ) =>
        D3D12SerializeVersionedRootSignature(pRootSignature, &ppBlob->LpVtbl, &ppErrorBlob->LpVtbl);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            Ref<D3D12VersionedRootSignatureDesc> pRootSignature,
        Ref<ID3DBlob> ppBlob,
        Ref<ID3DBlob> ppErrorBlob
    )
    {
        fixed (ID3DBlob* __dsl_ppErrorBlob = ppErrorBlob)
        fixed (ID3DBlob* __dsl_ppBlob = ppBlob)
        fixed (D3D12VersionedRootSignatureDesc* __dsl_pRootSignature = pRootSignature)
        {
            return (HResult)D3D12SerializeVersionedRootSignature(
                __dsl_pRootSignature,
                __dsl_ppBlob,
                __dsl_ppErrorBlob
            );
        }
    }
}
