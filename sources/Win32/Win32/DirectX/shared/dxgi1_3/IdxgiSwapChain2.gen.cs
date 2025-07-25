// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2"]/*'/>
[Guid("A8BE2AC4-199F-4946-B331-79599FB98DE7")]
[NativeTypeName("struct IDXGISwapChain2 : IDXGISwapChain1")]
[NativeInheritance("IDXGISwapChain1")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IdxgiSwapChain2 : IdxgiSwapChain2.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChain2));

    public interface Interface : IdxgiSwapChain1.Interface
    {
        [VtblIndex(33)]
        Handle GetFrameLatencyWaitableObject();

        [VtblIndex(35)]
        HResult GetMatrixTransform(DxgiMatrix3X2F* pMatrix);

        [VtblIndex(35)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetMatrixTransform(Ref<DxgiMatrix3X2F> pMatrix);

        [VtblIndex(32)]
        HResult GetMaximumFrameLatency(uint* pMaxLatency);

        [VtblIndex(32)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency);

        [VtblIndex(30)]
        HResult GetSourceSize(uint* pWidth, uint* pHeight);

        [VtblIndex(30)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetSourceSize(Ref<uint> pWidth, Ref<uint> pHeight);

        [VtblIndex(34)]
        HResult SetMatrixTransform(
            [NativeTypeName("const DXGI_MATRIX_3X2_F *")] DxgiMatrix3X2F* pMatrix
        );

        [VtblIndex(34)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult SetMatrixTransform(
            [NativeTypeName("const DXGI_MATRIX_3X2_F *")] Ref<DxgiMatrix3X2F> pMatrix
        );

        [VtblIndex(31)]
        HResult SetMaximumFrameLatency(uint MaxLatency);

        [VtblIndex(29)]
        HResult SetSourceSize(uint Width, uint Height);
    }

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2"]/*'/>

    [Guid("A8BE2AC4-199F-4946-B331-79599FB98DE7")]
    [NativeTypeName("struct IDXGISwapChain2 : IDXGISwapChain1")]
    [NativeInheritance("IDXGISwapChain1")]
    [SupportedOSPlatform("windows6.3")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChain2));
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

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, HResult> SetSourceSize;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, uint*, HResult> GetSourceSize;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> SetMaximumFrameLatency;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetMaximumFrameLatency;

            [NativeTypeName("HANDLE () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Handle> GetFrameLatencyWaitableObject;

            [NativeTypeName("HRESULT (const DXGI_MATRIX_3X2_F *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiMatrix3X2F*, HResult> SetMatrixTransform;

            [NativeTypeName("HRESULT (DXGI_MATRIX_3X2_F *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiMatrix3X2F*, HResult> GetMatrixTransform;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, uint>)(lpVtbl[1]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain1.GetBackgroundColor"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HResult GetBackgroundColor(DxgiRgba* pColor)
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiRgba*, HResult>)(lpVtbl[26]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, uint, Guid*, void**, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[15]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), &ppOutput->LpVtbl);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.GetCoreWindow"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, void**, HResult>)(lpVtbl[21])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), refiid, ppUnk);
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiSwapChainDesc*, HResult>)(
                    lpVtbl[12]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pDesc);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.GetDesc1"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult GetDesc1(DxgiSwapChainDesc1* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiSwapChainDesc1*, HResult>)(
                    lpVtbl[18]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pDesc);
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, void**, HResult>)(lpVtbl[7])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), riid, ppDevice);
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

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetFrameLatencyWaitableObject"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public Handle GetFrameLatencyWaitableObject()
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, Handle>)(lpVtbl[33]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain.GetFrameStatistics"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult GetFrameStatistics(DxgiFrameStatistics* pStats)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiFrameStatistics*, HResult>)(
                    lpVtbl[16]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pStats);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.GetFullscreenDesc"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult GetFullscreenDesc(DxgiSwapChainFullscreenDesc* pDesc)
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain2.Native*,
                    DxgiSwapChainFullscreenDesc*,
                    HResult>)(lpVtbl[19])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pDesc);
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
                    IdxgiSwapChain2.Native*,
                    MaybeBool<int>*,
                    IdxgiOutput.Native**,
                    HResult>)(lpVtbl[11])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pFullscreen, &ppTarget->LpVtbl);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.GetHwnd"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult GetHwnd(HWND* pHwnd)
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, HWND*, HResult>)(lpVtbl[20]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
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
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, uint*, HResult>)(lpVtbl[17]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
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

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetMatrixTransform"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HResult GetMatrixTransform(DxgiMatrix3X2F* pMatrix)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiMatrix3X2F*, HResult>)(lpVtbl[35])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [VtblIndex(35)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetMatrixTransform(Ref<DxgiMatrix3X2F> pMatrix)
        {
            fixed (DxgiMatrix3X2F* __dsl_pMatrix = pMatrix)
            {
                return (HResult)GetMatrixTransform(__dsl_pMatrix);
            }
        }

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetMaximumFrameLatency"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HResult GetMaximumFrameLatency(uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, uint*, HResult>)(lpVtbl[32]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
                pMaxLatency
            );
        }

        [VtblIndex(32)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency)
        {
            fixed (uint* __dsl_pMaxLatency = pMaxLatency)
            {
                return (HResult)GetMaximumFrameLatency(__dsl_pMaxLatency);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.GetRestrictToOutput"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HResult GetRestrictToOutput(IdxgiOutput* ppRestrictToOutput)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[24]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), &ppRestrictToOutput->LpVtbl);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.GetRotation"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HResult GetRotation(DxgiModeRotation* pRotation)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiModeRotation*, HResult>)(
                    lpVtbl[28]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pRotation);
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

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetSourceSize"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HResult GetSourceSize(uint* pWidth, uint* pHeight)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, uint*, uint*, HResult>)(lpVtbl[30])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [VtblIndex(30)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetSourceSize(Ref<uint> pWidth, Ref<uint> pHeight)
        {
            fixed (uint* __dsl_pHeight = pHeight)
            fixed (uint* __dsl_pWidth = pWidth)
            {
                return (HResult)GetSourceSize(__dsl_pWidth, __dsl_pHeight);
            }
        }

        /// <inheritdoc cref = "IdxgiSwapChain1.IsTemporaryMonoSupported"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> IsTemporaryMonoSupported()
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, MaybeBool<int>>)(lpVtbl[23]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain.Present"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult Present(uint SyncInterval, uint Flags)
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, uint, uint, HResult>)(lpVtbl[8]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
                SyncInterval,
                Flags
            );
        }

        /// <inheritdoc cref = "IdxgiSwapChain1.Present1"/>

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
                    IdxgiSwapChain2.Native*,
                    uint,
                    uint,
                    DxgiPresentParameters*,
                    HResult>)(lpVtbl[22])
            )(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, uint>)(lpVtbl[2]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this)
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
                    IdxgiSwapChain2.Native*,
                    uint,
                    uint,
                    uint,
                    DxgiFormat,
                    uint,
                    HResult>)(lpVtbl[13])
            )(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiModeDesc*, HResult>)(lpVtbl[14])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pNewTargetParameters);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.SetBackgroundColor"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HResult SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DxgiRgba* pColor)
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiRgba*, HResult>)(lpVtbl[25]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
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
                    IdxgiSwapChain2.Native*,
                    MaybeBool<int>,
                    IdxgiOutput.Native*,
                    HResult>)(lpVtbl[10])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Fullscreen, pTarget.LpVtbl);
        }

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.SetMatrixTransform"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HResult SetMatrixTransform(
            [NativeTypeName("const DXGI_MATRIX_3X2_F *")] DxgiMatrix3X2F* pMatrix
        )
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiMatrix3X2F*, HResult>)(lpVtbl[34])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [VtblIndex(34)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetMatrixTransform(
            [NativeTypeName("const DXGI_MATRIX_3X2_F *")] Ref<DxgiMatrix3X2F> pMatrix
        )
        {
            fixed (DxgiMatrix3X2F* __dsl_pMatrix = pMatrix)
            {
                return (HResult)SetMatrixTransform(__dsl_pMatrix);
            }
        }

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.SetMaximumFrameLatency"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HResult SetMaximumFrameLatency(uint MaxLatency)
        {
            return ((delegate* unmanaged<IdxgiSwapChain2.Native*, uint, HResult>)(lpVtbl[31]))(
                (IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this),
                MaxLatency
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, uint, void*, HResult>)(
                    lpVtbl[3]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiSwapChain2.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <inheritdoc cref = "IdxgiSwapChain1.SetRotation"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HResult SetRotation(DxgiModeRotation Rotation)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, DxgiModeRotation, HResult>)(
                    lpVtbl[27]
                )
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Rotation);
        }

        /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.SetSourceSize"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HResult SetSourceSize(uint Width, uint Height)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain2.Native*, uint, uint, HResult>)(lpVtbl[29])
            )((IdxgiSwapChain2.Native*)Unsafe.AsPointer(ref this), Width, Height);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChain2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChain2(Ptr3D vtbl) => LpVtbl = (IdxgiSwapChain2.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChain2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChain2(Ptr<IdxgiSwapChain2.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiSwapChain2.Native"/> to <see cref = "IdxgiSwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain2.Native"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChain2(IdxgiSwapChain2.Native* value) =>
        new IdxgiSwapChain2((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChain2"/> to <see cref = "IdxgiSwapChain2.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain2"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChain2.Native*(IdxgiSwapChain2 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiSwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain2(Ptr3D value) => new IdxgiSwapChain2(value);

    /// <summary>casts <see cref = "IdxgiSwapChain2"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain2"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiSwapChain2 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiSwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain2(Ptr<IdxgiSwapChain2.Native> value) =>
        new IdxgiSwapChain2(value);

    /// <summary>casts <see cref = "IdxgiSwapChain2"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain2"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiSwapChain2.Native>(IdxgiSwapChain2 value) =>
        (Ptr<IdxgiSwapChain2.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiSwapChain2"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiSwapChain2(void*** value) =>
        new IdxgiSwapChain2((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChain2"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain2"/> instance to be converted </param>

    public static implicit operator void***(IdxgiSwapChain2 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiSwapChain2"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain2(nuint value) =>
        new IdxgiSwapChain2((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiSwapChain2"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain2"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiSwapChain2 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <inheritdoc cref = "IdxgiSwapChain1.GetBackgroundColor"/>

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

    /// <inheritdoc cref = "IdxgiSwapChain1.GetCoreWindow"/>

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

    /// <inheritdoc cref = "IdxgiSwapChain1.GetDesc1"/>

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

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetFrameLatencyWaitableObject"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public Handle GetFrameLatencyWaitableObject() => LpVtbl->GetFrameLatencyWaitableObject();

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

    /// <inheritdoc cref = "IdxgiSwapChain1.GetFullscreenDesc"/>

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

    /// <inheritdoc cref = "IdxgiSwapChain1.GetHwnd"/>

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

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetMatrixTransform"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HResult GetMatrixTransform(DxgiMatrix3X2F* pMatrix) =>
        LpVtbl->GetMatrixTransform(pMatrix);

    [VtblIndex(35)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMatrixTransform(Ref<DxgiMatrix3X2F> pMatrix)
    {
        fixed (DxgiMatrix3X2F* __dsl_pMatrix = pMatrix)
        {
            return (HResult)GetMatrixTransform(__dsl_pMatrix);
        }
    }

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetMaximumFrameLatency"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HResult GetMaximumFrameLatency(uint* pMaxLatency) =>
        LpVtbl->GetMaximumFrameLatency(pMaxLatency);

    [VtblIndex(32)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency)
    {
        fixed (uint* __dsl_pMaxLatency = pMaxLatency)
        {
            return (HResult)GetMaximumFrameLatency(__dsl_pMaxLatency);
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

    /// <inheritdoc cref = "IdxgiSwapChain1.GetRestrictToOutput"/>

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

    /// <inheritdoc cref = "IdxgiSwapChain1.GetRotation"/>

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

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.GetSourceSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HResult GetSourceSize(uint* pWidth, uint* pHeight) =>
        LpVtbl->GetSourceSize(pWidth, pHeight);

    [VtblIndex(30)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSourceSize(Ref<uint> pWidth, Ref<uint> pHeight)
    {
        fixed (uint* __dsl_pHeight = pHeight)
        fixed (uint* __dsl_pWidth = pWidth)
        {
            return (HResult)GetSourceSize(__dsl_pWidth, __dsl_pHeight);
        }
    }

    /// <inheritdoc cref = "IdxgiSwapChain1.IsTemporaryMonoSupported"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> IsTemporaryMonoSupported() => LpVtbl->IsTemporaryMonoSupported();

    /// <inheritdoc cref = "IdxgiSwapChain.Present"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult Present(uint SyncInterval, uint Flags) => LpVtbl->Present(SyncInterval, Flags);

    /// <inheritdoc cref = "IdxgiSwapChain1.Present1"/>

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

    /// <inheritdoc cref = "IdxgiSwapChain1.SetBackgroundColor"/>

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

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.SetMatrixTransform"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HResult SetMatrixTransform(
        [NativeTypeName("const DXGI_MATRIX_3X2_F *")] DxgiMatrix3X2F* pMatrix
    ) => LpVtbl->SetMatrixTransform(pMatrix);

    [VtblIndex(34)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetMatrixTransform(
        [NativeTypeName("const DXGI_MATRIX_3X2_F *")] Ref<DxgiMatrix3X2F> pMatrix
    )
    {
        fixed (DxgiMatrix3X2F* __dsl_pMatrix = pMatrix)
        {
            return (HResult)SetMatrixTransform(__dsl_pMatrix);
        }
    }

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.SetMaximumFrameLatency"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HResult SetMaximumFrameLatency(uint MaxLatency) =>
        LpVtbl->SetMaximumFrameLatency(MaxLatency);

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

    /// <inheritdoc cref = "IdxgiSwapChain1.SetRotation"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HResult SetRotation(DxgiModeRotation Rotation) => LpVtbl->SetRotation(Rotation);

    /// <include file='IDXGISwapChain2.xml' path='doc/member[@name="IDXGISwapChain2.SetSourceSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HResult SetSourceSize(uint Width, uint Height) => LpVtbl->SetSourceSize(Width, Height);
}
