// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DeviceConfiguration1.xml' path='doc/member[@name="ID3D12DeviceConfiguration1"]/*'/>
[Guid("ED342442-6343-4E16-BB82-A3A577874E56")]
[NativeTypeName("struct ID3D12DeviceConfiguration1 : ID3D12DeviceConfiguration")]
[NativeInheritance("ID3D12DeviceConfiguration")]
public unsafe partial struct ID3D12DeviceConfiguration1 : ID3D12DeviceConfiguration1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceConfiguration1));

    public interface Interface : ID3D12DeviceConfiguration.Interface
    {
        [VtblIndex(7)]
        HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] ushort* RootSignatureSubobjectName, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([NativeTypeName("const void *")] Ref pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] Ref<ushort> RootSignatureSubobjectName, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDeserializer);
    }

    /// <include file='ID3D12DeviceConfiguration1.xml' path='doc/member[@name="ID3D12DeviceConfiguration1"]/*'/>
    [Guid("ED342442-6343-4E16-BB82-A3A577874E56")]
    [NativeTypeName("struct ID3D12DeviceConfiguration1 : ID3D12DeviceConfiguration")]
    [NativeInheritance("ID3D12DeviceConfiguration")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DeviceConfiguration1));

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
            [NativeTypeName("HRESULT (const void *, SIZE_T, LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, nuint, ushort*, Guid*, void**, HResult> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, uint> )(lpVtbl[1]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12DeviceConfiguration.CreateVersionedRootSignatureDeserializer"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult CreateVersionedRootSignatureDeserializer([NativeTypeName("const void *")] void* pBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, void*, nuint, Guid*, void**, HResult> )(lpVtbl[6]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this), pBlob, Size, riid, ppvDeserializer);
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

        /// <include file='ID3D12DeviceConfiguration1.xml' path='doc/member[@name="ID3D12DeviceConfiguration1.CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] ushort* RootSignatureSubobjectName, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, void*, nuint, ushort*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this), pLibraryBlob, Size, RootSignatureSubobjectName, riid, ppvDeserializer);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([NativeTypeName("const void *")] Ref pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] Ref<ushort> RootSignatureSubobjectName, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDeserializer)
        {
            fixed (void** __dsl_ppvDeserializer = ppvDeserializer)
            fixed (Guid* __dsl_riid = riid)
            fixed (ushort* __dsl_RootSignatureSubobjectName = RootSignatureSubobjectName)
            fixed (void* __dsl_pLibraryBlob = pLibraryBlob)
            {
                return (HResult)CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(__dsl_pLibraryBlob, Size, __dsl_RootSignatureSubobjectName, __dsl_riid, __dsl_ppvDeserializer);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TCom>([NativeTypeName("const void *")] Ref pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] Ref<ushort> RootSignatureSubobjectName, out TCom ppvDeserializer)
            where TCom : unmanaged, IComVtbl
        {
            fixed (ushort* __dsl_RootSignatureSubobjectName = RootSignatureSubobjectName)
            fixed (void* __dsl_pLibraryBlob = pLibraryBlob)
            {
                ppvDeserializer = default;
                return CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(__dsl_pLibraryBlob, Size, __dsl_RootSignatureSubobjectName, TCom.NativeGuid, ppvDeserializer.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12DeviceConfiguration.GetDesc"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public D3D12DeviceConfigurationDesc GetDesc()
        {
            D3D12DeviceConfigurationDesc result;
            return *((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, D3D12DeviceConfigurationDesc*, D3D12DeviceConfigurationDesc*> )(lpVtbl[3]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12DeviceConfiguration.GetEnabledExperimentalFeatures"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, Guid*, uint, HResult> )(lpVtbl[4]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this), pGuids, NumGuids);
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
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, uint> )(lpVtbl[2]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12DeviceConfiguration.SerializeVersionedRootSignature"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SerializeVersionedRootSignature([NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")] D3D12VersionedRootSignatureDesc* pDesc, ID3DBlob* ppResult, ID3DBlob* ppError)
        {
            return ((delegate* unmanaged<ID3D12DeviceConfiguration1.Native*, D3D12VersionedRootSignatureDesc*, ID3DBlob.Native**, ID3DBlob.Native**, HResult> )(lpVtbl[5]))((ID3D12DeviceConfiguration1.Native*)Unsafe.AsPointer(ref this), pDesc, &ppResult->LpVtbl, &ppError->LpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceConfiguration1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceConfiguration1(Ptr3D vtbl) => LpVtbl = (ID3D12DeviceConfiguration1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceConfiguration1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceConfiguration1(Ptr<ID3D12DeviceConfiguration1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration1.Native"/> to <see cref = "ID3D12DeviceConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceConfiguration1(ID3D12DeviceConfiguration1.Native* value) => new ID3D12DeviceConfiguration1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration1"/> to <see cref = "ID3D12DeviceConfiguration1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration1"/> instance to be converted </param>
    public static implicit operator ID3D12DeviceConfiguration1.Native*(ID3D12DeviceConfiguration1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DeviceConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration1(Ptr3D value) => new ID3D12DeviceConfiguration1(value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DeviceConfiguration1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DeviceConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration1(Ptr<ID3D12DeviceConfiguration1.Native> value) => new ID3D12DeviceConfiguration1(value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DeviceConfiguration1.Native>(ID3D12DeviceConfiguration1 value) => (Ptr<ID3D12DeviceConfiguration1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DeviceConfiguration1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration1(void*** value) => new ID3D12DeviceConfiguration1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DeviceConfiguration1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DeviceConfiguration1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceConfiguration1(nuint value) => new ID3D12DeviceConfiguration1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DeviceConfiguration1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceConfiguration1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DeviceConfiguration1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "ID3D12DeviceConfiguration.CreateVersionedRootSignatureDeserializer"/>
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

    /// <include file='ID3D12DeviceConfiguration1.xml' path='doc/member[@name="ID3D12DeviceConfiguration1.CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] ushort* RootSignatureSubobjectName, [NativeTypeName("const IID &")] Guid* riid, void** ppvDeserializer) => LpVtbl->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, RootSignatureSubobjectName, riid, ppvDeserializer);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([NativeTypeName("const void *")] Ref pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] Ref<ushort> RootSignatureSubobjectName, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDeserializer)
    {
        fixed (void** __dsl_ppvDeserializer = ppvDeserializer)
        fixed (Guid* __dsl_riid = riid)
        fixed (ushort* __dsl_RootSignatureSubobjectName = RootSignatureSubobjectName)
        fixed (void* __dsl_pLibraryBlob = pLibraryBlob)
        {
            return (HResult)CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(__dsl_pLibraryBlob, Size, __dsl_RootSignatureSubobjectName, __dsl_riid, __dsl_ppvDeserializer);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TCom>([NativeTypeName("const void *")] Ref pLibraryBlob, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("LPCWSTR")] Ref<ushort> RootSignatureSubobjectName, out TCom ppvDeserializer)
        where TCom : unmanaged, IComVtbl
    {
        fixed (ushort* __dsl_RootSignatureSubobjectName = RootSignatureSubobjectName)
        fixed (void* __dsl_pLibraryBlob = pLibraryBlob)
        {
            ppvDeserializer = default;
            return CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(__dsl_pLibraryBlob, Size, __dsl_RootSignatureSubobjectName, TCom.NativeGuid, ppvDeserializer.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12DeviceConfiguration.GetDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public D3D12DeviceConfigurationDesc GetDesc() => LpVtbl->GetDesc();
    /// <inheritdoc cref = "ID3D12DeviceConfiguration.GetEnabledExperimentalFeatures"/>
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
    /// <inheritdoc cref = "ID3D12DeviceConfiguration.SerializeVersionedRootSignature"/>
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