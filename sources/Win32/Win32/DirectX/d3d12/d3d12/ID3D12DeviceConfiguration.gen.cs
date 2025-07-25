// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration"]/*'/>
[Guid("78DBF87B-F766-422B-A61C-C8C446BDB9AD")]
[NativeTypeName("struct ID3D12DeviceConfiguration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceConfiguration : ID3D12DeviceConfiguration.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceConfiguration));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(6)]
        HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] void* pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] Ref pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDeserializer);
        [VtblIndex(3)]
        D3D12DeviceConfigurationDesc GetDesc();
        [VtblIndex(4)]
        HResult GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetEnabledExperimentalFeatures(Ref<Guid> pGuids, uint NumGuids);
        [VtblIndex(5)]
        HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12VersionedRootSignatureDesc* pDesc, ID3DBlob* ppResult, ID3DBlob* ppError);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] Ref<D3D12VersionedRootSignatureDesc> pDesc, Ref<ID3DBlob> ppResult, Ref<ID3DBlob> ppError);
    }

    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration"]/*'/>
    [Guid("78DBF87B-F766-422B-A61C-C8C446BDB9AD")]
    [NativeTypeName("struct ID3D12DeviceConfiguration : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceConfiguration));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;
            [NativeTypeName("D3D12_DEVICE_CONFIGURATION_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DeviceConfigurationDesc*, D3D12DeviceConfigurationDesc*> GetDesc;
            [NativeTypeName("HRESULT (GUID *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, HResult> GetEnabledExperimentalFeatures;
            [NativeTypeName("HRESULT (const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *, ID3DBlob **, ID3DBlob **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VersionedRootSignatureDesc*, ID3DBlob.Native**, ID3DBlob.Native**, HResult> SerializeVersionedRootSignature;
            [NativeTypeName("HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, nuint, Guid*, void**, HResult> CreateVersionedRootSignatureDeserializer;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, uint> )(lpVtbl[1]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.CreateVersionedRootSignatureDeserializer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] void* pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, void*, nuint, Guid*, void**, HResult> )(lpVtbl[6]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this), pBlob, Size, riid, ppvDeserializer);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] Ref pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDeserializer)
        {
            fixed (void** __dsl_ppvDeserializer = ppvDeserializer)
            fixed (Guid* __dsl_riid = riid)
            fixed (void* __dsl_pBlob = pBlob)
            {
                return (HResult)CreateVersionedRootSignatureDeserializer(__dsl_pBlob, Size, __dsl_riid, __dsl_ppvDeserializer);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVersionedRootSignatureDeserializer<TCom>([NativeTypeName("const void *")] Ref pBlob, [NativeTypeName("SIZE_T")] nuint Size, out TCom ppvDeserializer)
            where TCom : unmanaged, IComVtbl
        {
            fixed (void* __dsl_pBlob = pBlob)
            {
                ppvDeserializer = default;
                return CreateVersionedRootSignatureDeserializer(__dsl_pBlob, Size, TCom.NativeGuid, ppvDeserializer.GetAddressOf());
            }
        }

        /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public D3D12DeviceConfigurationDesc GetDesc()
        {
            D3D12DeviceConfigurationDesc result;
            return *((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, D3D12DeviceConfigurationDesc*, D3D12DeviceConfigurationDesc*> )(lpVtbl[3]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.GetEnabledExperimentalFeatures"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, Guid*, uint, HResult> )(lpVtbl[4]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this), pGuids, NumGuids);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetEnabledExperimentalFeatures(Ref<Guid> pGuids, uint NumGuids)
        {
            fixed (Guid* __dsl_pGuids = pGuids)
            {
                return (HResult)GetEnabledExperimentalFeatures(__dsl_pGuids, NumGuids);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, uint> )(lpVtbl[2]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.SerializeVersionedRootSignature"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12VersionedRootSignatureDesc* pDesc, ID3DBlob* ppResult, ID3DBlob* ppError)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration.Native*, D3D12VersionedRootSignatureDesc*, ID3DBlob.Native**, ID3DBlob.Native**, HResult> )(lpVtbl[5]))((ID3D12DeviceConfiguration.Native*)Unsafe.AsPointer(ref this), pDesc, &ppResult->LpVtbl, &ppError->LpVtbl);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] Ref<D3D12VersionedRootSignatureDesc> pDesc, Ref<ID3DBlob> ppResult, Ref<ID3DBlob> ppError)
        {
            fixed (ID3DBlob* __dsl_ppError = ppError)
            fixed (ID3DBlob* __dsl_ppResult = ppResult)
            fixed (D3D12VersionedRootSignatureDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)SerializeVersionedRootSignature(__dsl_pDesc, __dsl_ppResult, __dsl_ppError);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceConfiguration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceConfiguration(Ptr3D vtbl) => LpVtbl = (ID3D12DeviceConfiguration.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceConfiguration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceConfiguration(Ptr<ID3D12DeviceConfiguration.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration.Native"/> to <see cref = "ID3D12DeviceConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceConfiguration(ID3D12DeviceConfiguration.Native* value) => new ID3D12DeviceConfiguration((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration"/> to <see cref = "ID3D12DeviceConfiguration.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceConfiguration.Native*(ID3D12DeviceConfiguration value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DeviceConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration(Ptr3D value) => new ID3D12DeviceConfiguration(value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DeviceConfiguration value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DeviceConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration(Ptr<ID3D12DeviceConfiguration.Native> value) => new ID3D12DeviceConfiguration(value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DeviceConfiguration.Native>(ID3D12DeviceConfiguration value) => (Ptr<ID3D12DeviceConfiguration.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DeviceConfiguration"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration(void*** value) => new ID3D12DeviceConfiguration((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DeviceConfiguration value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DeviceConfiguration"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration(nuint value) => new ID3D12DeviceConfiguration((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DeviceConfiguration value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.CreateVersionedRootSignatureDeserializer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] void* pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer) => LpVtbl->CreateVersionedRootSignatureDeserializer(pBlob, Size, riid, ppvDeserializer);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] Ref pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDeserializer)
    {
        fixed (void** __dsl_ppvDeserializer = ppvDeserializer)
        fixed (Guid* __dsl_riid = riid)
        fixed (void* __dsl_pBlob = pBlob)
        {
            return (HResult)CreateVersionedRootSignatureDeserializer(__dsl_pBlob, Size, __dsl_riid, __dsl_ppvDeserializer);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVersionedRootSignatureDeserializer<TCom>([NativeTypeName("const void *")] Ref pBlob, [NativeTypeName("SIZE_T")] nuint Size, out TCom ppvDeserializer)
        where TCom : unmanaged, IComVtbl
    {
        fixed (void* __dsl_pBlob = pBlob)
        {
            ppvDeserializer = default;
            return CreateVersionedRootSignatureDeserializer(__dsl_pBlob, Size, TCom.NativeGuid, ppvDeserializer.GetAddressOf());
        }
    }

    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public D3D12DeviceConfigurationDesc GetDesc() => LpVtbl->GetDesc();
    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.GetEnabledExperimentalFeatures"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids) => LpVtbl->GetEnabledExperimentalFeatures(pGuids, NumGuids);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetEnabledExperimentalFeatures(Ref<Guid> pGuids, uint NumGuids)
    {
        fixed (Guid* __dsl_pGuids = pGuids)
        {
            return (HResult)GetEnabledExperimentalFeatures(__dsl_pGuids, NumGuids);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => LpVtbl->QueryInterface(riid, ppvObject);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
    /// <include file='ID3D12DeviceConfiguration.xml' path='doc/member[@name="ID3D12DeviceConfiguration.SerializeVersionedRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12VersionedRootSignatureDesc* pDesc, ID3DBlob* ppResult, ID3DBlob* ppError) => LpVtbl->SerializeVersionedRootSignature(pDesc, ppResult, ppError);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] Ref<D3D12VersionedRootSignatureDesc> pDesc, Ref<ID3DBlob> ppResult, Ref<ID3DBlob> ppError)
    {
        fixed (ID3DBlob* __dsl_ppError = ppError)
        fixed (ID3DBlob* __dsl_ppResult = ppResult)
        fixed (D3D12VersionedRootSignatureDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)SerializeVersionedRootSignature(__dsl_pDesc, __dsl_ppResult, __dsl_ppError);
        }
    }
}