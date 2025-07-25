// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1"]/*'/>
[Guid("770AAE78-F26F-4DBA-A829-253C83D1B387")]
[NativeTypeName("struct IDXGIFactory1 : IDXGIFactory")]
[NativeInheritance("IDXGIFactory")]
public unsafe partial struct IdxgiFactory1 : IdxgiFactory1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiFactory1));

    public interface Interface : IdxgiFactory.Interface
    {
        [VtblIndex(12)]
        HResult EnumAdapters1(uint Adapter, IdxgiAdapter1* ppAdapter);

        [VtblIndex(12)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult EnumAdapters1(uint Adapter, Ref<IdxgiAdapter1> ppAdapter);

        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> IsCurrent();
    }

    /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1"]/*'/>

    [Guid("770AAE78-F26F-4DBA-A829-253C83D1B387")]
    [NativeTypeName("struct IDXGIFactory1 : IDXGIFactory")]
    [NativeInheritance("IDXGIFactory")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiFactory1));
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

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                Guid*,
                IUnknown.Native*,
                HResult> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IdxgiAdapter.Native**, HResult> EnumAdapters;

            [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HWND, uint, HResult> MakeWindowAssociation;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HWND*, HResult> GetWindowAssociation;

            [NativeTypeName(
                "HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                DxgiSwapChainDesc*,
                IdxgiSwapChain.Native**,
                HResult> CreateSwapChain;

            [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                Hmodule,
                IdxgiAdapter.Native**,
                HResult> CreateSoftwareAdapter;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IdxgiAdapter1.Native**, HResult> EnumAdapters1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> IsCurrent;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiFactory1.Native*, uint>)(lpVtbl[1]))(
                (IdxgiFactory1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiFactory.CreateSoftwareAdapter"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CreateSoftwareAdapter(Hmodule Module, IdxgiAdapter* ppAdapter)
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactory1.Native*,
                    Hmodule,
                    IdxgiAdapter.Native**,
                    HResult>)(lpVtbl[11])
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), Module, &ppAdapter->LpVtbl);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSoftwareAdapter(Hmodule Module, Ref<IdxgiAdapter> ppAdapter)
        {
            fixed (IdxgiAdapter* __dsl_ppAdapter = ppAdapter)
            {
                return (HResult)CreateSoftwareAdapter(Module, __dsl_ppAdapter);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory.CreateSwapChain"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult CreateSwapChain(
            IUnknown pDevice,
            DxgiSwapChainDesc* pDesc,
            IdxgiSwapChain* ppSwapChain
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactory1.Native*,
                    IUnknown.Native*,
                    DxgiSwapChainDesc*,
                    IdxgiSwapChain.Native**,
                    HResult>)(lpVtbl[10])
            )(
                (IdxgiFactory1.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                pDesc,
                &ppSwapChain->LpVtbl
            );
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSwapChain(
            IUnknown pDevice,
            Ref<DxgiSwapChainDesc> pDesc,
            Ref<IdxgiSwapChain> ppSwapChain
        )
        {
            fixed (IdxgiSwapChain* __dsl_ppSwapChain = ppSwapChain)
            fixed (DxgiSwapChainDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateSwapChain(pDevice, __dsl_pDesc, __dsl_ppSwapChain);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory.EnumAdapters"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult EnumAdapters(uint Adapter, IdxgiAdapter* ppAdapter)
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, uint, IdxgiAdapter.Native**, HResult>)(
                    lpVtbl[7]
                )
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), Adapter, &ppAdapter->LpVtbl);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult EnumAdapters(uint Adapter, Ref<IdxgiAdapter> ppAdapter)
        {
            fixed (IdxgiAdapter* __dsl_ppAdapter = ppAdapter)
            {
                return (HResult)EnumAdapters(Adapter, __dsl_ppAdapter);
            }
        }

        /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1.EnumAdapters1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult EnumAdapters1(uint Adapter, IdxgiAdapter1* ppAdapter)
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, uint, IdxgiAdapter1.Native**, HResult>)(
                    lpVtbl[12]
                )
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), Adapter, &ppAdapter->LpVtbl);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult EnumAdapters1(uint Adapter, Ref<IdxgiAdapter1> ppAdapter)
        {
            fixed (IdxgiAdapter1* __dsl_ppAdapter = ppAdapter)
            {
                return (HResult)EnumAdapters1(Adapter, __dsl_ppAdapter);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent)
        {
            fixed (void** __dsl_ppParent = ppParent)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetParent(__dsl_riid, __dsl_ppParent);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        public HResult GetParent<TCom>(out TCom ppParent)
            where TCom : unmanaged, IComVtbl
        {
            ppParent = default;
            return GetParent(TCom.NativeGuid, ppParent.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiObject.GetPrivateData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint* pDataSize,
            void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            Ref<uint> pDataSize,
            Ref pData
        )
        {
            fixed (void* __dsl_pData = pData)
            fixed (uint* __dsl_pDataSize = pDataSize)
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)GetPrivateData(__dsl_Name, __dsl_pDataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory.GetWindowAssociation"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetWindowAssociation(HWND* pWindowHandle)
        {
            return ((delegate* unmanaged<IdxgiFactory1.Native*, HWND*, HResult>)(lpVtbl[9]))(
                (IdxgiFactory1.Native*)Unsafe.AsPointer(ref this),
                pWindowHandle
            );
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetWindowAssociation(Ref<HWND> pWindowHandle)
        {
            fixed (HWND* __dsl_pWindowHandle = pWindowHandle)
            {
                return (HResult)GetWindowAssociation(__dsl_pWindowHandle);
            }
        }

        /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1.IsCurrent"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsCurrent()
        {
            return ((delegate* unmanaged<IdxgiFactory1.Native*, MaybeBool<int>>)(lpVtbl[13]))(
                (IdxgiFactory1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiFactory.MakeWindowAssociation"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult MakeWindowAssociation(HWND WindowHandle, uint Flags)
        {
            return ((delegate* unmanaged<IdxgiFactory1.Native*, HWND, uint, HResult>)(lpVtbl[8]))(
                (IdxgiFactory1.Native*)Unsafe.AsPointer(ref this),
                WindowHandle,
                Flags
            );
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
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
            return ((delegate* unmanaged<IdxgiFactory1.Native*, uint>)(lpVtbl[2]))(
                (IdxgiFactory1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiObject.SetPrivateData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint DataSize,
            [NativeTypeName("const void *")] void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            uint DataSize,
            [NativeTypeName("const void *")] Ref pData
        )
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)SetPrivateData(__dsl_Name, DataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.SetPrivateDataInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Guid* Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory1.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiFactory1.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)SetPrivateDataInterface(__dsl_Name, pUnknown);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiFactory1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiFactory1(Ptr3D vtbl) => LpVtbl = (IdxgiFactory1.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiFactory1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiFactory1(Ptr<IdxgiFactory1.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiFactory1.Native"/> to <see cref = "IdxgiFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory1.Native"/> instance to be converted </param>

    public static implicit operator IdxgiFactory1(IdxgiFactory1.Native* value) =>
        new IdxgiFactory1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiFactory1"/> to <see cref = "IdxgiFactory1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory1"/> instance to be converted </param>

    public static implicit operator IdxgiFactory1.Native*(IdxgiFactory1 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiFactory1(Ptr3D value) => new IdxgiFactory1(value);

    /// <summary>casts <see cref = "IdxgiFactory1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory1"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiFactory1 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiFactory1(Ptr<IdxgiFactory1.Native> value) =>
        new IdxgiFactory1(value);

    /// <summary>casts <see cref = "IdxgiFactory1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory1"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiFactory1.Native>(IdxgiFactory1 value) =>
        (Ptr<IdxgiFactory1.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiFactory1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiFactory1(void*** value) =>
        new IdxgiFactory1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiFactory1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory1"/> instance to be converted </param>

    public static implicit operator void***(IdxgiFactory1 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiFactory1(nuint value) =>
        new IdxgiFactory1((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiFactory1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory1"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiFactory1 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <inheritdoc cref = "IdxgiFactory.CreateSoftwareAdapter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult CreateSoftwareAdapter(Hmodule Module, IdxgiAdapter* ppAdapter) =>
        LpVtbl->CreateSoftwareAdapter(Module, ppAdapter);

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSoftwareAdapter(Hmodule Module, Ref<IdxgiAdapter> ppAdapter)
    {
        fixed (IdxgiAdapter* __dsl_ppAdapter = ppAdapter)
        {
            return (HResult)CreateSoftwareAdapter(Module, __dsl_ppAdapter);
        }
    }

    /// <inheritdoc cref = "IdxgiFactory.CreateSwapChain"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult CreateSwapChain(
        IUnknown pDevice,
        DxgiSwapChainDesc* pDesc,
        IdxgiSwapChain* ppSwapChain
    ) => LpVtbl->CreateSwapChain(pDevice, pDesc, ppSwapChain);

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSwapChain(
        IUnknown pDevice,
        Ref<DxgiSwapChainDesc> pDesc,
        Ref<IdxgiSwapChain> ppSwapChain
    )
    {
        fixed (IdxgiSwapChain* __dsl_ppSwapChain = ppSwapChain)
        fixed (DxgiSwapChainDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateSwapChain(pDevice, __dsl_pDesc, __dsl_ppSwapChain);
        }
    }

    /// <inheritdoc cref = "IdxgiFactory.EnumAdapters"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult EnumAdapters(uint Adapter, IdxgiAdapter* ppAdapter) =>
        LpVtbl->EnumAdapters(Adapter, ppAdapter);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumAdapters(uint Adapter, Ref<IdxgiAdapter> ppAdapter)
    {
        fixed (IdxgiAdapter* __dsl_ppAdapter = ppAdapter)
        {
            return (HResult)EnumAdapters(Adapter, __dsl_ppAdapter);
        }
    }

    /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1.EnumAdapters1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult EnumAdapters1(uint Adapter, IdxgiAdapter1* ppAdapter) =>
        LpVtbl->EnumAdapters1(Adapter, ppAdapter);

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumAdapters1(uint Adapter, Ref<IdxgiAdapter1> ppAdapter)
    {
        fixed (IdxgiAdapter1* __dsl_ppAdapter = ppAdapter)
        {
            return (HResult)EnumAdapters1(Adapter, __dsl_ppAdapter);
        }
    }

    /// <inheritdoc cref = "IdxgiObject.GetParent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent) =>
        LpVtbl->GetParent(riid, ppParent);

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent)
    {
        fixed (void** __dsl_ppParent = ppParent)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetParent(__dsl_riid, __dsl_ppParent);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    public HResult GetParent<TCom>(out TCom ppParent)
        where TCom : unmanaged, IComVtbl
    {
        ppParent = default;
        return GetParent(TCom.NativeGuid, ppParent.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiObject.GetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    ) => LpVtbl->GetPrivateData(Name, pDataSize, pData);

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        Ref<uint> pDataSize,
        Ref pData
    )
    {
        fixed (void* __dsl_pData = pData)
        fixed (uint* __dsl_pDataSize = pDataSize)
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)GetPrivateData(__dsl_Name, __dsl_pDataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "IdxgiFactory.GetWindowAssociation"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetWindowAssociation(HWND* pWindowHandle) =>
        LpVtbl->GetWindowAssociation(pWindowHandle);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetWindowAssociation(Ref<HWND> pWindowHandle)
    {
        fixed (HWND* __dsl_pWindowHandle = pWindowHandle)
        {
            return (HResult)GetWindowAssociation(__dsl_pWindowHandle);
        }
    }

    /// <include file='IDXGIFactory1.xml' path='doc/member[@name="IDXGIFactory1.IsCurrent"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsCurrent() => LpVtbl->IsCurrent();

    /// <inheritdoc cref = "IdxgiFactory.MakeWindowAssociation"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult MakeWindowAssociation(HWND WindowHandle, uint Flags) =>
        LpVtbl->MakeWindowAssociation(WindowHandle, Flags);

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        LpVtbl->QueryInterface(riid, ppvObject);

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

    /// <inheritdoc cref = "IdxgiObject.SetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    ) => LpVtbl->SetPrivateData(Name, DataSize, pData);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        uint DataSize,
        [NativeTypeName("const void *")] Ref pData
    )
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)SetPrivateData(__dsl_Name, DataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "IdxgiObject.SetPrivateDataInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    ) => LpVtbl->SetPrivateDataInterface(Name, pUnknown);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)SetPrivateDataInterface(__dsl_Name, pUnknown);
        }
    }
}
