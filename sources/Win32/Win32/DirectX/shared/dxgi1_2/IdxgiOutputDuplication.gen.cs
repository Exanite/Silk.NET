// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication"]/*'/>
[Guid("191CFAC3-A341-470D-B26E-A864F428319C")]
[NativeTypeName("struct IDXGIOutputDuplication : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IdxgiOutputDuplication : IdxgiOutputDuplication.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiOutputDuplication));

    public interface Interface : IdxgiObject.Interface
    {
        [VtblIndex(8)]
        HResult AcquireNextFrame(
            uint TimeoutInMilliseconds,
            DxgiOutduplFrameInfo* pFrameInfo,
            IdxgiResource* ppDesktopResource
        );

        [VtblIndex(8)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult AcquireNextFrame(
            uint TimeoutInMilliseconds,
            Ref<DxgiOutduplFrameInfo> pFrameInfo,
            Ref<IdxgiResource> ppDesktopResource
        );

        [VtblIndex(7)]
        void GetDesc(DxgiOutduplDesc* pDesc);

        [VtblIndex(7)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        void GetDesc(Ref<DxgiOutduplDesc> pDesc);

        [VtblIndex(9)]
        HResult GetFrameDirtyRects(
            uint DirtyRectsBufferSize,
            RECT* pDirtyRectsBuffer,
            uint* pDirtyRectsBufferSizeRequired
        );

        [VtblIndex(9)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFrameDirtyRects(
            uint DirtyRectsBufferSize,
            Ref<RECT> pDirtyRectsBuffer,
            Ref<uint> pDirtyRectsBufferSizeRequired
        );

        [VtblIndex(10)]
        HResult GetFrameMoveRects(
            uint MoveRectsBufferSize,
            DxgiOutduplMoveRect* pMoveRectBuffer,
            uint* pMoveRectsBufferSizeRequired
        );

        [VtblIndex(10)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFrameMoveRects(
            uint MoveRectsBufferSize,
            Ref<DxgiOutduplMoveRect> pMoveRectBuffer,
            Ref<uint> pMoveRectsBufferSizeRequired
        );

        [VtblIndex(11)]
        HResult GetFramePointerShape(
            uint PointerShapeBufferSize,
            void* pPointerShapeBuffer,
            uint* pPointerShapeBufferSizeRequired,
            DxgiOutduplPointerShapeInfo* pPointerShapeInfo
        );

        [VtblIndex(11)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFramePointerShape(
            uint PointerShapeBufferSize,
            Ref pPointerShapeBuffer,
            Ref<uint> pPointerShapeBufferSizeRequired,
            Ref<DxgiOutduplPointerShapeInfo> pPointerShapeInfo
        );

        [VtblIndex(12)]
        HResult MapDesktopSurface(DxgiMappedRect* pLockedRect);

        [VtblIndex(12)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult MapDesktopSurface(Ref<DxgiMappedRect> pLockedRect);

        [VtblIndex(14)]
        HResult ReleaseFrame();

        [VtblIndex(13)]
        HResult UnMapDesktopSurface();
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication"]/*'/>

    [Guid("191CFAC3-A341-470D-B26E-A864F428319C")]
    [NativeTypeName("struct IDXGIOutputDuplication : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    [SupportedOSPlatform("windows6.2")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiOutputDuplication));
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

            [NativeTypeName("void (DXGI_OUTDUPL_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiOutduplDesc*, void> GetDesc;

            [NativeTypeName(
                "HRESULT (UINT, DXGI_OUTDUPL_FRAME_INFO *, IDXGIResource **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                DxgiOutduplFrameInfo*,
                IdxgiResource.Native**,
                HResult> AcquireNextFrame;

            [NativeTypeName("HRESULT (UINT, RECT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, RECT*, uint*, HResult> GetFrameDirtyRects;

            [NativeTypeName(
                "HRESULT (UINT, DXGI_OUTDUPL_MOVE_RECT *, UINT *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                DxgiOutduplMoveRect*,
                uint*,
                HResult> GetFrameMoveRects;

            [NativeTypeName(
                "HRESULT (UINT, void *, UINT *, DXGI_OUTDUPL_POINTER_SHAPE_INFO *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                void*,
                uint*,
                DxgiOutduplPointerShapeInfo*,
                HResult> GetFramePointerShape;

            [NativeTypeName("HRESULT (DXGI_MAPPED_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiMappedRect*, HResult> MapDesktopSurface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> UnMapDesktopSurface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> ReleaseFrame;
        }

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.AcquireNextFrame"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult AcquireNextFrame(
            uint TimeoutInMilliseconds,
            DxgiOutduplFrameInfo* pFrameInfo,
            IdxgiResource* ppDesktopResource
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutputDuplication.Native*,
                    uint,
                    DxgiOutduplFrameInfo*,
                    IdxgiResource.Native**,
                    HResult>)(lpVtbl[8])
            )(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this),
                TimeoutInMilliseconds,
                pFrameInfo,
                &ppDesktopResource->LpVtbl
            );
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult AcquireNextFrame(
            uint TimeoutInMilliseconds,
            Ref<DxgiOutduplFrameInfo> pFrameInfo,
            Ref<IdxgiResource> ppDesktopResource
        )
        {
            fixed (IdxgiResource* __dsl_ppDesktopResource = ppDesktopResource)
            fixed (DxgiOutduplFrameInfo* __dsl_pFrameInfo = pFrameInfo)
            {
                return (HResult)AcquireNextFrame(
                    TimeoutInMilliseconds,
                    __dsl_pFrameInfo,
                    __dsl_ppDesktopResource
                );
            }
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiOutputDuplication.Native*, uint>)(lpVtbl[1]))(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetDesc"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetDesc(DxgiOutduplDesc* pDesc)
        {
            (
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, DxgiOutduplDesc*, void>)(
                    lpVtbl[7]
                )
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetDesc(Ref<DxgiOutduplDesc> pDesc)
        {
            fixed (DxgiOutduplDesc* __dsl_pDesc = pDesc)
            {
                GetDesc(__dsl_pDesc);
            }
        }

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFrameDirtyRects"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetFrameDirtyRects(
            uint DirtyRectsBufferSize,
            RECT* pDirtyRectsBuffer,
            uint* pDirtyRectsBufferSizeRequired
        )
        {
            return (
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, uint, RECT*, uint*, HResult>)(
                    lpVtbl[9]
                )
            )(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this),
                DirtyRectsBufferSize,
                pDirtyRectsBuffer,
                pDirtyRectsBufferSizeRequired
            );
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFrameDirtyRects(
            uint DirtyRectsBufferSize,
            Ref<RECT> pDirtyRectsBuffer,
            Ref<uint> pDirtyRectsBufferSizeRequired
        )
        {
            fixed (uint* __dsl_pDirtyRectsBufferSizeRequired = pDirtyRectsBufferSizeRequired)
            fixed (RECT* __dsl_pDirtyRectsBuffer = pDirtyRectsBuffer)
            {
                return (HResult)GetFrameDirtyRects(
                    DirtyRectsBufferSize,
                    __dsl_pDirtyRectsBuffer,
                    __dsl_pDirtyRectsBufferSizeRequired
                );
            }
        }

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFrameMoveRects"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult GetFrameMoveRects(
            uint MoveRectsBufferSize,
            DxgiOutduplMoveRect* pMoveRectBuffer,
            uint* pMoveRectsBufferSizeRequired
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutputDuplication.Native*,
                    uint,
                    DxgiOutduplMoveRect*,
                    uint*,
                    HResult>)(lpVtbl[10])
            )(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this),
                MoveRectsBufferSize,
                pMoveRectBuffer,
                pMoveRectsBufferSizeRequired
            );
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFrameMoveRects(
            uint MoveRectsBufferSize,
            Ref<DxgiOutduplMoveRect> pMoveRectBuffer,
            Ref<uint> pMoveRectsBufferSizeRequired
        )
        {
            fixed (uint* __dsl_pMoveRectsBufferSizeRequired = pMoveRectsBufferSizeRequired)
            fixed (DxgiOutduplMoveRect* __dsl_pMoveRectBuffer = pMoveRectBuffer)
            {
                return (HResult)GetFrameMoveRects(
                    MoveRectsBufferSize,
                    __dsl_pMoveRectBuffer,
                    __dsl_pMoveRectsBufferSizeRequired
                );
            }
        }

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFramePointerShape"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetFramePointerShape(
            uint PointerShapeBufferSize,
            void* pPointerShapeBuffer,
            uint* pPointerShapeBufferSizeRequired,
            DxgiOutduplPointerShapeInfo* pPointerShapeInfo
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiOutputDuplication.Native*,
                    uint,
                    void*,
                    uint*,
                    DxgiOutduplPointerShapeInfo*,
                    HResult>)(lpVtbl[11])
            )(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this),
                PointerShapeBufferSize,
                pPointerShapeBuffer,
                pPointerShapeBufferSizeRequired,
                pPointerShapeInfo
            );
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFramePointerShape(
            uint PointerShapeBufferSize,
            Ref pPointerShapeBuffer,
            Ref<uint> pPointerShapeBufferSizeRequired,
            Ref<DxgiOutduplPointerShapeInfo> pPointerShapeInfo
        )
        {
            fixed (DxgiOutduplPointerShapeInfo* __dsl_pPointerShapeInfo = pPointerShapeInfo)
            fixed (uint* __dsl_pPointerShapeBufferSizeRequired = pPointerShapeBufferSizeRequired)
            fixed (void* __dsl_pPointerShapeBuffer = pPointerShapeBuffer)
            {
                return (HResult)GetFramePointerShape(
                    PointerShapeBufferSize,
                    __dsl_pPointerShapeBuffer,
                    __dsl_pPointerShapeBufferSizeRequired,
                    __dsl_pPointerShapeInfo
                );
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, Guid*, void**, HResult>)(
                    lpVtbl[6]
                )
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.MapDesktopSurface"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult MapDesktopSurface(DxgiMappedRect* pLockedRect)
        {
            return (
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, DxgiMappedRect*, HResult>)(
                    lpVtbl[12]
                )
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), pLockedRect);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult MapDesktopSurface(Ref<DxgiMappedRect> pLockedRect)
        {
            fixed (DxgiMappedRect* __dsl_pLockedRect = pLockedRect)
            {
                return (HResult)MapDesktopSurface(__dsl_pLockedRect);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, Guid*, void**, HResult>)(
                    lpVtbl[0]
                )
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiOutputDuplication.Native*, uint>)(lpVtbl[2]))(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.ReleaseFrame"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult ReleaseFrame()
        {
            return ((delegate* unmanaged<IdxgiOutputDuplication.Native*, HResult>)(lpVtbl[14]))(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this)
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
                (delegate* unmanaged<IdxgiOutputDuplication.Native*, Guid*, uint, void*, HResult>)(
                    lpVtbl[3]
                )
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<
                    IdxgiOutputDuplication.Native*,
                    Guid*,
                    IUnknown.Native*,
                    HResult>)(lpVtbl[4])
            )((IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.UnMapDesktopSurface"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult UnMapDesktopSurface()
        {
            return ((delegate* unmanaged<IdxgiOutputDuplication.Native*, HResult>)(lpVtbl[13]))(
                (IdxgiOutputDuplication.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiOutputDuplication"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiOutputDuplication(Ptr3D vtbl) => LpVtbl = (IdxgiOutputDuplication.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiOutputDuplication"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiOutputDuplication(Ptr<IdxgiOutputDuplication.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiOutputDuplication.Native"/> to <see cref = "IdxgiOutputDuplication"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutputDuplication.Native"/> instance to be converted </param>

    public static implicit operator IdxgiOutputDuplication(IdxgiOutputDuplication.Native* value) =>
        new IdxgiOutputDuplication((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiOutputDuplication"/> to <see cref = "IdxgiOutputDuplication.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutputDuplication"/> instance to be converted </param>

    public static implicit operator IdxgiOutputDuplication.Native*(IdxgiOutputDuplication value) =>
        value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiOutputDuplication"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiOutputDuplication(Ptr3D value) =>
        new IdxgiOutputDuplication(value);

    /// <summary>casts <see cref = "IdxgiOutputDuplication"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutputDuplication"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiOutputDuplication value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiOutputDuplication"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiOutputDuplication(
        Ptr<IdxgiOutputDuplication.Native> value
    ) => new IdxgiOutputDuplication(value);

    /// <summary>casts <see cref = "IdxgiOutputDuplication"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutputDuplication"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiOutputDuplication.Native>(
        IdxgiOutputDuplication value
    ) => (Ptr<IdxgiOutputDuplication.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiOutputDuplication"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiOutputDuplication(void*** value) =>
        new IdxgiOutputDuplication((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiOutputDuplication"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiOutputDuplication"/> instance to be converted </param>

    public static implicit operator void***(IdxgiOutputDuplication value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiOutputDuplication"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiOutputDuplication(nuint value) =>
        new IdxgiOutputDuplication((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiOutputDuplication"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiOutputDuplication"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiOutputDuplication value) => (nuint)value.LpVtbl;

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.AcquireNextFrame"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult AcquireNextFrame(
        uint TimeoutInMilliseconds,
        DxgiOutduplFrameInfo* pFrameInfo,
        IdxgiResource* ppDesktopResource
    ) => LpVtbl->AcquireNextFrame(TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult AcquireNextFrame(
        uint TimeoutInMilliseconds,
        Ref<DxgiOutduplFrameInfo> pFrameInfo,
        Ref<IdxgiResource> ppDesktopResource
    )
    {
        fixed (IdxgiResource* __dsl_ppDesktopResource = ppDesktopResource)
        fixed (DxgiOutduplFrameInfo* __dsl_pFrameInfo = pFrameInfo)
        {
            return (HResult)AcquireNextFrame(
                TimeoutInMilliseconds,
                __dsl_pFrameInfo,
                __dsl_ppDesktopResource
            );
        }
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetDesc"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDesc(DxgiOutduplDesc* pDesc) => LpVtbl->GetDesc(pDesc);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void GetDesc(Ref<DxgiOutduplDesc> pDesc)
    {
        fixed (DxgiOutduplDesc* __dsl_pDesc = pDesc)
        {
            GetDesc(__dsl_pDesc);
        }
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFrameDirtyRects"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetFrameDirtyRects(
        uint DirtyRectsBufferSize,
        RECT* pDirtyRectsBuffer,
        uint* pDirtyRectsBufferSizeRequired
    ) =>
        LpVtbl->GetFrameDirtyRects(
            DirtyRectsBufferSize,
            pDirtyRectsBuffer,
            pDirtyRectsBufferSizeRequired
        );

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFrameDirtyRects(
        uint DirtyRectsBufferSize,
        Ref<RECT> pDirtyRectsBuffer,
        Ref<uint> pDirtyRectsBufferSizeRequired
    )
    {
        fixed (uint* __dsl_pDirtyRectsBufferSizeRequired = pDirtyRectsBufferSizeRequired)
        fixed (RECT* __dsl_pDirtyRectsBuffer = pDirtyRectsBuffer)
        {
            return (HResult)GetFrameDirtyRects(
                DirtyRectsBufferSize,
                __dsl_pDirtyRectsBuffer,
                __dsl_pDirtyRectsBufferSizeRequired
            );
        }
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFrameMoveRects"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult GetFrameMoveRects(
        uint MoveRectsBufferSize,
        DxgiOutduplMoveRect* pMoveRectBuffer,
        uint* pMoveRectsBufferSizeRequired
    ) =>
        LpVtbl->GetFrameMoveRects(
            MoveRectsBufferSize,
            pMoveRectBuffer,
            pMoveRectsBufferSizeRequired
        );

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFrameMoveRects(
        uint MoveRectsBufferSize,
        Ref<DxgiOutduplMoveRect> pMoveRectBuffer,
        Ref<uint> pMoveRectsBufferSizeRequired
    )
    {
        fixed (uint* __dsl_pMoveRectsBufferSizeRequired = pMoveRectsBufferSizeRequired)
        fixed (DxgiOutduplMoveRect* __dsl_pMoveRectBuffer = pMoveRectBuffer)
        {
            return (HResult)GetFrameMoveRects(
                MoveRectsBufferSize,
                __dsl_pMoveRectBuffer,
                __dsl_pMoveRectsBufferSizeRequired
            );
        }
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFramePointerShape"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetFramePointerShape(
        uint PointerShapeBufferSize,
        void* pPointerShapeBuffer,
        uint* pPointerShapeBufferSizeRequired,
        DxgiOutduplPointerShapeInfo* pPointerShapeInfo
    ) =>
        LpVtbl->GetFramePointerShape(
            PointerShapeBufferSize,
            pPointerShapeBuffer,
            pPointerShapeBufferSizeRequired,
            pPointerShapeInfo
        );

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFramePointerShape(
        uint PointerShapeBufferSize,
        Ref pPointerShapeBuffer,
        Ref<uint> pPointerShapeBufferSizeRequired,
        Ref<DxgiOutduplPointerShapeInfo> pPointerShapeInfo
    )
    {
        fixed (DxgiOutduplPointerShapeInfo* __dsl_pPointerShapeInfo = pPointerShapeInfo)
        fixed (uint* __dsl_pPointerShapeBufferSizeRequired = pPointerShapeBufferSizeRequired)
        fixed (void* __dsl_pPointerShapeBuffer = pPointerShapeBuffer)
        {
            return (HResult)GetFramePointerShape(
                PointerShapeBufferSize,
                __dsl_pPointerShapeBuffer,
                __dsl_pPointerShapeBufferSizeRequired,
                __dsl_pPointerShapeInfo
            );
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

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.MapDesktopSurface"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult MapDesktopSurface(DxgiMappedRect* pLockedRect) =>
        LpVtbl->MapDesktopSurface(pLockedRect);

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult MapDesktopSurface(Ref<DxgiMappedRect> pLockedRect)
    {
        fixed (DxgiMappedRect* __dsl_pLockedRect = pLockedRect)
        {
            return (HResult)MapDesktopSurface(__dsl_pLockedRect);
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

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.ReleaseFrame"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult ReleaseFrame() => LpVtbl->ReleaseFrame();

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

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.UnMapDesktopSurface"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult UnMapDesktopSurface() => LpVtbl->UnMapDesktopSurface();
}
