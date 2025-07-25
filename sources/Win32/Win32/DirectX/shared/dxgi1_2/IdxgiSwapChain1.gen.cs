// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1"]/*'/>
[Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
[NativeTypeName("struct IDXGISwapChain1 : IDXGISwapChain")]
[NativeInheritance("IDXGISwapChain")]
public unsafe partial struct IdxgiSwapChain1 : IdxgiSwapChain1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChain1));

    public interface Interface : IdxgiSwapChain.Interface
    {
        [VtblIndex(26)]
        HResult GetBackgroundColor(DxgiRgba* pColor);

        [VtblIndex(26)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetBackgroundColor(Ref<DxgiRgba> pColor);

        [VtblIndex(21)]
        HResult GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk);

        [VtblIndex(21)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetCoreWindow([NativeTypeName("const IID &")] Ref<Guid> refiid, Ref2D ppUnk);

        [VtblIndex(18)]
        HResult GetDesc1(DxgiSwapChainDesc1* pDesc);

        [VtblIndex(18)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDesc1(Ref<DxgiSwapChainDesc1> pDesc);

        [VtblIndex(19)]
        HResult GetFullscreenDesc(DxgiSwapChainFullscreenDesc* pDesc);

        [VtblIndex(19)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFullscreenDesc(Ref<DxgiSwapChainFullscreenDesc> pDesc);

        [VtblIndex(20)]
        HResult GetHwnd(HWND* pHwnd);

        [VtblIndex(20)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetHwnd(Ref<HWND> pHwnd);

        [VtblIndex(24)]
        HResult GetRestrictToOutput(IdxgiOutput* ppRestrictToOutput);

        [VtblIndex(24)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetRestrictToOutput(Ref<IdxgiOutput> ppRestrictToOutput);

        [VtblIndex(28)]
        HResult GetRotation(DxgiModeRotation* pRotation);

        [VtblIndex(28)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetRotation(Ref<DxgiModeRotation> pRotation);

        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        MaybeBool<int> IsTemporaryMonoSupported();

        [VtblIndex(22)]
        HResult Present1(
            uint SyncInterval,
            uint PresentFlags,
            [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
                DxgiPresentParameters* pPresentParameters
        );

        [VtblIndex(22)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult Present1(
            uint SyncInterval,
            uint PresentFlags,
            [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
                Ref<DxgiPresentParameters> pPresentParameters
        );

        [VtblIndex(25)]
        HResult SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DxgiRgba* pColor);

        [VtblIndex(25)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] Ref<DxgiRgba> pColor);

        [VtblIndex(27)]
        HResult SetRotation(DxgiModeRotation Rotation);
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1"]/*'/>

    [Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA")]
    [NativeTypeName("struct IDXGISwapChain1 : IDXGISwapChain")]
    [NativeInheritance("IDXGISwapChain")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChain1));
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

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetDevice;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, HResult> Present;

            [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, Guid*, void**, HResult> GetBuffer;

            [NativeTypeName("HRESULT (BOOL, IDXGIOutput *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                MaybeBool<int>,
                IdxgiOutput.Native*,
                HResult> SetFullscreenState;

            [NativeTypeName("HRESULT (BOOL *, IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                MaybeBool<int>*,
                IdxgiOutput.Native**,
                HResult> GetFullscreenState;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiSwapChainDesc*, HResult> GetDesc;

            [NativeTypeName(
                "HRESULT (UINT, UINT, UINT, DXGI_FORMAT, UINT) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                uint,
                uint,
                DxgiFormat,
                uint,
                HResult> ResizeBuffers;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiModeDesc*, HResult> ResizeTarget;

            [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IdxgiOutput.Native**, HResult> GetContainingOutput;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiFrameStatistics*, HResult> GetFrameStatistics;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetLastPresentCount;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_DESC1 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiSwapChainDesc1*, HResult> GetDesc1;

            [NativeTypeName("HRESULT (DXGI_SWAP_CHAIN_FULLSCREEN_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                DxgiSwapChainFullscreenDesc*,
                HResult> GetFullscreenDesc;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HWND*, HResult> GetHwnd;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetCoreWindow;

            [NativeTypeName(
                "HRESULT (UINT, UINT, const DXGI_PRESENT_PARAMETERS *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                uint,
                DxgiPresentParameters*,
                HResult> Present1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> IsTemporaryMonoSupported;

            [NativeTypeName("HRESULT (IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IdxgiOutput.Native**, HResult> GetRestrictToOutput;

            [NativeTypeName("HRESULT (const DXGI_RGBA *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiRgba*, HResult> SetBackgroundColor;

            [NativeTypeName("HRESULT (DXGI_RGBA *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiRgba*, HResult> GetBackgroundColor;

            [NativeTypeName("HRESULT (DXGI_MODE_ROTATION) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiModeRotation, HResult> SetRotation;

            [NativeTypeName("HRESULT (DXGI_MODE_ROTATION *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiModeRotation*, HResult> GetRotation;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, uint>)(lpVtbl[1]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetBackgroundColor"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HResult GetBackgroundColor(DxgiRgba* pColor)
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiRgba*, HResult>)(lpVtbl[26]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                pColor
            );
        }

        [VtblIndex(26)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetBackgroundColor(Ref<DxgiRgba> pColor)
        {
            fixed (DxgiRgba* __dsl_pColor = pColor)
            {
                return (HResult)GetBackgroundColor(__dsl_pColor);
            }
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetBuffer"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetBuffer(
            uint Buffer,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppSurface
        )
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, uint, Guid*, void**, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetBuffer(
            uint Buffer,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppSurface
        )
        {
            fixed (void** __dsl_ppSurface = ppSurface)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetBuffer(Buffer, __dsl_riid, __dsl_ppSurface);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        public HResult GetBuffer<TCom>(uint Buffer, out TCom ppSurface)
            where TCom : unmanaged, IComVtbl
        {
            ppSurface = default;
            return GetBuffer(Buffer, TCom.NativeGuid, ppSurface.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetContainingOutput"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult GetContainingOutput(IdxgiOutput* ppOutput)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[15]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), &ppOutput->LpVtbl);
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetContainingOutput(Ref<IdxgiOutput> ppOutput)
        {
            fixed (IdxgiOutput* __dsl_ppOutput = ppOutput)
            {
                return (HResult)GetContainingOutput(__dsl_ppOutput);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetCoreWindow"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, void**, HResult>)(lpVtbl[21])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), refiid, ppUnk);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetCoreWindow([NativeTypeName("const IID &")] Ref<Guid> refiid, Ref2D ppUnk)
        {
            fixed (void** __dsl_ppUnk = ppUnk)
            fixed (Guid* __dsl_refiid = refiid)
            {
                return (HResult)GetCoreWindow(__dsl_refiid, __dsl_ppUnk);
            }
        }

        [VtblIndex(21)]
        [Transformed]
        public HResult GetCoreWindow<TCom>(out TCom ppUnk)
            where TCom : unmanaged, IComVtbl
        {
            ppUnk = default;
            return GetCoreWindow(TCom.NativeGuid, ppUnk.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetDesc"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult GetDesc(DxgiSwapChainDesc* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiSwapChainDesc*, HResult>)(
                    lpVtbl[12]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc(Ref<DxgiSwapChainDesc> pDesc)
        {
            fixed (DxgiSwapChainDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetDesc1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult GetDesc1(DxgiSwapChainDesc1* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiSwapChainDesc1*, HResult>)(
                    lpVtbl[18]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc1(Ref<DxgiSwapChainDesc1> pDesc)
        {
            fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc1(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiDeviceSubObject.GetDevice"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, void**, HResult>)(lpVtbl[7])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppDevice)
        {
            fixed (void** __dsl_ppDevice = ppDevice)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetDevice(__dsl_riid, __dsl_ppDevice);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        public HResult GetDevice<TCom>(out TCom ppDevice)
            where TCom : unmanaged, IComVtbl
        {
            ppDevice = default;
            return GetDevice(TCom.NativeGuid, ppDevice.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetFrameStatistics"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult GetFrameStatistics(DxgiFrameStatistics* pStats)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiFrameStatistics*, HResult>)(
                    lpVtbl[16]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pStats);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFrameStatistics(Ref<DxgiFrameStatistics> pStats)
        {
            fixed (DxgiFrameStatistics* __dsl_pStats = pStats)
            {
                return (HResult)GetFrameStatistics(__dsl_pStats);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetFullscreenDesc"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult GetFullscreenDesc(DxgiSwapChainFullscreenDesc* pDesc)
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain1.Native*,
                    DxgiSwapChainFullscreenDesc*,
                    HResult>)(lpVtbl[19])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFullscreenDesc(Ref<DxgiSwapChainFullscreenDesc> pDesc)
        {
            fixed (DxgiSwapChainFullscreenDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetFullscreenDesc(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetFullscreenState"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetFullscreenState(
            [NativeTypeName("BOOL *")] MaybeBool<int>* pFullscreen,
            IdxgiOutput* ppTarget
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain1.Native*,
                    MaybeBool<int>*,
                    IdxgiOutput.Native**,
                    HResult>)(lpVtbl[11])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pFullscreen, &ppTarget->LpVtbl);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFullscreenState(
            [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pFullscreen,
            Ref<IdxgiOutput> ppTarget
        )
        {
            fixed (IdxgiOutput* __dsl_ppTarget = ppTarget)
            fixed (MaybeBool<int>* __dsl_pFullscreen = pFullscreen)
            {
                return (HResult)GetFullscreenState(__dsl_pFullscreen, __dsl_ppTarget);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetHwnd"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult GetHwnd(HWND* pHwnd)
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, HWND*, HResult>)(lpVtbl[20]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                pHwnd
            );
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetHwnd(Ref<HWND> pHwnd)
        {
            fixed (HWND* __dsl_pHwnd = pHwnd)
            {
                return (HResult)GetHwnd(__dsl_pHwnd);
            }
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetLastPresentCount"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult GetLastPresentCount(uint* pLastPresentCount)
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, uint*, HResult>)(lpVtbl[17]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                pLastPresentCount
            );
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetLastPresentCount(Ref<uint> pLastPresentCount)
        {
            fixed (uint* __dsl_pLastPresentCount = pLastPresentCount)
            {
                return (HResult)GetLastPresentCount(__dsl_pLastPresentCount);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetRestrictToOutput"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HResult GetRestrictToOutput(IdxgiOutput* ppRestrictToOutput)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[24]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), &ppRestrictToOutput->LpVtbl);
        }

        [VtblIndex(24)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetRestrictToOutput(Ref<IdxgiOutput> ppRestrictToOutput)
        {
            fixed (IdxgiOutput* __dsl_ppRestrictToOutput = ppRestrictToOutput)
            {
                return (HResult)GetRestrictToOutput(__dsl_ppRestrictToOutput);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetRotation"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HResult GetRotation(DxgiModeRotation* pRotation)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiModeRotation*, HResult>)(
                    lpVtbl[28]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pRotation);
        }

        [VtblIndex(28)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetRotation(Ref<DxgiModeRotation> pRotation)
        {
            fixed (DxgiModeRotation* __dsl_pRotation = pRotation)
            {
                return (HResult)GetRotation(__dsl_pRotation);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.IsTemporaryMonoSupported"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsTemporaryMonoSupported()
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, MaybeBool<int>>)(lpVtbl[23]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain.Present"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult Present(uint SyncInterval, uint Flags)
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, uint, uint, HResult>)(lpVtbl[8]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                SyncInterval,
                Flags
            );
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.Present1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HResult Present1(
            uint SyncInterval,
            uint PresentFlags,
            [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
                DxgiPresentParameters* pPresentParameters
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain1.Native*,
                    uint,
                    uint,
                    DxgiPresentParameters*,
                    HResult>)(lpVtbl[22])
            )(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                SyncInterval,
                PresentFlags,
                pPresentParameters
            );
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult Present1(
            uint SyncInterval,
            uint PresentFlags,
            [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
                Ref<DxgiPresentParameters> pPresentParameters
        )
        {
            fixed (DxgiPresentParameters* __dsl_pPresentParameters = pPresentParameters)
            {
                return (HResult)Present1(SyncInterval, PresentFlags, __dsl_pPresentParameters);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, uint>)(lpVtbl[2]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain.ResizeBuffers"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult ResizeBuffers(
            uint BufferCount,
            uint Width,
            uint Height,
            DxgiFormat NewFormat,
            uint SwapChainFlags
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain1.Native*,
                    uint,
                    uint,
                    uint,
                    DxgiFormat,
                    uint,
                    HResult>)(lpVtbl[13])
            )(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                BufferCount,
                Width,
                Height,
                NewFormat,
                SwapChainFlags
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain.ResizeTarget"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult ResizeTarget(
            [NativeTypeName("const DXGI_MODE_DESC *")] DxgiModeDesc* pNewTargetParameters
        )
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiModeDesc*, HResult>)(lpVtbl[14])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult ResizeTarget(
            [NativeTypeName("const DXGI_MODE_DESC *")] Ref<DxgiModeDesc> pNewTargetParameters
        )
        {
            fixed (DxgiModeDesc* __dsl_pNewTargetParameters = pNewTargetParameters)
            {
                return (HResult)ResizeTarget(__dsl_pNewTargetParameters);
            }
        }

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.SetBackgroundColor"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HResult SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DxgiRgba* pColor)
        {
            return ((delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiRgba*, HResult>)(lpVtbl[25]))(
                (IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this),
                pColor
            );
        }

        [VtblIndex(25)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetBackgroundColor(
            [NativeTypeName("const DXGI_RGBA *")] Ref<DxgiRgba> pColor
        )
        {
            fixed (DxgiRgba* __dsl_pColor = pColor)
            {
                return (HResult)SetBackgroundColor(__dsl_pColor);
            }
        }

        /// <inheritdoc cref = "IdxgiSwapChain.SetFullscreenState"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult SetFullscreenState(
            [NativeTypeName("BOOL")] MaybeBool<int> Fullscreen,
            IdxgiOutput pTarget
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain1.Native*,
                    MaybeBool<int>,
                    IdxgiOutput.Native*,
                    HResult>)(lpVtbl[10])
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), Fullscreen, pTarget.LpVtbl);
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
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, uint, void*, HResult>)(
                    lpVtbl[3]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiSwapChain1.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.SetRotation"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HResult SetRotation(DxgiModeRotation Rotation)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain1.Native*, DxgiModeRotation, HResult>)(
                    lpVtbl[27]
                )
            )((IdxgiSwapChain1.Native*)Unsafe.AsPointer(ref this), Rotation);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChain1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChain1(Ptr3D vtbl) => LpVtbl = (IdxgiSwapChain1.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChain1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChain1(Ptr<IdxgiSwapChain1.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiSwapChain1.Native"/> to <see cref = "IdxgiSwapChain1"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain1.Native"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChain1(IdxgiSwapChain1.Native* value) =>
        new IdxgiSwapChain1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChain1"/> to <see cref = "IdxgiSwapChain1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain1"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChain1.Native*(IdxgiSwapChain1 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiSwapChain1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain1(Ptr3D value) => new IdxgiSwapChain1(value);

    /// <summary>casts <see cref = "IdxgiSwapChain1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain1"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiSwapChain1 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiSwapChain1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain1(Ptr<IdxgiSwapChain1.Native> value) =>
        new IdxgiSwapChain1(value);

    /// <summary>casts <see cref = "IdxgiSwapChain1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain1"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiSwapChain1.Native>(IdxgiSwapChain1 value) =>
        (Ptr<IdxgiSwapChain1.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiSwapChain1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiSwapChain1(void*** value) =>
        new IdxgiSwapChain1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChain1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain1"/> instance to be converted </param>

    public static implicit operator void***(IdxgiSwapChain1 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiSwapChain1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain1(nuint value) =>
        new IdxgiSwapChain1((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiSwapChain1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain1"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiSwapChain1 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetBackgroundColor"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HResult GetBackgroundColor(DxgiRgba* pColor) => LpVtbl->GetBackgroundColor(pColor);

    [VtblIndex(26)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetBackgroundColor(Ref<DxgiRgba> pColor)
    {
        fixed (DxgiRgba* __dsl_pColor = pColor)
        {
            return (HResult)GetBackgroundColor(__dsl_pColor);
        }
    }

    /// <inheritdoc cref = "IdxgiSwapChain.GetBuffer"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetBuffer(
        uint Buffer,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppSurface
    ) => LpVtbl->GetBuffer(Buffer, riid, ppSurface);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetBuffer(
        uint Buffer,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppSurface
    )
    {
        fixed (void** __dsl_ppSurface = ppSurface)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetBuffer(Buffer, __dsl_riid, __dsl_ppSurface);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    public HResult GetBuffer<TCom>(uint Buffer, out TCom ppSurface)
        where TCom : unmanaged, IComVtbl
    {
        ppSurface = default;
        return GetBuffer(Buffer, TCom.NativeGuid, ppSurface.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiSwapChain.GetContainingOutput"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult GetContainingOutput(IdxgiOutput* ppOutput) =>
        LpVtbl->GetContainingOutput(ppOutput);

    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetContainingOutput(Ref<IdxgiOutput> ppOutput)
    {
        fixed (IdxgiOutput* __dsl_ppOutput = ppOutput)
        {
            return (HResult)GetContainingOutput(__dsl_ppOutput);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetCoreWindow"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HResult GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk) =>
        LpVtbl->GetCoreWindow(refiid, ppUnk);

    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetCoreWindow([NativeTypeName("const IID &")] Ref<Guid> refiid, Ref2D ppUnk)
    {
        fixed (void** __dsl_ppUnk = ppUnk)
        fixed (Guid* __dsl_refiid = refiid)
        {
            return (HResult)GetCoreWindow(__dsl_refiid, __dsl_ppUnk);
        }
    }

    [VtblIndex(21)]
    [Transformed]
    public HResult GetCoreWindow<TCom>(out TCom ppUnk)
        where TCom : unmanaged, IComVtbl
    {
        ppUnk = default;
        return GetCoreWindow(TCom.NativeGuid, ppUnk.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiSwapChain.GetDesc"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult GetDesc(DxgiSwapChainDesc* pDesc) => LpVtbl->GetDesc(pDesc);

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<DxgiSwapChainDesc> pDesc)
    {
        fixed (DxgiSwapChainDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetDesc1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HResult GetDesc1(DxgiSwapChainDesc1* pDesc) => LpVtbl->GetDesc1(pDesc);

    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc1(Ref<DxgiSwapChainDesc1> pDesc)
    {
        fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc1(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiDeviceSubObject.GetDevice"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice) =>
        LpVtbl->GetDevice(riid, ppDevice);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppDevice)
    {
        fixed (void** __dsl_ppDevice = ppDevice)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetDevice(__dsl_riid, __dsl_ppDevice);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    public HResult GetDevice<TCom>(out TCom ppDevice)
        where TCom : unmanaged, IComVtbl
    {
        ppDevice = default;
        return GetDevice(TCom.NativeGuid, ppDevice.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiSwapChain.GetFrameStatistics"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult GetFrameStatistics(DxgiFrameStatistics* pStats) =>
        LpVtbl->GetFrameStatistics(pStats);

    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFrameStatistics(Ref<DxgiFrameStatistics> pStats)
    {
        fixed (DxgiFrameStatistics* __dsl_pStats = pStats)
        {
            return (HResult)GetFrameStatistics(__dsl_pStats);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetFullscreenDesc"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult GetFullscreenDesc(DxgiSwapChainFullscreenDesc* pDesc) =>
        LpVtbl->GetFullscreenDesc(pDesc);

    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFullscreenDesc(Ref<DxgiSwapChainFullscreenDesc> pDesc)
    {
        fixed (DxgiSwapChainFullscreenDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetFullscreenDesc(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiSwapChain.GetFullscreenState"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetFullscreenState(
        [NativeTypeName("BOOL *")] MaybeBool<int>* pFullscreen,
        IdxgiOutput* ppTarget
    ) => LpVtbl->GetFullscreenState(pFullscreen, ppTarget);

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFullscreenState(
        [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pFullscreen,
        Ref<IdxgiOutput> ppTarget
    )
    {
        fixed (IdxgiOutput* __dsl_ppTarget = ppTarget)
        fixed (MaybeBool<int>* __dsl_pFullscreen = pFullscreen)
        {
            return (HResult)GetFullscreenState(__dsl_pFullscreen, __dsl_ppTarget);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetHwnd"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HResult GetHwnd(HWND* pHwnd) => LpVtbl->GetHwnd(pHwnd);

    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetHwnd(Ref<HWND> pHwnd)
    {
        fixed (HWND* __dsl_pHwnd = pHwnd)
        {
            return (HResult)GetHwnd(__dsl_pHwnd);
        }
    }

    /// <inheritdoc cref = "IdxgiSwapChain.GetLastPresentCount"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult GetLastPresentCount(uint* pLastPresentCount) =>
        LpVtbl->GetLastPresentCount(pLastPresentCount);

    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetLastPresentCount(Ref<uint> pLastPresentCount)
    {
        fixed (uint* __dsl_pLastPresentCount = pLastPresentCount)
        {
            return (HResult)GetLastPresentCount(__dsl_pLastPresentCount);
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

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetRestrictToOutput"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HResult GetRestrictToOutput(IdxgiOutput* ppRestrictToOutput) =>
        LpVtbl->GetRestrictToOutput(ppRestrictToOutput);

    [VtblIndex(24)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRestrictToOutput(Ref<IdxgiOutput> ppRestrictToOutput)
    {
        fixed (IdxgiOutput* __dsl_ppRestrictToOutput = ppRestrictToOutput)
        {
            return (HResult)GetRestrictToOutput(__dsl_ppRestrictToOutput);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.GetRotation"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HResult GetRotation(DxgiModeRotation* pRotation) => LpVtbl->GetRotation(pRotation);

    [VtblIndex(28)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRotation(Ref<DxgiModeRotation> pRotation)
    {
        fixed (DxgiModeRotation* __dsl_pRotation = pRotation)
        {
            return (HResult)GetRotation(__dsl_pRotation);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.IsTemporaryMonoSupported"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsTemporaryMonoSupported() => LpVtbl->IsTemporaryMonoSupported();

    /// <inheritdoc cref = "IdxgiSwapChain.Present"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult Present(uint SyncInterval, uint Flags) => LpVtbl->Present(SyncInterval, Flags);

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.Present1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HResult Present1(
        uint SyncInterval,
        uint PresentFlags,
        [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
            DxgiPresentParameters* pPresentParameters
    ) => LpVtbl->Present1(SyncInterval, PresentFlags, pPresentParameters);

    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Present1(
        uint SyncInterval,
        uint PresentFlags,
        [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")]
            Ref<DxgiPresentParameters> pPresentParameters
    )
    {
        fixed (DxgiPresentParameters* __dsl_pPresentParameters = pPresentParameters)
        {
            return (HResult)Present1(SyncInterval, PresentFlags, __dsl_pPresentParameters);
        }
    }

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

    /// <inheritdoc cref = "IdxgiSwapChain.ResizeBuffers"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult ResizeBuffers(
        uint BufferCount,
        uint Width,
        uint Height,
        DxgiFormat NewFormat,
        uint SwapChainFlags
    ) => LpVtbl->ResizeBuffers(BufferCount, Width, Height, NewFormat, SwapChainFlags);

    /// <inheritdoc cref = "IdxgiSwapChain.ResizeTarget"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult ResizeTarget(
        [NativeTypeName("const DXGI_MODE_DESC *")] DxgiModeDesc* pNewTargetParameters
    ) => LpVtbl->ResizeTarget(pNewTargetParameters);

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ResizeTarget(
        [NativeTypeName("const DXGI_MODE_DESC *")] Ref<DxgiModeDesc> pNewTargetParameters
    )
    {
        fixed (DxgiModeDesc* __dsl_pNewTargetParameters = pNewTargetParameters)
        {
            return (HResult)ResizeTarget(__dsl_pNewTargetParameters);
        }
    }

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.SetBackgroundColor"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HResult SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DxgiRgba* pColor) =>
        LpVtbl->SetBackgroundColor(pColor);

    [VtblIndex(25)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] Ref<DxgiRgba> pColor)
    {
        fixed (DxgiRgba* __dsl_pColor = pColor)
        {
            return (HResult)SetBackgroundColor(__dsl_pColor);
        }
    }

    /// <inheritdoc cref = "IdxgiSwapChain.SetFullscreenState"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult SetFullscreenState(
        [NativeTypeName("BOOL")] MaybeBool<int> Fullscreen,
        IdxgiOutput pTarget
    ) => LpVtbl->SetFullscreenState(Fullscreen, pTarget);

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

    /// <include file='IDXGISwapChain1.xml' path='doc/member[@name="IDXGISwapChain1.SetRotation"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HResult SetRotation(DxgiModeRotation Rotation) => LpVtbl->SetRotation(Rotation);
}
