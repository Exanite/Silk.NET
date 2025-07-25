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

/// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain"]/*'/>
[Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
[NativeTypeName("struct IDXGIDecodeSwapChain : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IdxgiDecodeSwapChain : IdxgiDecodeSwapChain.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDecodeSwapChain));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(11)]
        DXGIMultiplaneOverlayYCbCrFlags GetColorSpace();

        [VtblIndex(9)]
        HResult GetDestSize(uint* pWidth, uint* pHeight);

        [VtblIndex(9)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDestSize(Ref<uint> pWidth, Ref<uint> pHeight);

        [VtblIndex(7)]
        HResult GetSourceRect(RECT* pRect);

        [VtblIndex(7)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetSourceRect(Ref<RECT> pRect);

        [VtblIndex(8)]
        HResult GetTargetRect(RECT* pRect);

        [VtblIndex(8)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetTargetRect(Ref<RECT> pRect);

        [VtblIndex(3)]
        HResult PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags);

        [VtblIndex(10)]
        HResult SetColorSpace(DXGIMultiplaneOverlayYCbCrFlags ColorSpace);

        [VtblIndex(6)]
        HResult SetDestSize(uint Width, uint Height);

        [VtblIndex(4)]
        HResult SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect);

        [VtblIndex(4)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult SetSourceRect([NativeTypeName("const RECT *")] Ref<RECT> pRect);

        [VtblIndex(5)]
        HResult SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect);

        [VtblIndex(5)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult SetTargetRect([NativeTypeName("const RECT *")] Ref<RECT> pRect);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain"]/*'/>

    [Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
    [NativeTypeName("struct IDXGIDecodeSwapChain : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows6.3")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDecodeSwapChain));
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

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, HResult> PresentBuffer;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> SetSourceRect;

            [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> SetTargetRect;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, HResult> SetDestSize;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> GetSourceRect;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> GetTargetRect;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, uint*, HResult> GetDestSize;

            [NativeTypeName(
                "HRESULT (DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DXGIMultiplaneOverlayYCbCrFlags,
                HResult> SetColorSpace;

            [NativeTypeName("DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DXGIMultiplaneOverlayYCbCrFlags> GetColorSpace;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiDecodeSwapChain.Native*, uint>)(lpVtbl[1]))(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetColorSpace"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public DXGIMultiplaneOverlayYCbCrFlags GetColorSpace()
        {
            return (
                (delegate* unmanaged<
                    IdxgiDecodeSwapChain.Native*,
                    DXGIMultiplaneOverlayYCbCrFlags>)(lpVtbl[11])
            )((IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetDestSize"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetDestSize(uint* pWidth, uint* pHeight)
        {
            return (
                (delegate* unmanaged<IdxgiDecodeSwapChain.Native*, uint*, uint*, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDestSize(Ref<uint> pWidth, Ref<uint> pHeight)
        {
            fixed (uint* __dsl_pHeight = pHeight)
            fixed (uint* __dsl_pWidth = pWidth)
            {
                return (HResult)GetDestSize(__dsl_pWidth, __dsl_pHeight);
            }
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetSourceRect"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetSourceRect(RECT* pRect)
        {
            return ((delegate* unmanaged<IdxgiDecodeSwapChain.Native*, RECT*, HResult>)(lpVtbl[7]))(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this),
                pRect
            );
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetSourceRect(Ref<RECT> pRect)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)GetSourceRect(__dsl_pRect);
            }
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetTargetRect"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetTargetRect(RECT* pRect)
        {
            return ((delegate* unmanaged<IdxgiDecodeSwapChain.Native*, RECT*, HResult>)(lpVtbl[8]))(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this),
                pRect
            );
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetTargetRect(Ref<RECT> pRect)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)GetTargetRect(__dsl_pRect);
            }
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.PresentBuffer"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags)
        {
            return (
                (delegate* unmanaged<IdxgiDecodeSwapChain.Native*, uint, uint, uint, HResult>)(
                    lpVtbl[3]
                )
            )(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this),
                BufferToPresent,
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
                (delegate* unmanaged<IdxgiDecodeSwapChain.Native*, Guid*, void**, HResult>)(
                    lpVtbl[0]
                )
            )((IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiDecodeSwapChain.Native*, uint>)(lpVtbl[2]))(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetColorSpace"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult SetColorSpace(DXGIMultiplaneOverlayYCbCrFlags ColorSpace)
        {
            return (
                (delegate* unmanaged<
                    IdxgiDecodeSwapChain.Native*,
                    DXGIMultiplaneOverlayYCbCrFlags,
                    HResult>)(lpVtbl[10])
            )((IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this), ColorSpace);
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetDestSize"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetDestSize(uint Width, uint Height)
        {
            return (
                (delegate* unmanaged<IdxgiDecodeSwapChain.Native*, uint, uint, HResult>)(lpVtbl[6])
            )((IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this), Width, Height);
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetSourceRect"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IdxgiDecodeSwapChain.Native*, RECT*, HResult>)(lpVtbl[4]))(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this),
                pRect
            );
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetSourceRect([NativeTypeName("const RECT *")] Ref<RECT> pRect)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)SetSourceRect(__dsl_pRect);
            }
        }

        /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetTargetRect"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect)
        {
            return ((delegate* unmanaged<IdxgiDecodeSwapChain.Native*, RECT*, HResult>)(lpVtbl[5]))(
                (IdxgiDecodeSwapChain.Native*)Unsafe.AsPointer(ref this),
                pRect
            );
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetTargetRect([NativeTypeName("const RECT *")] Ref<RECT> pRect)
        {
            fixed (RECT* __dsl_pRect = pRect)
            {
                return (HResult)SetTargetRect(__dsl_pRect);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDecodeSwapChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDecodeSwapChain(Ptr3D vtbl) => LpVtbl = (IdxgiDecodeSwapChain.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDecodeSwapChain"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDecodeSwapChain(Ptr<IdxgiDecodeSwapChain.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiDecodeSwapChain.Native"/> to <see cref = "IdxgiDecodeSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiDecodeSwapChain.Native"/> instance to be converted </param>

    public static implicit operator IdxgiDecodeSwapChain(IdxgiDecodeSwapChain.Native* value) =>
        new IdxgiDecodeSwapChain((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDecodeSwapChain"/> to <see cref = "IdxgiDecodeSwapChain.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDecodeSwapChain"/> instance to be converted </param>

    public static implicit operator IdxgiDecodeSwapChain.Native*(IdxgiDecodeSwapChain value) =>
        value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiDecodeSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiDecodeSwapChain(Ptr3D value) =>
        new IdxgiDecodeSwapChain(value);

    /// <summary>casts <see cref = "IdxgiDecodeSwapChain"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDecodeSwapChain"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiDecodeSwapChain value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiDecodeSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiDecodeSwapChain(Ptr<IdxgiDecodeSwapChain.Native> value) =>
        new IdxgiDecodeSwapChain(value);

    /// <summary>casts <see cref = "IdxgiDecodeSwapChain"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDecodeSwapChain"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiDecodeSwapChain.Native>(IdxgiDecodeSwapChain value) =>
        (Ptr<IdxgiDecodeSwapChain.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiDecodeSwapChain"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiDecodeSwapChain(void*** value) =>
        new IdxgiDecodeSwapChain((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDecodeSwapChain"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDecodeSwapChain"/> instance to be converted </param>

    public static implicit operator void***(IdxgiDecodeSwapChain value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiDecodeSwapChain"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiDecodeSwapChain(nuint value) =>
        new IdxgiDecodeSwapChain((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiDecodeSwapChain"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDecodeSwapChain"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiDecodeSwapChain value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetColorSpace"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DXGIMultiplaneOverlayYCbCrFlags GetColorSpace() => LpVtbl->GetColorSpace();

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetDestSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetDestSize(uint* pWidth, uint* pHeight) => LpVtbl->GetDestSize(pWidth, pHeight);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDestSize(Ref<uint> pWidth, Ref<uint> pHeight)
    {
        fixed (uint* __dsl_pHeight = pHeight)
        fixed (uint* __dsl_pWidth = pWidth)
        {
            return (HResult)GetDestSize(__dsl_pWidth, __dsl_pHeight);
        }
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetSourceRect"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetSourceRect(RECT* pRect) => LpVtbl->GetSourceRect(pRect);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSourceRect(Ref<RECT> pRect)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)GetSourceRect(__dsl_pRect);
        }
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetTargetRect"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetTargetRect(RECT* pRect) => LpVtbl->GetTargetRect(pRect);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTargetRect(Ref<RECT> pRect)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)GetTargetRect(__dsl_pRect);
        }
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.PresentBuffer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags) =>
        LpVtbl->PresentBuffer(BufferToPresent, SyncInterval, Flags);

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

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetColorSpace"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult SetColorSpace(DXGIMultiplaneOverlayYCbCrFlags ColorSpace) =>
        LpVtbl->SetColorSpace(ColorSpace);

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetDestSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult SetDestSize(uint Width, uint Height) => LpVtbl->SetDestSize(Width, Height);

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetSourceRect"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect) =>
        LpVtbl->SetSourceRect(pRect);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetSourceRect([NativeTypeName("const RECT *")] Ref<RECT> pRect)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)SetSourceRect(__dsl_pRect);
        }
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetTargetRect"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect) =>
        LpVtbl->SetTargetRect(pRect);

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetTargetRect([NativeTypeName("const RECT *")] Ref<RECT> pRect)
    {
        fixed (RECT* __dsl_pRect = pRect)
        {
            return (HResult)SetTargetRect(__dsl_pRect);
        }
    }
}
