// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIFactory4.xml' path='doc/member[@name="IDXGIFactory4"]/*'/>
[Guid("1BC6EA02-EF36-464F-BF0C-21CA39E5168A")]
[NativeTypeName("struct IDXGIFactory4 : IDXGIFactory3")]
[NativeInheritance("IDXGIFactory3")]
public unsafe partial struct IdxgiFactory4 : IdxgiFactory4.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiFactory4));

    public interface Interface : IdxgiFactory3.Interface
    {
        [VtblIndex(26)]
        HResult EnumAdapterByLuid(
            LUID AdapterLuid,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvAdapter
        );

        [VtblIndex(26)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult EnumAdapterByLuid(
            LUID AdapterLuid,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvAdapter
        );

        [VtblIndex(27)]
        HResult EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter);

        [VtblIndex(27)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult EnumWarpAdapter([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter);
    }

    /// <include file='IDXGIFactory4.xml' path='doc/member[@name="IDXGIFactory4"]/*'/>

    [Guid("1BC6EA02-EF36-464F-BF0C-21CA39E5168A")]
    [NativeTypeName("struct IDXGIFactory4 : IDXGIFactory3")]
    [NativeInheritance("IDXGIFactory3")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiFactory4));
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

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> IsWindowedStereoEnabled;

            [NativeTypeName(
                "HRESULT (IUnknown *, HWND, const DXGI_SWAP_CHAIN_DESC1 *, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                HWND,
                DxgiSwapChainDesc1*,
                DxgiSwapChainFullscreenDesc*,
                IdxgiOutput.Native*,
                IdxgiSwapChain1.Native**,
                HResult> CreateSwapChainForHwnd;

            [NativeTypeName(
                "HRESULT (IUnknown *, IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                IUnknown.Native*,
                DxgiSwapChainDesc1*,
                IdxgiOutput.Native*,
                IdxgiSwapChain1.Native**,
                HResult> CreateSwapChainForCoreWindow;

            [NativeTypeName("HRESULT (HANDLE, LUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Handle, LUID*, HResult> GetSharedResourceAdapterLuid;

            [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                HWND,
                uint,
                uint*,
                HResult> RegisterStereoStatusWindow;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Handle, uint*, HResult> RegisterStereoStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void> UnregisterStereoStatus;

            [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                HWND,
                uint,
                uint*,
                HResult> RegisterOcclusionStatusWindow;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Handle, uint*, HResult> RegisterOcclusionStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void> UnregisterOcclusionStatus;

            [NativeTypeName(
                "HRESULT (IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                DxgiSwapChainDesc1*,
                IdxgiOutput.Native*,
                IdxgiSwapChain1.Native**,
                HResult> CreateSwapChainForComposition;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetCreationFlags;

            [NativeTypeName("HRESULT (LUID, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, LUID, Guid*, void**, HResult> EnumAdapterByLuid;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> EnumWarpAdapter;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, uint>)(lpVtbl[1]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiFactory.CreateSoftwareAdapter"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CreateSoftwareAdapter(Hmodule Module, IdxgiAdapter* ppAdapter)
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactory4.Native*,
                    Hmodule,
                    IdxgiAdapter.Native**,
                    HResult>)(lpVtbl[11])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), Module, &ppAdapter->LpVtbl);
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
                    IdxgiFactory4.Native*,
                    IUnknown.Native*,
                    DxgiSwapChainDesc*,
                    IdxgiSwapChain.Native**,
                    HResult>)(lpVtbl[10])
            )(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IdxgiFactory2.CreateSwapChainForComposition"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HResult CreateSwapChainForComposition(
            IUnknown pDevice,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
            IdxgiOutput pRestrictToOutput,
            IdxgiSwapChain1* ppSwapChain
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactory4.Native*,
                    IUnknown.Native*,
                    DxgiSwapChainDesc1*,
                    IdxgiOutput.Native*,
                    IdxgiSwapChain1.Native**,
                    HResult>)(lpVtbl[24])
            )(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                pDesc,
                pRestrictToOutput.LpVtbl,
                &ppSwapChain->LpVtbl
            );
        }

        [VtblIndex(24)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSwapChainForComposition(
            IUnknown pDevice,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiSwapChain1> ppSwapChain
        )
        {
            fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
            fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateSwapChainForComposition(
                    pDevice,
                    __dsl_pDesc,
                    pRestrictToOutput,
                    __dsl_ppSwapChain
                );
            }
        }

        /// <inheritdoc cref = "IdxgiFactory2.CreateSwapChainForCoreWindow"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult CreateSwapChainForCoreWindow(
            IUnknown pDevice,
            IUnknown pWindow,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
            IdxgiOutput pRestrictToOutput,
            IdxgiSwapChain1* ppSwapChain
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactory4.Native*,
                    IUnknown.Native*,
                    IUnknown.Native*,
                    DxgiSwapChainDesc1*,
                    IdxgiOutput.Native*,
                    IdxgiSwapChain1.Native**,
                    HResult>)(lpVtbl[16])
            )(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                pWindow.lpVtbl,
                pDesc,
                pRestrictToOutput.LpVtbl,
                &ppSwapChain->LpVtbl
            );
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSwapChainForCoreWindow(
            IUnknown pDevice,
            IUnknown pWindow,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiSwapChain1> ppSwapChain
        )
        {
            fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
            fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateSwapChainForCoreWindow(
                    pDevice,
                    pWindow,
                    __dsl_pDesc,
                    pRestrictToOutput,
                    __dsl_ppSwapChain
                );
            }
        }

        /// <inheritdoc cref = "IdxgiFactory2.CreateSwapChainForHwnd"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult CreateSwapChainForHwnd(
            IUnknown pDevice,
            HWND hWnd,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
            [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
                DxgiSwapChainFullscreenDesc* pFullscreenDesc,
            IdxgiOutput pRestrictToOutput,
            IdxgiSwapChain1* ppSwapChain
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactory4.Native*,
                    IUnknown.Native*,
                    HWND,
                    DxgiSwapChainDesc1*,
                    DxgiSwapChainFullscreenDesc*,
                    IdxgiOutput.Native*,
                    IdxgiSwapChain1.Native**,
                    HResult>)(lpVtbl[15])
            )(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                hWnd,
                pDesc,
                pFullscreenDesc,
                pRestrictToOutput.LpVtbl,
                &ppSwapChain->LpVtbl
            );
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSwapChainForHwnd(
            IUnknown pDevice,
            HWND hWnd,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
            [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
                Ref<DxgiSwapChainFullscreenDesc> pFullscreenDesc,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiSwapChain1> ppSwapChain
        )
        {
            fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
            fixed (DxgiSwapChainFullscreenDesc* __dsl_pFullscreenDesc = pFullscreenDesc)
            fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateSwapChainForHwnd(
                    pDevice,
                    hWnd,
                    __dsl_pDesc,
                    __dsl_pFullscreenDesc,
                    pRestrictToOutput,
                    __dsl_ppSwapChain
                );
            }
        }

        /// <include file='IDXGIFactory4.xml' path='doc/member[@name="IDXGIFactory4.EnumAdapterByLuid"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HResult EnumAdapterByLuid(
            LUID AdapterLuid,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvAdapter
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, LUID, Guid*, void**, HResult>)(
                    lpVtbl[26]
                )
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
        }

        [VtblIndex(26)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult EnumAdapterByLuid(
            LUID AdapterLuid,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvAdapter
        )
        {
            fixed (void** __dsl_ppvAdapter = ppvAdapter)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)EnumAdapterByLuid(AdapterLuid, __dsl_riid, __dsl_ppvAdapter);
            }
        }

        [VtblIndex(26)]
        [Transformed]
        public HResult EnumAdapterByLuid<TCom>(LUID AdapterLuid, out TCom ppvAdapter)
            where TCom : unmanaged, IComVtbl
        {
            ppvAdapter = default;
            return EnumAdapterByLuid(AdapterLuid, TCom.NativeGuid, ppvAdapter.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiFactory.EnumAdapters"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult EnumAdapters(uint Adapter, IdxgiAdapter* ppAdapter)
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, uint, IdxgiAdapter.Native**, HResult>)(
                    lpVtbl[7]
                )
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), Adapter, &ppAdapter->LpVtbl);
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

        /// <inheritdoc cref = "IdxgiFactory1.EnumAdapters1"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult EnumAdapters1(uint Adapter, IdxgiAdapter1* ppAdapter)
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, uint, IdxgiAdapter1.Native**, HResult>)(
                    lpVtbl[12]
                )
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), Adapter, &ppAdapter->LpVtbl);
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

        /// <include file='IDXGIFactory4.xml' path='doc/member[@name="IDXGIFactory4.EnumWarpAdapter"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HResult EnumWarpAdapter(
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvAdapter
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, Guid*, void**, HResult>)(lpVtbl[27])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
        }

        [VtblIndex(27)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult EnumWarpAdapter(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvAdapter
        )
        {
            fixed (void** __dsl_ppvAdapter = ppvAdapter)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)EnumWarpAdapter(__dsl_riid, __dsl_ppvAdapter);
            }
        }

        [VtblIndex(27)]
        [Transformed]
        public HResult EnumWarpAdapter<TCom>(out TCom ppvAdapter)
            where TCom : unmanaged, IComVtbl
        {
            ppvAdapter = default;
            return EnumWarpAdapter(TCom.NativeGuid, ppvAdapter.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiFactory3.GetCreationFlags"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public uint GetCreationFlags()
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, uint>)(lpVtbl[25]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiFactory4.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <inheritdoc cref = "IdxgiFactory2.GetSharedResourceAdapterLuid"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult GetSharedResourceAdapterLuid(Handle hResource, LUID* pLuid)
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, Handle, LUID*, HResult>)(lpVtbl[17])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), hResource, pLuid);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetSharedResourceAdapterLuid(Handle hResource, Ref<LUID> pLuid)
        {
            fixed (LUID* __dsl_pLuid = pLuid)
            {
                return (HResult)GetSharedResourceAdapterLuid(hResource, __dsl_pLuid);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory.GetWindowAssociation"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetWindowAssociation(HWND* pWindowHandle)
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, HWND*, HResult>)(lpVtbl[9]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IdxgiFactory1.IsCurrent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsCurrent()
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, MaybeBool<int>>)(lpVtbl[13]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiFactory2.IsWindowedStereoEnabled"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsWindowedStereoEnabled()
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, MaybeBool<int>>)(lpVtbl[14]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiFactory.MakeWindowAssociation"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult MakeWindowAssociation(HWND WindowHandle, uint Flags)
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, HWND, uint, HResult>)(lpVtbl[8]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiFactory4.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <inheritdoc cref = "IdxgiFactory2.RegisterOcclusionStatusEvent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HResult RegisterOcclusionStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, Handle, uint*, HResult>)(lpVtbl[22])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult RegisterOcclusionStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        )
        {
            fixed (uint* __dsl_pdwCookie = pdwCookie)
            {
                return (HResult)RegisterOcclusionStatusEvent(hEvent, __dsl_pdwCookie);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory2.RegisterOcclusionStatusWindow"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult RegisterOcclusionStatusWindow(
            HWND WindowHandle,
            uint wMsg,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, HWND, uint, uint*, HResult>)(lpVtbl[21])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult RegisterOcclusionStatusWindow(
            HWND WindowHandle,
            uint wMsg,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        )
        {
            fixed (uint* __dsl_pdwCookie = pdwCookie)
            {
                return (HResult)RegisterOcclusionStatusWindow(WindowHandle, wMsg, __dsl_pdwCookie);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory2.RegisterStereoStatusEvent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult RegisterStereoStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, Handle, uint*, HResult>)(lpVtbl[19])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult RegisterStereoStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        )
        {
            fixed (uint* __dsl_pdwCookie = pdwCookie)
            {
                return (HResult)RegisterStereoStatusEvent(hEvent, __dsl_pdwCookie);
            }
        }

        /// <inheritdoc cref = "IdxgiFactory2.RegisterStereoStatusWindow"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult RegisterStereoStatusWindow(
            HWND WindowHandle,
            uint wMsg,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        )
        {
            return (
                (delegate* unmanaged<IdxgiFactory4.Native*, HWND, uint, uint*, HResult>)(lpVtbl[18])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult RegisterStereoStatusWindow(
            HWND WindowHandle,
            uint wMsg,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        )
        {
            fixed (uint* __dsl_pdwCookie = pdwCookie)
            {
                return (HResult)RegisterStereoStatusWindow(WindowHandle, wMsg, __dsl_pdwCookie);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IdxgiFactory4.Native*, uint>)(lpVtbl[2]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this)
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
                (delegate* unmanaged<IdxgiFactory4.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiFactory4.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiFactory4.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <inheritdoc cref = "IdxgiFactory2.UnregisterOcclusionStatus"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* unmanaged<IdxgiFactory4.Native*, uint, void>)(lpVtbl[23]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
                dwCookie
            );
        }

        /// <inheritdoc cref = "IdxgiFactory2.UnregisterStereoStatus"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            ((delegate* unmanaged<IdxgiFactory4.Native*, uint, void>)(lpVtbl[20]))(
                (IdxgiFactory4.Native*)Unsafe.AsPointer(ref this),
                dwCookie
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiFactory4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiFactory4(Ptr3D vtbl) => LpVtbl = (IdxgiFactory4.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiFactory4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiFactory4(Ptr<IdxgiFactory4.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiFactory4.Native"/> to <see cref = "IdxgiFactory4"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory4.Native"/> instance to be converted </param>

    public static implicit operator IdxgiFactory4(IdxgiFactory4.Native* value) =>
        new IdxgiFactory4((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiFactory4"/> to <see cref = "IdxgiFactory4.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory4"/> instance to be converted </param>

    public static implicit operator IdxgiFactory4.Native*(IdxgiFactory4 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiFactory4"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiFactory4(Ptr3D value) => new IdxgiFactory4(value);

    /// <summary>casts <see cref = "IdxgiFactory4"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory4"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiFactory4 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiFactory4"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiFactory4(Ptr<IdxgiFactory4.Native> value) =>
        new IdxgiFactory4(value);

    /// <summary>casts <see cref = "IdxgiFactory4"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory4"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiFactory4.Native>(IdxgiFactory4 value) =>
        (Ptr<IdxgiFactory4.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiFactory4"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiFactory4(void*** value) =>
        new IdxgiFactory4((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiFactory4"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory4"/> instance to be converted </param>

    public static implicit operator void***(IdxgiFactory4 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiFactory4"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiFactory4(nuint value) =>
        new IdxgiFactory4((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiFactory4"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactory4"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiFactory4 value) => (nuint)value.LpVtbl;

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

    /// <inheritdoc cref = "IdxgiFactory2.CreateSwapChainForComposition"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HResult CreateSwapChainForComposition(
        IUnknown pDevice,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
        IdxgiOutput pRestrictToOutput,
        IdxgiSwapChain1* ppSwapChain
    ) => LpVtbl->CreateSwapChainForComposition(pDevice, pDesc, pRestrictToOutput, ppSwapChain);

    [VtblIndex(24)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSwapChainForComposition(
        IUnknown pDevice,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
        IdxgiOutput pRestrictToOutput,
        Ref<IdxgiSwapChain1> ppSwapChain
    )
    {
        fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
        fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateSwapChainForComposition(
                pDevice,
                __dsl_pDesc,
                pRestrictToOutput,
                __dsl_ppSwapChain
            );
        }
    }

    /// <inheritdoc cref = "IdxgiFactory2.CreateSwapChainForCoreWindow"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult CreateSwapChainForCoreWindow(
        IUnknown pDevice,
        IUnknown pWindow,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
        IdxgiOutput pRestrictToOutput,
        IdxgiSwapChain1* ppSwapChain
    ) =>
        LpVtbl->CreateSwapChainForCoreWindow(
            pDevice,
            pWindow,
            pDesc,
            pRestrictToOutput,
            ppSwapChain
        );

    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSwapChainForCoreWindow(
        IUnknown pDevice,
        IUnknown pWindow,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
        IdxgiOutput pRestrictToOutput,
        Ref<IdxgiSwapChain1> ppSwapChain
    )
    {
        fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
        fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateSwapChainForCoreWindow(
                pDevice,
                pWindow,
                __dsl_pDesc,
                pRestrictToOutput,
                __dsl_ppSwapChain
            );
        }
    }

    /// <inheritdoc cref = "IdxgiFactory2.CreateSwapChainForHwnd"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult CreateSwapChainForHwnd(
        IUnknown pDevice,
        HWND hWnd,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
        [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
            DxgiSwapChainFullscreenDesc* pFullscreenDesc,
        IdxgiOutput pRestrictToOutput,
        IdxgiSwapChain1* ppSwapChain
    ) =>
        LpVtbl->CreateSwapChainForHwnd(
            pDevice,
            hWnd,
            pDesc,
            pFullscreenDesc,
            pRestrictToOutput,
            ppSwapChain
        );

    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSwapChainForHwnd(
        IUnknown pDevice,
        HWND hWnd,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
        [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
            Ref<DxgiSwapChainFullscreenDesc> pFullscreenDesc,
        IdxgiOutput pRestrictToOutput,
        Ref<IdxgiSwapChain1> ppSwapChain
    )
    {
        fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
        fixed (DxgiSwapChainFullscreenDesc* __dsl_pFullscreenDesc = pFullscreenDesc)
        fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateSwapChainForHwnd(
                pDevice,
                hWnd,
                __dsl_pDesc,
                __dsl_pFullscreenDesc,
                pRestrictToOutput,
                __dsl_ppSwapChain
            );
        }
    }

    /// <include file='IDXGIFactory4.xml' path='doc/member[@name="IDXGIFactory4.EnumAdapterByLuid"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HResult EnumAdapterByLuid(
        LUID AdapterLuid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapter
    ) => LpVtbl->EnumAdapterByLuid(AdapterLuid, riid, ppvAdapter);

    [VtblIndex(26)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumAdapterByLuid(
        LUID AdapterLuid,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppvAdapter
    )
    {
        fixed (void** __dsl_ppvAdapter = ppvAdapter)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)EnumAdapterByLuid(AdapterLuid, __dsl_riid, __dsl_ppvAdapter);
        }
    }

    [VtblIndex(26)]
    [Transformed]
    public HResult EnumAdapterByLuid<TCom>(LUID AdapterLuid, out TCom ppvAdapter)
        where TCom : unmanaged, IComVtbl
    {
        ppvAdapter = default;
        return EnumAdapterByLuid(AdapterLuid, TCom.NativeGuid, ppvAdapter.GetAddressOf());
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

    /// <inheritdoc cref = "IdxgiFactory1.EnumAdapters1"/>

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

    /// <include file='IDXGIFactory4.xml' path='doc/member[@name="IDXGIFactory4.EnumWarpAdapter"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HResult EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter) =>
        LpVtbl->EnumWarpAdapter(riid, ppvAdapter);

    [VtblIndex(27)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumWarpAdapter([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvAdapter)
    {
        fixed (void** __dsl_ppvAdapter = ppvAdapter)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)EnumWarpAdapter(__dsl_riid, __dsl_ppvAdapter);
        }
    }

    [VtblIndex(27)]
    [Transformed]
    public HResult EnumWarpAdapter<TCom>(out TCom ppvAdapter)
        where TCom : unmanaged, IComVtbl
    {
        ppvAdapter = default;
        return EnumWarpAdapter(TCom.NativeGuid, ppvAdapter.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiFactory3.GetCreationFlags"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public uint GetCreationFlags() => LpVtbl->GetCreationFlags();

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

    /// <inheritdoc cref = "IdxgiFactory2.GetSharedResourceAdapterLuid"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult GetSharedResourceAdapterLuid(Handle hResource, LUID* pLuid) =>
        LpVtbl->GetSharedResourceAdapterLuid(hResource, pLuid);

    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSharedResourceAdapterLuid(Handle hResource, Ref<LUID> pLuid)
    {
        fixed (LUID* __dsl_pLuid = pLuid)
        {
            return (HResult)GetSharedResourceAdapterLuid(hResource, __dsl_pLuid);
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

    /// <inheritdoc cref = "IdxgiFactory1.IsCurrent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsCurrent() => LpVtbl->IsCurrent();

    /// <inheritdoc cref = "IdxgiFactory2.IsWindowedStereoEnabled"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsWindowedStereoEnabled() => LpVtbl->IsWindowedStereoEnabled();

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

    /// <inheritdoc cref = "IdxgiFactory2.RegisterOcclusionStatusEvent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HResult RegisterOcclusionStatusEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    ) => LpVtbl->RegisterOcclusionStatusEvent(hEvent, pdwCookie);

    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterOcclusionStatusEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
    )
    {
        fixed (uint* __dsl_pdwCookie = pdwCookie)
        {
            return (HResult)RegisterOcclusionStatusEvent(hEvent, __dsl_pdwCookie);
        }
    }

    /// <inheritdoc cref = "IdxgiFactory2.RegisterOcclusionStatusWindow"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HResult RegisterOcclusionStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    ) => LpVtbl->RegisterOcclusionStatusWindow(WindowHandle, wMsg, pdwCookie);

    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterOcclusionStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
    )
    {
        fixed (uint* __dsl_pdwCookie = pdwCookie)
        {
            return (HResult)RegisterOcclusionStatusWindow(WindowHandle, wMsg, __dsl_pdwCookie);
        }
    }

    /// <inheritdoc cref = "IdxgiFactory2.RegisterStereoStatusEvent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult RegisterStereoStatusEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    ) => LpVtbl->RegisterStereoStatusEvent(hEvent, pdwCookie);

    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterStereoStatusEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
    )
    {
        fixed (uint* __dsl_pdwCookie = pdwCookie)
        {
            return (HResult)RegisterStereoStatusEvent(hEvent, __dsl_pdwCookie);
        }
    }

    /// <inheritdoc cref = "IdxgiFactory2.RegisterStereoStatusWindow"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HResult RegisterStereoStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    ) => LpVtbl->RegisterStereoStatusWindow(WindowHandle, wMsg, pdwCookie);

    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterStereoStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
    )
    {
        fixed (uint* __dsl_pdwCookie = pdwCookie)
        {
            return (HResult)RegisterStereoStatusWindow(WindowHandle, wMsg, __dsl_pdwCookie);
        }
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

    /// <inheritdoc cref = "IdxgiFactory2.UnregisterOcclusionStatus"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie) =>
        LpVtbl->UnregisterOcclusionStatus(dwCookie);

    /// <inheritdoc cref = "IdxgiFactory2.UnregisterStereoStatus"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie) =>
        LpVtbl->UnregisterStereoStatus(dwCookie);
}
