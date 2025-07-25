// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain"]/*'/>
[Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
[NativeTypeName("struct IDXGISwapChain : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IdxgiSwapChain : IdxgiSwapChain.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChain));

    public interface Interface : IdxgiDeviceSubObject.Interface
    {
        [VtblIndex(9)]
        HResult GetBuffer(
            uint Buffer,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppSurface
        );

        [VtblIndex(9)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetBuffer(
            uint Buffer,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppSurface
        );

        [VtblIndex(15)]
        HResult GetContainingOutput(IdxgiOutput* ppOutput);

        [VtblIndex(15)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetContainingOutput(Ref<IdxgiOutput> ppOutput);

        [VtblIndex(12)]
        HResult GetDesc(DxgiSwapChainDesc* pDesc);

        [VtblIndex(12)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDesc(Ref<DxgiSwapChainDesc> pDesc);

        [VtblIndex(16)]
        HResult GetFrameStatistics(DxgiFrameStatistics* pStats);

        [VtblIndex(16)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFrameStatistics(Ref<DxgiFrameStatistics> pStats);

        [VtblIndex(11)]
        HResult GetFullscreenState(
            [NativeTypeName("BOOL *")] MaybeBool<int>* pFullscreen,
            IdxgiOutput* ppTarget
        );

        [VtblIndex(11)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFullscreenState(
            [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pFullscreen,
            Ref<IdxgiOutput> ppTarget
        );

        [VtblIndex(17)]
        HResult GetLastPresentCount(uint* pLastPresentCount);

        [VtblIndex(17)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetLastPresentCount(Ref<uint> pLastPresentCount);

        [VtblIndex(8)]
        HResult Present(uint SyncInterval, uint Flags);

        [VtblIndex(13)]
        HResult ResizeBuffers(
            uint BufferCount,
            uint Width,
            uint Height,
            DxgiFormat NewFormat,
            uint SwapChainFlags
        );

        [VtblIndex(14)]
        HResult ResizeTarget(
            [NativeTypeName("const DXGI_MODE_DESC *")] DxgiModeDesc* pNewTargetParameters
        );

        [VtblIndex(14)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult ResizeTarget(
            [NativeTypeName("const DXGI_MODE_DESC *")] Ref<DxgiModeDesc> pNewTargetParameters
        );

        [VtblIndex(10)]
        HResult SetFullscreenState(
            [NativeTypeName("BOOL")] MaybeBool<int> Fullscreen,
            IdxgiOutput pTarget
        );
    }

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain"]/*'/>

    [Guid("310D36A0-D2E7-4C0A-AA04-6A9D23B8886A")]
    [NativeTypeName("struct IDXGISwapChain : IDXGIDeviceSubObject")]
    [NativeInheritance("IDXGIDeviceSubObject")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChain));
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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiSwapChain.Native*, uint>)(lpVtbl[1]))(
                (IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetBuffer"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetBuffer(
            uint Buffer,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppSurface
        )
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, uint, Guid*, void**, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetContainingOutput"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult GetContainingOutput(IdxgiOutput* ppOutput)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[15]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), &ppOutput->LpVtbl);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetDesc"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult GetDesc(DxgiSwapChainDesc* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, DxgiSwapChainDesc*, HResult>)(
                    lpVtbl[12]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), pDesc);
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

        /// <inheritdoc cref = "IdxgiDeviceSubObject.GetDevice"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, Guid*, void**, HResult>)(lpVtbl[7])
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), riid, ppDevice);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetFrameStatistics"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult GetFrameStatistics(DxgiFrameStatistics* pStats)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, DxgiFrameStatistics*, HResult>)(
                    lpVtbl[16]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), pStats);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetFullscreenState"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetFullscreenState(
            [NativeTypeName("BOOL *")] MaybeBool<int>* pFullscreen,
            IdxgiOutput* ppTarget
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain.Native*,
                    MaybeBool<int>*,
                    IdxgiOutput.Native**,
                    HResult>)(lpVtbl[11])
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), pFullscreen, &ppTarget->LpVtbl);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetLastPresentCount"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult GetLastPresentCount(uint* pLastPresentCount)
        {
            return ((delegate* unmanaged<IdxgiSwapChain.Native*, uint*, HResult>)(lpVtbl[17]))(
                (IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiSwapChain.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiSwapChain.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.Present"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult Present(uint SyncInterval, uint Flags)
        {
            return ((delegate* unmanaged<IdxgiSwapChain.Native*, uint, uint, HResult>)(lpVtbl[8]))(
                (IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this),
                SyncInterval,
                Flags
            );
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiSwapChain.Native*, uint>)(lpVtbl[2]))(
                (IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.ResizeBuffers"]/*'/>

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
                    IdxgiSwapChain.Native*,
                    uint,
                    uint,
                    uint,
                    DxgiFormat,
                    uint,
                    HResult>)(lpVtbl[13])
            )(
                (IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this),
                BufferCount,
                Width,
                Height,
                NewFormat,
                SwapChainFlags
            );
        }

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.ResizeTarget"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult ResizeTarget(
            [NativeTypeName("const DXGI_MODE_DESC *")] DxgiModeDesc* pNewTargetParameters
        )
        {
            return (
                (delegate* unmanaged<IdxgiSwapChain.Native*, DxgiModeDesc*, HResult>)(lpVtbl[14])
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), pNewTargetParameters);
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

        /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.SetFullscreenState"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult SetFullscreenState(
            [NativeTypeName("BOOL")] MaybeBool<int> Fullscreen,
            IdxgiOutput pTarget
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChain.Native*,
                    MaybeBool<int>,
                    IdxgiOutput.Native*,
                    HResult>)(lpVtbl[10])
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), Fullscreen, pTarget.LpVtbl);
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
                (delegate* unmanaged<IdxgiSwapChain.Native*, Guid*, uint, void*, HResult>)(
                    lpVtbl[3]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiSwapChain.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiSwapChain.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChain(Ptr3D vtbl) => LpVtbl = (IdxgiSwapChain.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChain(Ptr<IdxgiSwapChain.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiSwapChain.Native"/> to <see cref = "IdxgiSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain.Native"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChain(IdxgiSwapChain.Native* value) =>
        new IdxgiSwapChain((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChain"/> to <see cref = "IdxgiSwapChain.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChain.Native*(IdxgiSwapChain value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain(Ptr3D value) => new IdxgiSwapChain(value);

    /// <summary>casts <see cref = "IdxgiSwapChain"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiSwapChain value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain(Ptr<IdxgiSwapChain.Native> value) =>
        new IdxgiSwapChain(value);

    /// <summary>casts <see cref = "IdxgiSwapChain"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiSwapChain.Native>(IdxgiSwapChain value) =>
        (Ptr<IdxgiSwapChain.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiSwapChain"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiSwapChain(void*** value) =>
        new IdxgiSwapChain((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChain"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain"/> instance to be converted </param>

    public static implicit operator void***(IdxgiSwapChain value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChain(nuint value) =>
        new IdxgiSwapChain((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiSwapChain"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChain"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiSwapChain value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetBuffer"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetContainingOutput"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetDesc"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetFrameStatistics"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetFullscreenState"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.GetLastPresentCount"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.Present"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult Present(uint SyncInterval, uint Flags) => LpVtbl->Present(SyncInterval, Flags);

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.ResizeBuffers"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult ResizeBuffers(
        uint BufferCount,
        uint Width,
        uint Height,
        DxgiFormat NewFormat,
        uint SwapChainFlags
    ) => LpVtbl->ResizeBuffers(BufferCount, Width, Height, NewFormat, SwapChainFlags);

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.ResizeTarget"]/*'/>

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

    /// <include file='IDXGISwapChain.xml' path='doc/member[@name="IDXGISwapChain.SetFullscreenState"]/*'/>

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
}
