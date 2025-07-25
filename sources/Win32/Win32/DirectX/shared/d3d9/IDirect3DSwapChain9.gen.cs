// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9"]/*'/>
[Guid("794950F2-ADFC-458A-905E-10A10B0B503B")]
[NativeTypeName("struct IDirect3DSwapChain9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DSwapChain9 : IDirect3DSwapChain9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DSwapChain9));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(5)]
        HResult GetBackBuffer(uint iBackBuffer, D3DbackbufferType Type, IDirect3DSurface9* ppBackBuffer);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetBackBuffer(uint iBackBuffer, D3DbackbufferType Type, Ref<IDirect3DSurface9> ppBackBuffer);
        [VtblIndex(8)]
        HResult GetDevice(IDirect3DDevice9* ppDevice);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDevice(Ref<IDirect3DDevice9> ppDevice);
        [VtblIndex(7)]
        HResult GetDisplayMode(D3Ddisplaymode* pMode);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDisplayMode(Ref<D3Ddisplaymode> pMode);
        [VtblIndex(4)]
        HResult GetFrontBufferData(IDirect3DSurface9 pDestSurface);
        [VtblIndex(9)]
        HResult GetPresentParameters(D3DpresentParameters* pPresentationParameters);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPresentParameters(Ref<D3DpresentParameters> pPresentationParameters);
        [VtblIndex(6)]
        HResult GetRasterStatus(D3DrasterStatus* pRasterStatus);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetRasterStatus(Ref<D3DrasterStatus> pRasterStatus);
        [VtblIndex(3)]
        HResult Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Present([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9"]/*'/>
    [Guid("794950F2-ADFC-458A-905E-10A10B0B503B")]
    [NativeTypeName("struct IDirect3DSwapChain9 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DSwapChain9));

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
            [NativeTypeName("HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, RECT*, HWND, RGNDATA*, uint, HResult> Present;
            [NativeTypeName("HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DSurface9.Native*, HResult> GetFrontBufferData;
            [NativeTypeName("HRESULT (UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3DbackbufferType, IDirect3DSurface9.Native**, HResult> GetBackBuffer;
            [NativeTypeName("HRESULT (D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DrasterStatus*, HResult> GetRasterStatus;
            [NativeTypeName("HRESULT (D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Ddisplaymode*, HResult> GetDisplayMode;
            [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DDevice9.Native**, HResult> GetDevice;
            [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DpresentParameters*, HResult> GetPresentParameters;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, uint> )(lpVtbl[1]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetBackBuffer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetBackBuffer(uint iBackBuffer, D3DbackbufferType Type, IDirect3DSurface9* ppBackBuffer)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, uint, D3DbackbufferType, IDirect3DSurface9.Native**, HResult> )(lpVtbl[5]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), iBackBuffer, Type, &ppBackBuffer->LpVtbl);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetBackBuffer(uint iBackBuffer, D3DbackbufferType Type, Ref<IDirect3DSurface9> ppBackBuffer)
        {
            fixed (IDirect3DSurface9* __dsl_ppBackBuffer = ppBackBuffer)
            {
                return (HResult)GetBackBuffer(iBackBuffer, Type, __dsl_ppBackBuffer);
            }
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDevice"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[8]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
        {
            fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
            {
                return (HResult)GetDevice(__dsl_ppDevice);
            }
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDisplayMode"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDisplayMode(D3Ddisplaymode* pMode)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, D3Ddisplaymode*, HResult> )(lpVtbl[7]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), pMode);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDisplayMode(Ref<D3Ddisplaymode> pMode)
        {
            fixed (D3Ddisplaymode* __dsl_pMode = pMode)
            {
                return (HResult)GetDisplayMode(__dsl_pMode);
            }
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetFrontBufferData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetFrontBufferData(IDirect3DSurface9 pDestSurface)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, IDirect3DSurface9.Native*, HResult> )(lpVtbl[4]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), pDestSurface.LpVtbl);
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetPresentParameters"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult GetPresentParameters(D3DpresentParameters* pPresentationParameters)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, D3DpresentParameters*, HResult> )(lpVtbl[9]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), pPresentationParameters);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPresentParameters(Ref<D3DpresentParameters> pPresentationParameters)
        {
            fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
            {
                return (HResult)GetPresentParameters(__dsl_pPresentationParameters);
            }
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetRasterStatus"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetRasterStatus(D3DrasterStatus* pRasterStatus)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, D3DrasterStatus*, HResult> )(lpVtbl[6]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), pRasterStatus);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetRasterStatus(Ref<D3DrasterStatus> pRasterStatus)
        {
            fixed (D3DrasterStatus* __dsl_pRasterStatus = pRasterStatus)
            {
                return (HResult)GetRasterStatus(__dsl_pRasterStatus);
            }
        }

        /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.Present"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, RECT*, RECT*, HWND, RGNDATA*, uint, HResult> )(lpVtbl[3]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Present([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
        {
            fixed (RGNDATA* __dsl_pDirtyRegion = pDirtyRegion)
            fixed (RECT* __dsl_pDestRect = pDestRect)
            fixed (RECT* __dsl_pSourceRect = pSourceRect)
            {
                return (HResult)Present(__dsl_pSourceRect, __dsl_pDestRect, hDestWindowOverride, __dsl_pDirtyRegion, dwFlags);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

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
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DSwapChain9.Native*, uint> )(lpVtbl[2]))((IDirect3DSwapChain9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DSwapChain9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DSwapChain9(Ptr3D vtbl) => LpVtbl = (IDirect3DSwapChain9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DSwapChain9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DSwapChain9(Ptr<IDirect3DSwapChain9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DSwapChain9.Native"/> to <see cref = "IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DSwapChain9(IDirect3DSwapChain9.Native* value) => new IDirect3DSwapChain9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DSwapChain9"/> to <see cref = "IDirect3DSwapChain9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9"/> instance to be converted </param>
    public static implicit operator IDirect3DSwapChain9.Native*(IDirect3DSwapChain9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9(Ptr3D value) => new IDirect3DSwapChain9(value);
    /// <summary>casts <see cref = "IDirect3DSwapChain9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DSwapChain9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9(Ptr<IDirect3DSwapChain9.Native> value) => new IDirect3DSwapChain9(value);
    /// <summary>casts <see cref = "IDirect3DSwapChain9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DSwapChain9.Native>(IDirect3DSwapChain9 value) => (Ptr<IDirect3DSwapChain9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9(void*** value) => new IDirect3DSwapChain9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DSwapChain9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DSwapChain9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DSwapChain9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DSwapChain9(nuint value) => new IDirect3DSwapChain9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DSwapChain9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DSwapChain9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DSwapChain9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetBackBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetBackBuffer(uint iBackBuffer, D3DbackbufferType Type, IDirect3DSurface9* ppBackBuffer) => LpVtbl->GetBackBuffer(iBackBuffer, Type, ppBackBuffer);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetBackBuffer(uint iBackBuffer, D3DbackbufferType Type, Ref<IDirect3DSurface9> ppBackBuffer)
    {
        fixed (IDirect3DSurface9* __dsl_ppBackBuffer = ppBackBuffer)
        {
            return (HResult)GetBackBuffer(iBackBuffer, Type, __dsl_ppBackBuffer);
        }
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDevice(IDirect3DDevice9* ppDevice) => LpVtbl->GetDevice(ppDevice);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
    {
        fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
        {
            return (HResult)GetDevice(__dsl_ppDevice);
        }
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDisplayMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDisplayMode(D3Ddisplaymode* pMode) => LpVtbl->GetDisplayMode(pMode);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDisplayMode(Ref<D3Ddisplaymode> pMode)
    {
        fixed (D3Ddisplaymode* __dsl_pMode = pMode)
        {
            return (HResult)GetDisplayMode(__dsl_pMode);
        }
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetFrontBufferData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetFrontBufferData(IDirect3DSurface9 pDestSurface) => LpVtbl->GetFrontBufferData(pDestSurface);
    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetPresentParameters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult GetPresentParameters(D3DpresentParameters* pPresentationParameters) => LpVtbl->GetPresentParameters(pPresentationParameters);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPresentParameters(Ref<D3DpresentParameters> pPresentationParameters)
    {
        fixed (D3DpresentParameters* __dsl_pPresentationParameters = pPresentationParameters)
        {
            return (HResult)GetPresentParameters(__dsl_pPresentationParameters);
        }
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetRasterStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetRasterStatus(D3DrasterStatus* pRasterStatus) => LpVtbl->GetRasterStatus(pRasterStatus);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetRasterStatus(Ref<D3DrasterStatus> pRasterStatus)
    {
        fixed (D3DrasterStatus* __dsl_pRasterStatus = pRasterStatus)
        {
            return (HResult)GetRasterStatus(__dsl_pRasterStatus);
        }
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.Present"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags) => LpVtbl->Present(pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Present([NativeTypeName("const RECT *")] Ref<RECT> pSourceRect, [NativeTypeName("const RECT *")] Ref<RECT> pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] Ref<RGNDATA> pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
    {
        fixed (RGNDATA* __dsl_pDirtyRegion = pDirtyRegion)
        fixed (RECT* __dsl_pDestRect = pDestRect)
        fixed (RECT* __dsl_pSourceRect = pSourceRect)
        {
            return (HResult)Present(__dsl_pSourceRect, __dsl_pDestRect, hDestWindowOverride, __dsl_pDirtyRegion, dwFlags);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => LpVtbl->QueryInterface(riid, ppvObject);
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
}