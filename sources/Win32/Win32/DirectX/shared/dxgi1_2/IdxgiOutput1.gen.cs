// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1"]/*'/>
[Guid("00CDDEA8-939B-4B83-A340-A685226666CC")]
[NativeTypeName("struct IDXGIOutput1 : IDXGIOutput")]
[NativeInheritance("IDXGIOutput")]
public unsafe partial struct IdxgiOutput1 : IdxgiOutput1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiOutput1));

    public interface Interface : IdxgiOutput.Interface
    {
        [VtblIndex(22)]
        HResult DuplicateOutput(IUnknown pDevice, IdxgiOutputDuplication* ppOutputDuplication);

        [VtblIndex(22)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult DuplicateOutput(IUnknown pDevice, Ref<IdxgiOutputDuplication> ppOutputDuplication);

        [VtblIndex(20)]
        HResult FindClosestMatchingMode1(
            [NativeTypeName("const DXGI_MODE_DESC1 *")] DxgiModeDesc1* pModeToMatch,
            DxgiModeDesc1* pClosestMatch,
            IUnknown pConcernedDevice
        );

        [VtblIndex(20)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult FindClosestMatchingMode1(
            [NativeTypeName("const DXGI_MODE_DESC1 *")] Ref<DxgiModeDesc1> pModeToMatch,
            Ref<DxgiModeDesc1> pClosestMatch,
            IUnknown pConcernedDevice
        );

        [VtblIndex(19)]
        HResult GetDisplayModeList1(
            DxgiFormat EnumFormat,
            uint Flags,
            uint* pNumModes,
            DxgiModeDesc1* pDesc
        );

        [VtblIndex(19)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDisplayModeList1(
            DxgiFormat EnumFormat,
            uint Flags,
            Ref<uint> pNumModes,
            Ref<DxgiModeDesc1> pDesc
        );

        [VtblIndex(21)]
        HResult GetDisplaySurfaceData1(IdxgiResource pDestination);
    }

    /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1"]/*'/>

    [Guid("00CDDEA8-939B-4B83-A340-A685226666CC")]
    [NativeTypeName("struct IDXGIOutput1 : IDXGIOutput")]
    [NativeInheritance("IDXGIOutput")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiOutput1));
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

            [NativeTypeName("HRESULT (DXGI_OUTPUT_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiOutputDesc*, HResult> GetDesc;

            [NativeTypeName(
                "HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DxgiFormat,
                uint,
                uint*,
                DxgiModeDesc*,
                HResult> GetDisplayModeList;

            [NativeTypeName(
                "HRESULT (const DXGI_MODE_DESC *, DXGI_MODE_DESC *, IUnknown *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DxgiModeDesc*,
                DxgiModeDesc*,
                IUnknown.Native*,
                HResult> FindClosestMatchingMode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> WaitForVBlank;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                MaybeBool<int>,
                HResult> TakeOwnership;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> ReleaseOwnership;

            [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL_CAPABILITIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                DxgiGammaControlCapabilities*,
                HResult> GetGammaControlCapabilities;

            [NativeTypeName("HRESULT (const DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiGammaControl*, HResult> SetGammaControl;

            [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiGammaControl*, HResult> GetGammaControl;

            [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IdxgiSurface.Native*, HResult> SetDisplaySurface;

            [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IdxgiSurface.Native*, HResult> GetDisplaySurfaceData;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiFrameStatistics*, HResult> GetFrameStatistics;

            [NativeTypeName(
                "HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC1 *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DxgiFormat,
                uint,
                uint*,
                DxgiModeDesc1*,
                HResult> GetDisplayModeList1;

            [NativeTypeName(
                "HRESULT (const DXGI_MODE_DESC1 *, DXGI_MODE_DESC1 *, IUnknown *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DxgiModeDesc1*,
                DxgiModeDesc1*,
                IUnknown.Native*,
                HResult> FindClosestMatchingMode1;

            [NativeTypeName("HRESULT (IDXGIResource *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                IdxgiResource.Native*,
                HResult> GetDisplaySurfaceData1;

            [NativeTypeName(
                "HRESULT (IUnknown *, IDXGIOutputDuplication **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                IdxgiOutputDuplication.Native**,
                HResult> DuplicateOutput;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiOutput1.Native*, uint>)(lpVtbl[1]))(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.DuplicateOutput"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HResult DuplicateOutput(
            IUnknown pDevice,
            IdxgiOutputDuplication* ppOutputDuplication
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput1.Native*,
                    IUnknown.Native*,
                    IdxgiOutputDuplication.Native**,
                    HResult>)(lpVtbl[22])
            )(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                &ppOutputDuplication->LpVtbl
            );
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult DuplicateOutput(
            IUnknown pDevice,
            Ref<IdxgiOutputDuplication> ppOutputDuplication
        )
        {
            fixed (IdxgiOutputDuplication* __dsl_ppOutputDuplication = ppOutputDuplication)
            {
                return (HResult)DuplicateOutput(pDevice, __dsl_ppOutputDuplication);
            }
        }

        /// <inheritdoc cref = "IdxgiOutput.FindClosestMatchingMode"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult FindClosestMatchingMode(
            [NativeTypeName("const DXGI_MODE_DESC *")] DxgiModeDesc* pModeToMatch,
            DxgiModeDesc* pClosestMatch,
            IUnknown pConcernedDevice
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput1.Native*,
                    DxgiModeDesc*,
                    DxgiModeDesc*,
                    IUnknown.Native*,
                    HResult>)(lpVtbl[9])
            )(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                pModeToMatch,
                pClosestMatch,
                pConcernedDevice.lpVtbl
            );
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult FindClosestMatchingMode(
            [NativeTypeName("const DXGI_MODE_DESC *")] Ref<DxgiModeDesc> pModeToMatch,
            Ref<DxgiModeDesc> pClosestMatch,
            IUnknown pConcernedDevice
        )
        {
            fixed (DxgiModeDesc* __dsl_pClosestMatch = pClosestMatch)
            fixed (DxgiModeDesc* __dsl_pModeToMatch = pModeToMatch)
            {
                return (HResult)FindClosestMatchingMode(
                    __dsl_pModeToMatch,
                    __dsl_pClosestMatch,
                    pConcernedDevice
                );
            }
        }

        /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.FindClosestMatchingMode1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult FindClosestMatchingMode1(
            [NativeTypeName("const DXGI_MODE_DESC1 *")] DxgiModeDesc1* pModeToMatch,
            DxgiModeDesc1* pClosestMatch,
            IUnknown pConcernedDevice
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput1.Native*,
                    DxgiModeDesc1*,
                    DxgiModeDesc1*,
                    IUnknown.Native*,
                    HResult>)(lpVtbl[20])
            )(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                pModeToMatch,
                pClosestMatch,
                pConcernedDevice.lpVtbl
            );
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult FindClosestMatchingMode1(
            [NativeTypeName("const DXGI_MODE_DESC1 *")] Ref<DxgiModeDesc1> pModeToMatch,
            Ref<DxgiModeDesc1> pClosestMatch,
            IUnknown pConcernedDevice
        )
        {
            fixed (DxgiModeDesc1* __dsl_pClosestMatch = pClosestMatch)
            fixed (DxgiModeDesc1* __dsl_pModeToMatch = pModeToMatch)
            {
                return (HResult)FindClosestMatchingMode1(
                    __dsl_pModeToMatch,
                    __dsl_pClosestMatch,
                    pConcernedDevice
                );
            }
        }

        /// <inheritdoc cref = "IdxgiOutput.GetDesc"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDesc(DxgiOutputDesc* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, DxgiOutputDesc*, HResult>)(lpVtbl[7])
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc(Ref<DxgiOutputDesc> pDesc)
        {
            fixed (DxgiOutputDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiOutput.GetDisplayModeList"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDisplayModeList(
            DxgiFormat EnumFormat,
            uint Flags,
            uint* pNumModes,
            DxgiModeDesc* pDesc
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput1.Native*,
                    DxgiFormat,
                    uint,
                    uint*,
                    DxgiModeDesc*,
                    HResult>)(lpVtbl[8])
            )(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                EnumFormat,
                Flags,
                pNumModes,
                pDesc
            );
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDisplayModeList(
            DxgiFormat EnumFormat,
            uint Flags,
            Ref<uint> pNumModes,
            Ref<DxgiModeDesc> pDesc
        )
        {
            fixed (DxgiModeDesc* __dsl_pDesc = pDesc)
            fixed (uint* __dsl_pNumModes = pNumModes)
            {
                return (HResult)GetDisplayModeList(EnumFormat, Flags, __dsl_pNumModes, __dsl_pDesc);
            }
        }

        /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.GetDisplayModeList1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult GetDisplayModeList1(
            DxgiFormat EnumFormat,
            uint Flags,
            uint* pNumModes,
            DxgiModeDesc1* pDesc
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput1.Native*,
                    DxgiFormat,
                    uint,
                    uint*,
                    DxgiModeDesc1*,
                    HResult>)(lpVtbl[19])
            )(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                EnumFormat,
                Flags,
                pNumModes,
                pDesc
            );
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDisplayModeList1(
            DxgiFormat EnumFormat,
            uint Flags,
            Ref<uint> pNumModes,
            Ref<DxgiModeDesc1> pDesc
        )
        {
            fixed (DxgiModeDesc1* __dsl_pDesc = pDesc)
            fixed (uint* __dsl_pNumModes = pNumModes)
            {
                return (HResult)GetDisplayModeList1(
                    EnumFormat,
                    Flags,
                    __dsl_pNumModes,
                    __dsl_pDesc
                );
            }
        }

        /// <inheritdoc cref = "IdxgiOutput.GetDisplaySurfaceData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult GetDisplaySurfaceData(IdxgiSurface pDestination)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, IdxgiSurface.Native*, HResult>)(
                    lpVtbl[17]
                )
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pDestination.LpVtbl);
        }

        /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.GetDisplaySurfaceData1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult GetDisplaySurfaceData1(IdxgiResource pDestination)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, IdxgiResource.Native*, HResult>)(
                    lpVtbl[21]
                )
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pDestination.LpVtbl);
        }

        /// <inheritdoc cref = "IdxgiOutput.GetFrameStatistics"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult GetFrameStatistics(DxgiFrameStatistics* pStats)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, DxgiFrameStatistics*, HResult>)(
                    lpVtbl[18]
                )
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pStats);
        }

        [VtblIndex(18)]
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

        /// <inheritdoc cref = "IdxgiOutput.GetGammaControl"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult GetGammaControl(DxgiGammaControl* pArray)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, DxgiGammaControl*, HResult>)(lpVtbl[15])
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pArray);
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetGammaControl(Ref<DxgiGammaControl> pArray)
        {
            fixed (DxgiGammaControl* __dsl_pArray = pArray)
            {
                return (HResult)GetGammaControl(__dsl_pArray);
            }
        }

        /// <inheritdoc cref = "IdxgiOutput.GetGammaControlCapabilities"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult GetGammaControlCapabilities(DxgiGammaControlCapabilities* pGammaCaps)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, DxgiGammaControlCapabilities*, HResult>)(
                    lpVtbl[13]
                )
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetGammaControlCapabilities(Ref<DxgiGammaControlCapabilities> pGammaCaps)
        {
            fixed (DxgiGammaControlCapabilities* __dsl_pGammaCaps = pGammaCaps)
            {
                return (HResult)GetGammaControlCapabilities(__dsl_pGammaCaps);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IdxgiOutput1.Native*, Guid*, void**, HResult>)(lpVtbl[6]))(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppParent
            );
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
                (delegate* unmanaged<IdxgiOutput1.Native*, Guid*, uint*, void*, HResult>)(lpVtbl[5])
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IdxgiOutput1.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
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
            return ((delegate* unmanaged<IdxgiOutput1.Native*, uint>)(lpVtbl[2]))(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiOutput.ReleaseOwnership"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void ReleaseOwnership()
        {
            ((delegate* unmanaged<IdxgiOutput1.Native*, void>)(lpVtbl[12]))(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiOutput.SetDisplaySurface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult SetDisplaySurface(IdxgiSurface pScanoutSurface)
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, IdxgiSurface.Native*, HResult>)(
                    lpVtbl[16]
                )
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pScanoutSurface.LpVtbl);
        }

        /// <inheritdoc cref = "IdxgiOutput.SetGammaControl"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult SetGammaControl(
            [NativeTypeName("const DXGI_GAMMA_CONTROL *")] DxgiGammaControl* pArray
        )
        {
            return (
                (delegate* unmanaged<IdxgiOutput1.Native*, DxgiGammaControl*, HResult>)(lpVtbl[14])
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pArray);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetGammaControl(
            [NativeTypeName("const DXGI_GAMMA_CONTROL *")] Ref<DxgiGammaControl> pArray
        )
        {
            fixed (DxgiGammaControl* __dsl_pArray = pArray)
            {
                return (HResult)SetGammaControl(__dsl_pArray);
            }
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
                (delegate* unmanaged<IdxgiOutput1.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiOutput1.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <inheritdoc cref = "IdxgiOutput.TakeOwnership"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult TakeOwnership(
            IUnknown pDevice,
            [NativeTypeName("BOOL")] MaybeBool<int> Exclusive
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput1.Native*,
                    IUnknown.Native*,
                    MaybeBool<int>,
                    HResult>)(lpVtbl[11])
            )((IdxgiOutput1.Native*)Unsafe.AsPointer(ref this), pDevice.lpVtbl, Exclusive);
        }

        /// <inheritdoc cref = "IdxgiOutput.WaitForVBlank"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult WaitForVBlank()
        {
            return ((delegate* unmanaged<IdxgiOutput1.Native*, HResult>)(lpVtbl[10]))(
                (IdxgiOutput1.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiOutput1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiOutput1(Ptr3D vtbl) => LpVtbl = (IdxgiOutput1.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiOutput1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiOutput1(Ptr<IdxgiOutput1.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiOutput1.Native"/> to <see cref = "IdxgiOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput1.Native"/> instance to be converted </param>

    public static implicit operator IdxgiOutput1(IdxgiOutput1.Native* value) =>
        new IdxgiOutput1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiOutput1"/> to <see cref = "IdxgiOutput1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput1"/> instance to be converted </param>

    public static implicit operator IdxgiOutput1.Native*(IdxgiOutput1 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiOutput1(Ptr3D value) => new IdxgiOutput1(value);

    /// <summary>casts <see cref = "IdxgiOutput1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput1"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiOutput1 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiOutput1(Ptr<IdxgiOutput1.Native> value) =>
        new IdxgiOutput1(value);

    /// <summary>casts <see cref = "IdxgiOutput1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput1"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiOutput1.Native>(IdxgiOutput1 value) =>
        (Ptr<IdxgiOutput1.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiOutput1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiOutput1(void*** value) =>
        new IdxgiOutput1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiOutput1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput1"/> instance to be converted </param>

    public static implicit operator void***(IdxgiOutput1 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiOutput1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiOutput1(nuint value) =>
        new IdxgiOutput1((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiOutput1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput1"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiOutput1 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.DuplicateOutput"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HResult DuplicateOutput(IUnknown pDevice, IdxgiOutputDuplication* ppOutputDuplication) =>
        LpVtbl->DuplicateOutput(pDevice, ppOutputDuplication);

    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DuplicateOutput(
        IUnknown pDevice,
        Ref<IdxgiOutputDuplication> ppOutputDuplication
    )
    {
        fixed (IdxgiOutputDuplication* __dsl_ppOutputDuplication = ppOutputDuplication)
        {
            return (HResult)DuplicateOutput(pDevice, __dsl_ppOutputDuplication);
        }
    }

    /// <inheritdoc cref = "IdxgiOutput.FindClosestMatchingMode"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult FindClosestMatchingMode(
        [NativeTypeName("const DXGI_MODE_DESC *")] DxgiModeDesc* pModeToMatch,
        DxgiModeDesc* pClosestMatch,
        IUnknown pConcernedDevice
    ) => LpVtbl->FindClosestMatchingMode(pModeToMatch, pClosestMatch, pConcernedDevice);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult FindClosestMatchingMode(
        [NativeTypeName("const DXGI_MODE_DESC *")] Ref<DxgiModeDesc> pModeToMatch,
        Ref<DxgiModeDesc> pClosestMatch,
        IUnknown pConcernedDevice
    )
    {
        fixed (DxgiModeDesc* __dsl_pClosestMatch = pClosestMatch)
        fixed (DxgiModeDesc* __dsl_pModeToMatch = pModeToMatch)
        {
            return (HResult)FindClosestMatchingMode(
                __dsl_pModeToMatch,
                __dsl_pClosestMatch,
                pConcernedDevice
            );
        }
    }

    /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.FindClosestMatchingMode1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HResult FindClosestMatchingMode1(
        [NativeTypeName("const DXGI_MODE_DESC1 *")] DxgiModeDesc1* pModeToMatch,
        DxgiModeDesc1* pClosestMatch,
        IUnknown pConcernedDevice
    ) => LpVtbl->FindClosestMatchingMode1(pModeToMatch, pClosestMatch, pConcernedDevice);

    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult FindClosestMatchingMode1(
        [NativeTypeName("const DXGI_MODE_DESC1 *")] Ref<DxgiModeDesc1> pModeToMatch,
        Ref<DxgiModeDesc1> pClosestMatch,
        IUnknown pConcernedDevice
    )
    {
        fixed (DxgiModeDesc1* __dsl_pClosestMatch = pClosestMatch)
        fixed (DxgiModeDesc1* __dsl_pModeToMatch = pModeToMatch)
        {
            return (HResult)FindClosestMatchingMode1(
                __dsl_pModeToMatch,
                __dsl_pClosestMatch,
                pConcernedDevice
            );
        }
    }

    /// <inheritdoc cref = "IdxgiOutput.GetDesc"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDesc(DxgiOutputDesc* pDesc) => LpVtbl->GetDesc(pDesc);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<DxgiOutputDesc> pDesc)
    {
        fixed (DxgiOutputDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiOutput.GetDisplayModeList"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDisplayModeList(
        DxgiFormat EnumFormat,
        uint Flags,
        uint* pNumModes,
        DxgiModeDesc* pDesc
    ) => LpVtbl->GetDisplayModeList(EnumFormat, Flags, pNumModes, pDesc);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDisplayModeList(
        DxgiFormat EnumFormat,
        uint Flags,
        Ref<uint> pNumModes,
        Ref<DxgiModeDesc> pDesc
    )
    {
        fixed (DxgiModeDesc* __dsl_pDesc = pDesc)
        fixed (uint* __dsl_pNumModes = pNumModes)
        {
            return (HResult)GetDisplayModeList(EnumFormat, Flags, __dsl_pNumModes, __dsl_pDesc);
        }
    }

    /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.GetDisplayModeList1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult GetDisplayModeList1(
        DxgiFormat EnumFormat,
        uint Flags,
        uint* pNumModes,
        DxgiModeDesc1* pDesc
    ) => LpVtbl->GetDisplayModeList1(EnumFormat, Flags, pNumModes, pDesc);

    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDisplayModeList1(
        DxgiFormat EnumFormat,
        uint Flags,
        Ref<uint> pNumModes,
        Ref<DxgiModeDesc1> pDesc
    )
    {
        fixed (DxgiModeDesc1* __dsl_pDesc = pDesc)
        fixed (uint* __dsl_pNumModes = pNumModes)
        {
            return (HResult)GetDisplayModeList1(EnumFormat, Flags, __dsl_pNumModes, __dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiOutput.GetDisplaySurfaceData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult GetDisplaySurfaceData(IdxgiSurface pDestination) =>
        LpVtbl->GetDisplaySurfaceData(pDestination);

    /// <include file='IDXGIOutput1.xml' path='doc/member[@name="IDXGIOutput1.GetDisplaySurfaceData1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HResult GetDisplaySurfaceData1(IdxgiResource pDestination) =>
        LpVtbl->GetDisplaySurfaceData1(pDestination);

    /// <inheritdoc cref = "IdxgiOutput.GetFrameStatistics"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HResult GetFrameStatistics(DxgiFrameStatistics* pStats) =>
        LpVtbl->GetFrameStatistics(pStats);

    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFrameStatistics(Ref<DxgiFrameStatistics> pStats)
    {
        fixed (DxgiFrameStatistics* __dsl_pStats = pStats)
        {
            return (HResult)GetFrameStatistics(__dsl_pStats);
        }
    }

    /// <inheritdoc cref = "IdxgiOutput.GetGammaControl"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult GetGammaControl(DxgiGammaControl* pArray) => LpVtbl->GetGammaControl(pArray);

    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGammaControl(Ref<DxgiGammaControl> pArray)
    {
        fixed (DxgiGammaControl* __dsl_pArray = pArray)
        {
            return (HResult)GetGammaControl(__dsl_pArray);
        }
    }

    /// <inheritdoc cref = "IdxgiOutput.GetGammaControlCapabilities"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult GetGammaControlCapabilities(DxgiGammaControlCapabilities* pGammaCaps) =>
        LpVtbl->GetGammaControlCapabilities(pGammaCaps);

    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGammaControlCapabilities(Ref<DxgiGammaControlCapabilities> pGammaCaps)
    {
        fixed (DxgiGammaControlCapabilities* __dsl_pGammaCaps = pGammaCaps)
        {
            return (HResult)GetGammaControlCapabilities(__dsl_pGammaCaps);
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

    /// <inheritdoc cref = "IdxgiOutput.ReleaseOwnership"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ReleaseOwnership() => LpVtbl->ReleaseOwnership();

    /// <inheritdoc cref = "IdxgiOutput.SetDisplaySurface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult SetDisplaySurface(IdxgiSurface pScanoutSurface) =>
        LpVtbl->SetDisplaySurface(pScanoutSurface);

    /// <inheritdoc cref = "IdxgiOutput.SetGammaControl"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult SetGammaControl(
        [NativeTypeName("const DXGI_GAMMA_CONTROL *")] DxgiGammaControl* pArray
    ) => LpVtbl->SetGammaControl(pArray);

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetGammaControl(
        [NativeTypeName("const DXGI_GAMMA_CONTROL *")] Ref<DxgiGammaControl> pArray
    )
    {
        fixed (DxgiGammaControl* __dsl_pArray = pArray)
        {
            return (HResult)SetGammaControl(__dsl_pArray);
        }
    }

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

    /// <inheritdoc cref = "IdxgiOutput.TakeOwnership"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult TakeOwnership(
        IUnknown pDevice,
        [NativeTypeName("BOOL")] MaybeBool<int> Exclusive
    ) => LpVtbl->TakeOwnership(pDevice, Exclusive);

    /// <inheritdoc cref = "IdxgiOutput.WaitForVBlank"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult WaitForVBlank() => LpVtbl->WaitForVBlank();
}
