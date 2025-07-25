// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3"]/*'/>
[Guid("645967A4-1392-4310-A798-8053CE3E93FD")]
[NativeTypeName("struct IDXGIAdapter3 : IDXGIAdapter2")]
[NativeInheritance("IDXGIAdapter2")]
public unsafe partial struct IdxgiAdapter3 : IdxgiAdapter3.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiAdapter3));

    public interface Interface : IdxgiAdapter2.Interface
    {
        [VtblIndex(14)]
        HResult QueryVideoMemoryInfo(
            uint NodeIndex,
            DxgiMemorySegmentGroup MemorySegmentGroup,
            DxgiQueryVideoMemoryInfo* pVideoMemoryInfo
        );

        [VtblIndex(14)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult QueryVideoMemoryInfo(
            uint NodeIndex,
            DxgiMemorySegmentGroup MemorySegmentGroup,
            Ref<DxgiQueryVideoMemoryInfo> pVideoMemoryInfo
        );

        [VtblIndex(12)]
        HResult RegisterHardwareContentProtectionTeardownStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(12)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult RegisterHardwareContentProtectionTeardownStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        );

        [VtblIndex(16)]
        HResult RegisterVideoMemoryBudgetChangeNotificationEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(16)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult RegisterVideoMemoryBudgetChangeNotificationEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        );

        [VtblIndex(15)]
        HResult SetVideoMemoryReservation(
            uint NodeIndex,
            DxgiMemorySegmentGroup MemorySegmentGroup,
            [NativeTypeName("UINT64")] ulong Reservation
        );

        [VtblIndex(13)]
        void UnregisterHardwareContentProtectionTeardownStatus(
            [NativeTypeName("DWORD")] uint dwCookie
        );

        [VtblIndex(17)]
        void UnregisterVideoMemoryBudgetChangeNotification([NativeTypeName("DWORD")] uint dwCookie);
    }

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3"]/*'/>

    [Guid("645967A4-1392-4310-A798-8053CE3E93FD")]
    [NativeTypeName("struct IDXGIAdapter3 : IDXGIAdapter2")]
    [NativeInheritance("IDXGIAdapter2")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiAdapter3));
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

            [NativeTypeName("HRESULT (UINT, IDXGIOutput **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IdxgiOutput.Native**, HResult> EnumOutputs;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiAdapterDesc*, HResult> GetDesc;

            [NativeTypeName("HRESULT (const GUID &, LARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, LargeInteger*, HResult> CheckInterfaceSupport;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC1 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiAdapterDesc1*, HResult> GetDesc1;

            [NativeTypeName("HRESULT (DXGI_ADAPTER_DESC2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiAdapterDesc2*, HResult> GetDesc2;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                Handle,
                uint*,
                HResult> RegisterHardwareContentProtectionTeardownStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                uint,
                void> UnregisterHardwareContentProtectionTeardownStatus;

            [NativeTypeName(
                "HRESULT (UINT, DXGI_MEMORY_SEGMENT_GROUP, DXGI_QUERY_VIDEO_MEMORY_INFO *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                DxgiMemorySegmentGroup,
                DxgiQueryVideoMemoryInfo*,
                HResult> QueryVideoMemoryInfo;

            [NativeTypeName(
                "HRESULT (UINT, DXGI_MEMORY_SEGMENT_GROUP, UINT64) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                DxgiMemorySegmentGroup,
                ulong,
                HResult> SetVideoMemoryReservation;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                Handle,
                uint*,
                HResult> RegisterVideoMemoryBudgetChangeNotificationEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                uint,
                void> UnregisterVideoMemoryBudgetChangeNotification;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiAdapter3.Native*, uint>)(lpVtbl[1]))(
                (IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiAdapter.CheckInterfaceSupport"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CheckInterfaceSupport(
            [NativeTypeName("const GUID &")] Guid* InterfaceName,
            LargeInteger* pUMDVersion
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, Guid*, LargeInteger*, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), InterfaceName, pUMDVersion);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CheckInterfaceSupport(
            [NativeTypeName("const GUID &")] Ref<Guid> InterfaceName,
            Ref<LargeInteger> pUMDVersion
        )
        {
            fixed (LargeInteger* __dsl_pUMDVersion = pUMDVersion)
            fixed (Guid* __dsl_InterfaceName = InterfaceName)
            {
                return (HResult)CheckInterfaceSupport(__dsl_InterfaceName, __dsl_pUMDVersion);
            }
        }

        /// <inheritdoc cref = "IdxgiAdapter.EnumOutputs"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult EnumOutputs(uint Output, IdxgiOutput* ppOutput)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, uint, IdxgiOutput.Native**, HResult>)(
                    lpVtbl[7]
                )
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), Output, &ppOutput->LpVtbl);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult EnumOutputs(uint Output, Ref<IdxgiOutput> ppOutput)
        {
            fixed (IdxgiOutput* __dsl_ppOutput = ppOutput)
            {
                return (HResult)EnumOutputs(Output, __dsl_ppOutput);
            }
        }

        /// <inheritdoc cref = "IdxgiAdapter.GetDesc"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDesc(DxgiAdapterDesc* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, DxgiAdapterDesc*, HResult>)(lpVtbl[8])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc(Ref<DxgiAdapterDesc> pDesc)
        {
            fixed (DxgiAdapterDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiAdapter1.GetDesc1"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult GetDesc1(DxgiAdapterDesc1* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, DxgiAdapterDesc1*, HResult>)(lpVtbl[10])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc1(Ref<DxgiAdapterDesc1> pDesc)
        {
            fixed (DxgiAdapterDesc1* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc1(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiAdapter2.GetDesc2"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetDesc2(DxgiAdapterDesc2* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, DxgiAdapterDesc2*, HResult>)(lpVtbl[11])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc2(Ref<DxgiAdapterDesc2> pDesc)
        {
            fixed (DxgiAdapterDesc2* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc2(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiAdapter3.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.QueryVideoMemoryInfo"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult QueryVideoMemoryInfo(
            uint NodeIndex,
            DxgiMemorySegmentGroup MemorySegmentGroup,
            DxgiQueryVideoMemoryInfo* pVideoMemoryInfo
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiAdapter3.Native*,
                    uint,
                    DxgiMemorySegmentGroup,
                    DxgiQueryVideoMemoryInfo*,
                    HResult>)(lpVtbl[14])
            )(
                (IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this),
                NodeIndex,
                MemorySegmentGroup,
                pVideoMemoryInfo
            );
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryVideoMemoryInfo(
            uint NodeIndex,
            DxgiMemorySegmentGroup MemorySegmentGroup,
            Ref<DxgiQueryVideoMemoryInfo> pVideoMemoryInfo
        )
        {
            fixed (DxgiQueryVideoMemoryInfo* __dsl_pVideoMemoryInfo = pVideoMemoryInfo)
            {
                return (HResult)QueryVideoMemoryInfo(
                    NodeIndex,
                    MemorySegmentGroup,
                    __dsl_pVideoMemoryInfo
                );
            }
        }

        /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.RegisterHardwareContentProtectionTeardownStatusEvent"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult RegisterHardwareContentProtectionTeardownStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, Handle, uint*, HResult>)(lpVtbl[12])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult RegisterHardwareContentProtectionTeardownStatusEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        )
        {
            fixed (uint* __dsl_pdwCookie = pdwCookie)
            {
                return (HResult)RegisterHardwareContentProtectionTeardownStatusEvent(
                    hEvent,
                    __dsl_pdwCookie
                );
            }
        }

        /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.RegisterVideoMemoryBudgetChangeNotificationEvent"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult RegisterVideoMemoryBudgetChangeNotificationEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        )
        {
            return (
                (delegate* unmanaged<IdxgiAdapter3.Native*, Handle, uint*, HResult>)(lpVtbl[16])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult RegisterVideoMemoryBudgetChangeNotificationEvent(
            Handle hEvent,
            [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
        )
        {
            fixed (uint* __dsl_pdwCookie = pdwCookie)
            {
                return (HResult)RegisterVideoMemoryBudgetChangeNotificationEvent(
                    hEvent,
                    __dsl_pdwCookie
                );
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IdxgiAdapter3.Native*, uint>)(lpVtbl[2]))(
                (IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this)
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
                (delegate* unmanaged<IdxgiAdapter3.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiAdapter3.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.SetVideoMemoryReservation"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult SetVideoMemoryReservation(
            uint NodeIndex,
            DxgiMemorySegmentGroup MemorySegmentGroup,
            [NativeTypeName("UINT64")] ulong Reservation
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiAdapter3.Native*,
                    uint,
                    DxgiMemorySegmentGroup,
                    ulong,
                    HResult>)(lpVtbl[15])
            )(
                (IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this),
                NodeIndex,
                MemorySegmentGroup,
                Reservation
            );
        }

        /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.UnregisterHardwareContentProtectionTeardownStatus"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void UnregisterHardwareContentProtectionTeardownStatus(
            [NativeTypeName("DWORD")] uint dwCookie
        )
        {
            ((delegate* unmanaged<IdxgiAdapter3.Native*, uint, void>)(lpVtbl[13]))(
                (IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this),
                dwCookie
            );
        }

        /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.UnregisterVideoMemoryBudgetChangeNotification"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void UnregisterVideoMemoryBudgetChangeNotification(
            [NativeTypeName("DWORD")] uint dwCookie
        )
        {
            ((delegate* unmanaged<IdxgiAdapter3.Native*, uint, void>)(lpVtbl[17]))(
                (IdxgiAdapter3.Native*)Unsafe.AsPointer(ref this),
                dwCookie
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiAdapter3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiAdapter3(Ptr3D vtbl) => LpVtbl = (IdxgiAdapter3.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiAdapter3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiAdapter3(Ptr<IdxgiAdapter3.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiAdapter3.Native"/> to <see cref = "IdxgiAdapter3"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter3.Native"/> instance to be converted </param>

    public static implicit operator IdxgiAdapter3(IdxgiAdapter3.Native* value) =>
        new IdxgiAdapter3((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiAdapter3"/> to <see cref = "IdxgiAdapter3.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter3"/> instance to be converted </param>

    public static implicit operator IdxgiAdapter3.Native*(IdxgiAdapter3 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiAdapter3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiAdapter3(Ptr3D value) => new IdxgiAdapter3(value);

    /// <summary>casts <see cref = "IdxgiAdapter3"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter3"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiAdapter3 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiAdapter3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiAdapter3(Ptr<IdxgiAdapter3.Native> value) =>
        new IdxgiAdapter3(value);

    /// <summary>casts <see cref = "IdxgiAdapter3"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter3"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiAdapter3.Native>(IdxgiAdapter3 value) =>
        (Ptr<IdxgiAdapter3.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiAdapter3"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiAdapter3(void*** value) =>
        new IdxgiAdapter3((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiAdapter3"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter3"/> instance to be converted </param>

    public static implicit operator void***(IdxgiAdapter3 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiAdapter3"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiAdapter3(nuint value) =>
        new IdxgiAdapter3((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiAdapter3"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiAdapter3"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiAdapter3 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <inheritdoc cref = "IdxgiAdapter.CheckInterfaceSupport"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CheckInterfaceSupport(
        [NativeTypeName("const GUID &")] Guid* InterfaceName,
        LargeInteger* pUMDVersion
    ) => LpVtbl->CheckInterfaceSupport(InterfaceName, pUMDVersion);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckInterfaceSupport(
        [NativeTypeName("const GUID &")] Ref<Guid> InterfaceName,
        Ref<LargeInteger> pUMDVersion
    )
    {
        fixed (LargeInteger* __dsl_pUMDVersion = pUMDVersion)
        fixed (Guid* __dsl_InterfaceName = InterfaceName)
        {
            return (HResult)CheckInterfaceSupport(__dsl_InterfaceName, __dsl_pUMDVersion);
        }
    }

    /// <inheritdoc cref = "IdxgiAdapter.EnumOutputs"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult EnumOutputs(uint Output, IdxgiOutput* ppOutput) =>
        LpVtbl->EnumOutputs(Output, ppOutput);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult EnumOutputs(uint Output, Ref<IdxgiOutput> ppOutput)
    {
        fixed (IdxgiOutput* __dsl_ppOutput = ppOutput)
        {
            return (HResult)EnumOutputs(Output, __dsl_ppOutput);
        }
    }

    /// <inheritdoc cref = "IdxgiAdapter.GetDesc"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDesc(DxgiAdapterDesc* pDesc) => LpVtbl->GetDesc(pDesc);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<DxgiAdapterDesc> pDesc)
    {
        fixed (DxgiAdapterDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiAdapter1.GetDesc1"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult GetDesc1(DxgiAdapterDesc1* pDesc) => LpVtbl->GetDesc1(pDesc);

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc1(Ref<DxgiAdapterDesc1> pDesc)
    {
        fixed (DxgiAdapterDesc1* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc1(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiAdapter2.GetDesc2"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetDesc2(DxgiAdapterDesc2* pDesc) => LpVtbl->GetDesc2(pDesc);

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc2(Ref<DxgiAdapterDesc2> pDesc)
    {
        fixed (DxgiAdapterDesc2* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc2(__dsl_pDesc);
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

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.QueryVideoMemoryInfo"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult QueryVideoMemoryInfo(
        uint NodeIndex,
        DxgiMemorySegmentGroup MemorySegmentGroup,
        DxgiQueryVideoMemoryInfo* pVideoMemoryInfo
    ) => LpVtbl->QueryVideoMemoryInfo(NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryVideoMemoryInfo(
        uint NodeIndex,
        DxgiMemorySegmentGroup MemorySegmentGroup,
        Ref<DxgiQueryVideoMemoryInfo> pVideoMemoryInfo
    )
    {
        fixed (DxgiQueryVideoMemoryInfo* __dsl_pVideoMemoryInfo = pVideoMemoryInfo)
        {
            return (HResult)QueryVideoMemoryInfo(
                NodeIndex,
                MemorySegmentGroup,
                __dsl_pVideoMemoryInfo
            );
        }
    }

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.RegisterHardwareContentProtectionTeardownStatusEvent"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult RegisterHardwareContentProtectionTeardownStatusEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    ) => LpVtbl->RegisterHardwareContentProtectionTeardownStatusEvent(hEvent, pdwCookie);

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterHardwareContentProtectionTeardownStatusEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
    )
    {
        fixed (uint* __dsl_pdwCookie = pdwCookie)
        {
            return (HResult)RegisterHardwareContentProtectionTeardownStatusEvent(
                hEvent,
                __dsl_pdwCookie
            );
        }
    }

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.RegisterVideoMemoryBudgetChangeNotificationEvent"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult RegisterVideoMemoryBudgetChangeNotificationEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    ) => LpVtbl->RegisterVideoMemoryBudgetChangeNotificationEvent(hEvent, pdwCookie);

    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult RegisterVideoMemoryBudgetChangeNotificationEvent(
        Handle hEvent,
        [NativeTypeName("DWORD *")] Ref<uint> pdwCookie
    )
    {
        fixed (uint* __dsl_pdwCookie = pdwCookie)
        {
            return (HResult)RegisterVideoMemoryBudgetChangeNotificationEvent(
                hEvent,
                __dsl_pdwCookie
            );
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

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.SetVideoMemoryReservation"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult SetVideoMemoryReservation(
        uint NodeIndex,
        DxgiMemorySegmentGroup MemorySegmentGroup,
        [NativeTypeName("UINT64")] ulong Reservation
    ) => LpVtbl->SetVideoMemoryReservation(NodeIndex, MemorySegmentGroup, Reservation);

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.UnregisterHardwareContentProtectionTeardownStatus"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void UnregisterHardwareContentProtectionTeardownStatus(
        [NativeTypeName("DWORD")] uint dwCookie
    ) => LpVtbl->UnregisterHardwareContentProtectionTeardownStatus(dwCookie);

    /// <include file='IDXGIAdapter3.xml' path='doc/member[@name="IDXGIAdapter3.UnregisterVideoMemoryBudgetChangeNotification"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void UnregisterVideoMemoryBudgetChangeNotification(
        [NativeTypeName("DWORD")] uint dwCookie
    ) => LpVtbl->UnregisterVideoMemoryBudgetChangeNotification(dwCookie);
}
