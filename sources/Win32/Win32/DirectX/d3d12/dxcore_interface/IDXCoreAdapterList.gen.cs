// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList"]/*'/>
[Guid("526C7776-40E9-459B-B711-F32AD76DFC28")]
[NativeTypeName("struct IDXCoreAdapterList : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapterList : IDXCoreAdapterList.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapterList));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter);
        [VtblIndex(4)]
        [return: NativeTypeName("uint32_t")]
        uint GetAdapterCount();
        [VtblIndex(6)]
        HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetFactory([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory);
        [VtblIndex(8)]
        bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference);
        [VtblIndex(5)]
        bool IsStale();
        [VtblIndex(7)]
        HResult Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] Ref<DXCoreAdapterPreference> preferences);
    }

    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList"]/*'/>
    [Guid("526C7776-40E9-459B-B711-F32AD76DFC28")]
    [NativeTypeName("struct IDXCoreAdapterList : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDXCoreAdapterList));

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
            [NativeTypeName("HRESULT (uint32_t, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, Guid*, void**, HResult> GetAdapter;
            [NativeTypeName("uint32_t () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetAdapterCount;
            [NativeTypeName("bool () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, byte> IsStale;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetFactory;
            [NativeTypeName("HRESULT (uint32_t, const DXCoreAdapterPreference *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, DXCoreAdapterPreference*, HResult> Sort;
            [NativeTypeName("bool (DXCoreAdapterPreference) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXCoreAdapterPreference, byte> IsAdapterPreferenceSupported;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, uint> )(lpVtbl[1]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.GetAdapter"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, uint, Guid*, void**, HResult> )(lpVtbl[3]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this), index, riid, ppvAdapter);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter)
        {
            fixed (void** __dsl_ppvAdapter = ppvAdapter)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetAdapter(index, __dsl_riid, __dsl_ppvAdapter);
            }
        }

        [VtblIndex(3)]
        [Transformed]
        public HResult GetAdapter<TCom>([NativeTypeName("uint32_t")] uint index, out TCom ppvAdapter)
            where TCom : unmanaged, IComVtbl
        {
            ppvAdapter = default;
            return GetAdapter(index, TCom.NativeGuid, ppvAdapter.GetAddressOf());
        }

        /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.GetAdapterCount"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("uint32_t")]
        public uint GetAdapterCount()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, uint> )(lpVtbl[4]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.GetFactory"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, Guid*, void**, HResult> )(lpVtbl[6]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetFactory([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory)
        {
            fixed (void** __dsl_ppvFactory = ppvFactory)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetFactory(__dsl_riid, __dsl_ppvFactory);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        public HResult GetFactory<TCom>(out TCom ppvFactory)
            where TCom : unmanaged, IComVtbl
        {
            ppvFactory = default;
            return GetFactory(TCom.NativeGuid, ppvFactory.GetAddressOf());
        }

        /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.IsAdapterPreferenceSupported"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, DXCoreAdapterPreference, byte> )(lpVtbl[8]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this), preference) != 0;
        }

        /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.IsStale"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public bool IsStale()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, byte> )(lpVtbl[5]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this)) != 0;
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, uint> )(lpVtbl[2]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.Sort"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList.Native*, uint, DXCoreAdapterPreference*, HResult> )(lpVtbl[7]))((IDXCoreAdapterList.Native*)Unsafe.AsPointer(ref this), numPreferences, preferences);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] Ref<DXCoreAdapterPreference> preferences)
        {
            fixed (DXCoreAdapterPreference* __dsl_preferences = preferences)
            {
                return (HResult)Sort(numPreferences, __dsl_preferences);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapterList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapterList(Ptr3D vtbl) => LpVtbl = (IDXCoreAdapterList.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapterList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapterList(Ptr<IDXCoreAdapterList.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDXCoreAdapterList.Native"/> to <see cref = "IDXCoreAdapterList"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList.Native"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapterList(IDXCoreAdapterList.Native* value) => new IDXCoreAdapterList((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapterList"/> to <see cref = "IDXCoreAdapterList.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList"/> instance to be converted </param>
    public static implicit operator IDXCoreAdapterList.Native*(IDXCoreAdapterList value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDXCoreAdapterList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterList(Ptr3D value) => new IDXCoreAdapterList(value);
    /// <summary>casts <see cref = "IDXCoreAdapterList"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDXCoreAdapterList value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDXCoreAdapterList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterList(Ptr<IDXCoreAdapterList.Native> value) => new IDXCoreAdapterList(value);
    /// <summary>casts <see cref = "IDXCoreAdapterList"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList"/> instance to be converted </param>
    public static implicit operator Ptr<IDXCoreAdapterList.Native>(IDXCoreAdapterList value) => (Ptr<IDXCoreAdapterList.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDXCoreAdapterList"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDXCoreAdapterList(void*** value) => new IDXCoreAdapterList((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDXCoreAdapterList"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList"/> instance to be converted </param>
    public static implicit operator void***(IDXCoreAdapterList value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDXCoreAdapterList"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterList(nuint value) => new IDXCoreAdapterList((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDXCoreAdapterList"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList"/> instance to be converted </param>
    public static implicit operator nuint(IDXCoreAdapterList value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.GetAdapter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter) => LpVtbl->GetAdapter(index, riid, ppvAdapter);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter)
    {
        fixed (void** __dsl_ppvAdapter = ppvAdapter)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetAdapter(index, __dsl_riid, __dsl_ppvAdapter);
        }
    }

    [VtblIndex(3)]
    [Transformed]
    public HResult GetAdapter<TCom>([NativeTypeName("uint32_t")] uint index, out TCom ppvAdapter)
        where TCom : unmanaged, IComVtbl
    {
        ppvAdapter = default;
        return GetAdapter(index, TCom.NativeGuid, ppvAdapter.GetAddressOf());
    }

    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.GetAdapterCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("uint32_t")]
    public uint GetAdapterCount() => LpVtbl->GetAdapterCount();
    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.GetFactory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory) => LpVtbl->GetFactory(riid, ppvFactory);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFactory([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvFactory)
    {
        fixed (void** __dsl_ppvFactory = ppvFactory)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetFactory(__dsl_riid, __dsl_ppvFactory);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    public HResult GetFactory<TCom>(out TCom ppvFactory)
        where TCom : unmanaged, IComVtbl
    {
        ppvFactory = default;
        return GetFactory(TCom.NativeGuid, ppvFactory.GetAddressOf());
    }

    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.IsAdapterPreferenceSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference) => LpVtbl->IsAdapterPreferenceSupported(preference);
    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.IsStale"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsStale() => LpVtbl->IsStale();
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
    /// <include file='IDXCoreAdapterList.xml' path='doc/member[@name="IDXCoreAdapterList.Sort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences) => LpVtbl->Sort(numPreferences, preferences);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] Ref<DXCoreAdapterPreference> preferences)
    {
        fixed (DXCoreAdapterPreference* __dsl_preferences = preferences)
        {
            return (HResult)Sort(numPreferences, __dsl_preferences);
        }
    }
}