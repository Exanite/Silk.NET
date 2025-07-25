// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIOutput5.xml' path='doc/member[@name="IDXGIOutput5"]/*'/>
[Guid("80A07424-AB52-42EB-833C-0C42FD282D98")]
[NativeTypeName("struct IDXGIOutput5 : IDXGIOutput4")]
[NativeInheritance("IDXGIOutput4")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IdxgiOutput5 : IdxgiOutput5.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiOutput5));

    public interface Interface : IdxgiOutput4.Interface
    {
        [VtblIndex(26)]
        HResult DuplicateOutput1(
            IUnknown pDevice,
            uint Flags,
            uint SupportedFormatsCount,
            [NativeTypeName("const DXGI_FORMAT *")] DxgiFormat* pSupportedFormats,
            IdxgiOutputDuplication* ppOutputDuplication
        );

        [VtblIndex(26)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult DuplicateOutput1(
            IUnknown pDevice,
            uint Flags,
            uint SupportedFormatsCount,
            [NativeTypeName("const DXGI_FORMAT *")] Ref<DxgiFormat> pSupportedFormats,
            Ref<IdxgiOutputDuplication> ppOutputDuplication
        );
    }

    /// <include file='IDXGIOutput5.xml' path='doc/member[@name="IDXGIOutput5"]/*'/>

    [Guid("80A07424-AB52-42EB-833C-0C42FD282D98")]
    [NativeTypeName("struct IDXGIOutput5 : IDXGIOutput4")]
    [NativeInheritance("IDXGIOutput4")]
    [SupportedOSPlatform("windows10.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiOutput5));
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

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>> SupportsOverlays;

            [NativeTypeName("HRESULT (DXGI_FORMAT, IUnknown *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                DxgiFormat,
                IUnknown.Native*,
                uint*,
                HResult> CheckOverlaySupport;

            [NativeTypeName(
                "HRESULT (DXGI_FORMAT, DXGI_COLOR_SPACE_TYPE, IUnknown *, UINT *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DxgiFormat,
                DxgiColorSpaceType,
                IUnknown.Native*,
                uint*,
                HResult> CheckOverlayColorSpaceSupport;

            [NativeTypeName(
                "HRESULT (IUnknown *, UINT, UINT, const DXGI_FORMAT *, IDXGIOutputDuplication **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                uint,
                uint,
                DxgiFormat*,
                IdxgiOutputDuplication.Native**,
                HResult> DuplicateOutput1;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiOutput5.Native*, uint>)(lpVtbl[1]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiOutput4.CheckOverlayColorSpaceSupport"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HResult CheckOverlayColorSpaceSupport(
            DxgiFormat Format,
            DxgiColorSpaceType ColorSpace,
            IUnknown pConcernedDevice,
            uint* pFlags
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput5.Native*,
                    DxgiFormat,
                    DxgiColorSpaceType,
                    IUnknown.Native*,
                    uint*,
                    HResult>)(lpVtbl[25])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
                Format,
                ColorSpace,
                pConcernedDevice.lpVtbl,
                pFlags
            );
        }

        [VtblIndex(25)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CheckOverlayColorSpaceSupport(
            DxgiFormat Format,
            DxgiColorSpaceType ColorSpace,
            IUnknown pConcernedDevice,
            Ref<uint> pFlags
        )
        {
            fixed (uint* __dsl_pFlags = pFlags)
            {
                return (HResult)CheckOverlayColorSpaceSupport(
                    Format,
                    ColorSpace,
                    pConcernedDevice,
                    __dsl_pFlags
                );
            }
        }

        /// <inheritdoc cref = "IdxgiOutput3.CheckOverlaySupport"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HResult CheckOverlaySupport(
            DxgiFormat EnumFormat,
            IUnknown pConcernedDevice,
            uint* pFlags
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput5.Native*,
                    DxgiFormat,
                    IUnknown.Native*,
                    uint*,
                    HResult>)(lpVtbl[24])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
                EnumFormat,
                pConcernedDevice.lpVtbl,
                pFlags
            );
        }

        [VtblIndex(24)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CheckOverlaySupport(
            DxgiFormat EnumFormat,
            IUnknown pConcernedDevice,
            Ref<uint> pFlags
        )
        {
            fixed (uint* __dsl_pFlags = pFlags)
            {
                return (HResult)CheckOverlaySupport(EnumFormat, pConcernedDevice, __dsl_pFlags);
            }
        }

        /// <inheritdoc cref = "IdxgiOutput1.DuplicateOutput"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HResult DuplicateOutput(
            IUnknown pDevice,
            IdxgiOutputDuplication* ppOutputDuplication
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput5.Native*,
                    IUnknown.Native*,
                    IdxgiOutputDuplication.Native**,
                    HResult>)(lpVtbl[22])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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

        /// <include file='IDXGIOutput5.xml' path='doc/member[@name="IDXGIOutput5.DuplicateOutput1"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HResult DuplicateOutput1(
            IUnknown pDevice,
            uint Flags,
            uint SupportedFormatsCount,
            [NativeTypeName("const DXGI_FORMAT *")] DxgiFormat* pSupportedFormats,
            IdxgiOutputDuplication* ppOutputDuplication
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutput5.Native*,
                    IUnknown.Native*,
                    uint,
                    uint,
                    DxgiFormat*,
                    IdxgiOutputDuplication.Native**,
                    HResult>)(lpVtbl[26])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                Flags,
                SupportedFormatsCount,
                pSupportedFormats,
                &ppOutputDuplication->LpVtbl
            );
        }

        [VtblIndex(26)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult DuplicateOutput1(
            IUnknown pDevice,
            uint Flags,
            uint SupportedFormatsCount,
            [NativeTypeName("const DXGI_FORMAT *")] Ref<DxgiFormat> pSupportedFormats,
            Ref<IdxgiOutputDuplication> ppOutputDuplication
        )
        {
            fixed (IdxgiOutputDuplication* __dsl_ppOutputDuplication = ppOutputDuplication)
            fixed (DxgiFormat* __dsl_pSupportedFormats = pSupportedFormats)
            {
                return (HResult)DuplicateOutput1(
                    pDevice,
                    Flags,
                    SupportedFormatsCount,
                    __dsl_pSupportedFormats,
                    __dsl_ppOutputDuplication
                );
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
                    IdxgiOutput5.Native*,
                    DxgiModeDesc*,
                    DxgiModeDesc*,
                    IUnknown.Native*,
                    HResult>)(lpVtbl[9])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IdxgiOutput1.FindClosestMatchingMode1"/>

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
                    IdxgiOutput5.Native*,
                    DxgiModeDesc1*,
                    DxgiModeDesc1*,
                    IUnknown.Native*,
                    HResult>)(lpVtbl[20])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiOutput5.Native*, DxgiOutputDesc*, HResult>)(lpVtbl[7])
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pDesc);
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
                    IdxgiOutput5.Native*,
                    DxgiFormat,
                    uint,
                    uint*,
                    DxgiModeDesc*,
                    HResult>)(lpVtbl[8])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IdxgiOutput1.GetDisplayModeList1"/>

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
                    IdxgiOutput5.Native*,
                    DxgiFormat,
                    uint,
                    uint*,
                    DxgiModeDesc1*,
                    HResult>)(lpVtbl[19])
            )(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiOutput5.Native*, IdxgiSurface.Native*, HResult>)(
                    lpVtbl[17]
                )
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pDestination.LpVtbl);
        }

        /// <inheritdoc cref = "IdxgiOutput1.GetDisplaySurfaceData1"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult GetDisplaySurfaceData1(IdxgiResource pDestination)
        {
            return (
                (delegate* unmanaged<IdxgiOutput5.Native*, IdxgiResource.Native*, HResult>)(
                    lpVtbl[21]
                )
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pDestination.LpVtbl);
        }

        /// <inheritdoc cref = "IdxgiOutput.GetFrameStatistics"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult GetFrameStatistics(DxgiFrameStatistics* pStats)
        {
            return (
                (delegate* unmanaged<IdxgiOutput5.Native*, DxgiFrameStatistics*, HResult>)(
                    lpVtbl[18]
                )
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pStats);
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
                (delegate* unmanaged<IdxgiOutput5.Native*, DxgiGammaControl*, HResult>)(lpVtbl[15])
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pArray);
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
                (delegate* unmanaged<IdxgiOutput5.Native*, DxgiGammaControlCapabilities*, HResult>)(
                    lpVtbl[13]
                )
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pGammaCaps);
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
            return ((delegate* unmanaged<IdxgiOutput5.Native*, Guid*, void**, HResult>)(lpVtbl[6]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiOutput5.Native*, Guid*, uint*, void*, HResult>)(lpVtbl[5])
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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
            return ((delegate* unmanaged<IdxgiOutput5.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this),
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
            return ((delegate* unmanaged<IdxgiOutput5.Native*, uint>)(lpVtbl[2]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiOutput.ReleaseOwnership"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void ReleaseOwnership()
        {
            ((delegate* unmanaged<IdxgiOutput5.Native*, void>)(lpVtbl[12]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiOutput.SetDisplaySurface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult SetDisplaySurface(IdxgiSurface pScanoutSurface)
        {
            return (
                (delegate* unmanaged<IdxgiOutput5.Native*, IdxgiSurface.Native*, HResult>)(
                    lpVtbl[16]
                )
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pScanoutSurface.LpVtbl);
        }

        /// <inheritdoc cref = "IdxgiOutput.SetGammaControl"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult SetGammaControl(
            [NativeTypeName("const DXGI_GAMMA_CONTROL *")] DxgiGammaControl* pArray
        )
        {
            return (
                (delegate* unmanaged<IdxgiOutput5.Native*, DxgiGammaControl*, HResult>)(lpVtbl[14])
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pArray);
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
                (delegate* unmanaged<IdxgiOutput5.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiOutput5.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <inheritdoc cref = "IdxgiOutput2.SupportsOverlays"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("BOOL")]
        public MaybeBool<int> SupportsOverlays()
        {
            return ((delegate* unmanaged<IdxgiOutput5.Native*, MaybeBool<int>>)(lpVtbl[23]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this)
            );
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
                    IdxgiOutput5.Native*,
                    IUnknown.Native*,
                    MaybeBool<int>,
                    HResult>)(lpVtbl[11])
            )((IdxgiOutput5.Native*)Unsafe.AsPointer(ref this), pDevice.lpVtbl, Exclusive);
        }

        /// <inheritdoc cref = "IdxgiOutput.WaitForVBlank"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult WaitForVBlank()
        {
            return ((delegate* unmanaged<IdxgiOutput5.Native*, HResult>)(lpVtbl[10]))(
                (IdxgiOutput5.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiOutput5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiOutput5(Ptr3D vtbl) => LpVtbl = (IdxgiOutput5.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiOutput5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiOutput5(Ptr<IdxgiOutput5.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiOutput5.Native"/> to <see cref = "IdxgiOutput5"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput5.Native"/> instance to be converted </param>

    public static implicit operator IdxgiOutput5(IdxgiOutput5.Native* value) =>
        new IdxgiOutput5((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiOutput5"/> to <see cref = "IdxgiOutput5.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput5"/> instance to be converted </param>

    public static implicit operator IdxgiOutput5.Native*(IdxgiOutput5 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiOutput5"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiOutput5(Ptr3D value) => new IdxgiOutput5(value);

    /// <summary>casts <see cref = "IdxgiOutput5"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput5"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiOutput5 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiOutput5"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiOutput5(Ptr<IdxgiOutput5.Native> value) =>
        new IdxgiOutput5(value);

    /// <summary>casts <see cref = "IdxgiOutput5"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput5"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiOutput5.Native>(IdxgiOutput5 value) =>
        (Ptr<IdxgiOutput5.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiOutput5"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiOutput5(void*** value) =>
        new IdxgiOutput5((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiOutput5"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput5"/> instance to be converted </param>

    public static implicit operator void***(IdxgiOutput5 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiOutput5"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiOutput5(nuint value) =>
        new IdxgiOutput5((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiOutput5"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutput5"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiOutput5 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <inheritdoc cref = "IdxgiOutput4.CheckOverlayColorSpaceSupport"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HResult CheckOverlayColorSpaceSupport(
        DxgiFormat Format,
        DxgiColorSpaceType ColorSpace,
        IUnknown pConcernedDevice,
        uint* pFlags
    ) => LpVtbl->CheckOverlayColorSpaceSupport(Format, ColorSpace, pConcernedDevice, pFlags);

    [VtblIndex(25)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckOverlayColorSpaceSupport(
        DxgiFormat Format,
        DxgiColorSpaceType ColorSpace,
        IUnknown pConcernedDevice,
        Ref<uint> pFlags
    )
    {
        fixed (uint* __dsl_pFlags = pFlags)
        {
            return (HResult)CheckOverlayColorSpaceSupport(
                Format,
                ColorSpace,
                pConcernedDevice,
                __dsl_pFlags
            );
        }
    }

    /// <inheritdoc cref = "IdxgiOutput3.CheckOverlaySupport"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HResult CheckOverlaySupport(
        DxgiFormat EnumFormat,
        IUnknown pConcernedDevice,
        uint* pFlags
    ) => LpVtbl->CheckOverlaySupport(EnumFormat, pConcernedDevice, pFlags);

    [VtblIndex(24)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckOverlaySupport(
        DxgiFormat EnumFormat,
        IUnknown pConcernedDevice,
        Ref<uint> pFlags
    )
    {
        fixed (uint* __dsl_pFlags = pFlags)
        {
            return (HResult)CheckOverlaySupport(EnumFormat, pConcernedDevice, __dsl_pFlags);
        }
    }

    /// <inheritdoc cref = "IdxgiOutput1.DuplicateOutput"/>

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

    /// <include file='IDXGIOutput5.xml' path='doc/member[@name="IDXGIOutput5.DuplicateOutput1"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HResult DuplicateOutput1(
        IUnknown pDevice,
        uint Flags,
        uint SupportedFormatsCount,
        [NativeTypeName("const DXGI_FORMAT *")] DxgiFormat* pSupportedFormats,
        IdxgiOutputDuplication* ppOutputDuplication
    ) =>
        LpVtbl->DuplicateOutput1(
            pDevice,
            Flags,
            SupportedFormatsCount,
            pSupportedFormats,
            ppOutputDuplication
        );

    [VtblIndex(26)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DuplicateOutput1(
        IUnknown pDevice,
        uint Flags,
        uint SupportedFormatsCount,
        [NativeTypeName("const DXGI_FORMAT *")] Ref<DxgiFormat> pSupportedFormats,
        Ref<IdxgiOutputDuplication> ppOutputDuplication
    )
    {
        fixed (IdxgiOutputDuplication* __dsl_ppOutputDuplication = ppOutputDuplication)
        fixed (DxgiFormat* __dsl_pSupportedFormats = pSupportedFormats)
        {
            return (HResult)DuplicateOutput1(
                pDevice,
                Flags,
                SupportedFormatsCount,
                __dsl_pSupportedFormats,
                __dsl_ppOutputDuplication
            );
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

    /// <inheritdoc cref = "IdxgiOutput1.FindClosestMatchingMode1"/>

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

    /// <inheritdoc cref = "IdxgiOutput1.GetDisplayModeList1"/>

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

    /// <inheritdoc cref = "IdxgiOutput1.GetDisplaySurfaceData1"/>

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

    /// <inheritdoc cref = "IdxgiOutput2.SupportsOverlays"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("BOOL")]
    public MaybeBool<int> SupportsOverlays() => LpVtbl->SupportsOverlays();

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
