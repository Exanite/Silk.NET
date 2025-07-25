// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9"]/*'/>
[Guid("0CFBAF3A-9FF6-429A-99B3-A2796AF8B89B")]
[NativeTypeName("struct IDirect3DSurface9 : IDirect3DResource9")]
[NativeInheritance("IDirect3DResource9")]
public unsafe partial struct IDirect3DSurface9 : IDirect3DSurface9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DSurface9));

    public interface Interface : IDirect3DResource9.Interface
    {
        [VtblIndex(11)]
        HResult GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetContainer([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppContainer);
        [VtblIndex(15)]
        HResult GetDC(HDC* phdc);
        [VtblIndex(15)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDC(Ref<HDC> phdc);
        [VtblIndex(12)]
        HResult GetDesc(D3DsurfaceDesc* pDesc);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetDesc(Ref<D3DsurfaceDesc> pDesc);
        [VtblIndex(13)]
        HResult LockRect(D3DlockedRect* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(13)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult LockRect(Ref<D3DlockedRect> pLockedRect, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(16)]
        HResult ReleaseDC(HDC hdc);
        [VtblIndex(14)]
        HResult UnlockRect();
    }

    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9"]/*'/>
    [Guid("0CFBAF3A-9FF6-429A-99B3-A2796AF8B89B")]
    [NativeTypeName("struct IDirect3DSurface9 : IDirect3DResource9")]
    [NativeInheritance("IDirect3DResource9")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DSurface9));

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
            [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IDirect3DDevice9.Native**, HResult> GetDevice;
            [NativeTypeName("HRESULT (const GUID &, const void *, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void*, uint, uint, HResult> SetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void*, uint*, HResult> GetPrivateData;
            [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, HResult> FreePrivateData;
            [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint> SetPriority;
            [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetPriority;
            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> PreLoad;
            [NativeTypeName("D3DRESOURCETYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* unmanaged<TSelf*, D3Dresourcetype> GetType;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetContainer;
            [NativeTypeName("HRESULT (D3DSURFACE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DsurfaceDesc*, HResult> GetDesc;
            [NativeTypeName("HRESULT (D3DLOCKED_RECT *, const RECT *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DlockedRect*, RECT*, uint, HResult> LockRect;
            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> UnlockRect;
            [NativeTypeName("HRESULT (HDC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HDC*, HResult> GetDC;
            [NativeTypeName("HRESULT (HDC) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HDC, HResult> ReleaseDC;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, uint> )(lpVtbl[1]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DResource9.FreePrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, Guid*, HResult> )(lpVtbl[6]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), refguid);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult FreePrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid)
        {
            fixed (Guid* __dsl_refguid = refguid)
            {
                return (HResult)FreePrivateData(__dsl_refguid);
            }
        }

        /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.GetContainer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, Guid*, void**, HResult> )(lpVtbl[11]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), riid, ppContainer);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetContainer([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppContainer)
        {
            fixed (void** __dsl_ppContainer = ppContainer)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetContainer(__dsl_riid, __dsl_ppContainer);
            }
        }

        [VtblIndex(11)]
        [Transformed]
        public HResult GetContainer<TCom>(out TCom ppContainer)
            where TCom : unmanaged, IComVtbl
        {
            ppContainer = default;
            return GetContainer(TCom.NativeGuid, ppContainer.GetAddressOf());
        }

        /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.GetDC"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult GetDC(HDC* phdc)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, HDC*, HResult> )(lpVtbl[15]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), phdc);
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDC(Ref<HDC> phdc)
        {
            fixed (HDC* __dsl_phdc = phdc)
            {
                return (HResult)GetDC(__dsl_phdc);
            }
        }

        /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult GetDesc(D3DsurfaceDesc* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, D3DsurfaceDesc*, HResult> )(lpVtbl[12]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDesc(Ref<D3DsurfaceDesc> pDesc)
        {
            fixed (D3DsurfaceDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[3]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
        {
            fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
            {
                return (HResult)GetDevice(__dsl_ppDevice);
            }
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetPriority"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, uint> )(lpVtbl[8]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, Guid*, void*, uint*, HResult> )(lpVtbl[5]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, Ref pData, [NativeTypeName("DWORD *")] Ref<uint> pSizeOfData)
        {
            fixed (uint* __dsl_pSizeOfData = pSizeOfData)
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_refguid = refguid)
            {
                return (HResult)GetPrivateData(__dsl_refguid, __dsl_pData, __dsl_pSizeOfData);
            }
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public new D3Dresourcetype GetType()
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, D3Dresourcetype> )(lpVtbl[10]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.LockRect"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult LockRect(D3DlockedRect* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, D3DlockedRect*, RECT*, uint, HResult> )(lpVtbl[13]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), pLockedRect, pRect, Flags);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LockRect(Ref<D3DlockedRect> pLockedRect, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("DWORD")] uint Flags)
        {
            fixed (RECT* __dsl_pRect = pRect)
            fixed (D3DlockedRect* __dsl_pLockedRect = pLockedRect)
            {
                return (HResult)LockRect(__dsl_pLockedRect, __dsl_pRect, Flags);
            }
        }

        /// <inheritdoc cref = "IDirect3DResource9.PreLoad"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DSurface9.Native*, void> )(lpVtbl[9]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, uint> )(lpVtbl[2]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.ReleaseDC"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult ReleaseDC(HDC hdc)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, HDC, HResult> )(lpVtbl[16]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), hdc);
        }

        /// <inheritdoc cref = "IDirect3DResource9.SetPriority"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, uint, uint> )(lpVtbl[7]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        /// <inheritdoc cref = "IDirect3DResource9.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, Guid*, void*, uint, uint, HResult> )(lpVtbl[4]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, [NativeTypeName("const void *")] Ref pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_refguid = refguid)
            {
                return (HResult)SetPrivateData(__dsl_refguid, __dsl_pData, SizeOfData, Flags);
            }
        }

        /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.UnlockRect"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult UnlockRect()
        {
            return ((delegate* unmanaged<IDirect3DSurface9.Native*, HResult> )(lpVtbl[14]))((IDirect3DSurface9.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DSurface9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DSurface9(Ptr3D vtbl) => LpVtbl = (IDirect3DSurface9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DSurface9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DSurface9(Ptr<IDirect3DSurface9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DSurface9.Native"/> to <see cref = "IDirect3DSurface9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSurface9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DSurface9(IDirect3DSurface9.Native* value) => new IDirect3DSurface9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DSurface9"/> to <see cref = "IDirect3DSurface9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSurface9"/> instance to be converted </param>
    public static implicit operator IDirect3DSurface9.Native*(IDirect3DSurface9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DSurface9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DSurface9(Ptr3D value) => new IDirect3DSurface9(value);
    /// <summary>casts <see cref = "IDirect3DSurface9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DSurface9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DSurface9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DSurface9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DSurface9(Ptr<IDirect3DSurface9.Native> value) => new IDirect3DSurface9(value);
    /// <summary>casts <see cref = "IDirect3DSurface9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DSurface9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DSurface9.Native>(IDirect3DSurface9 value) => (Ptr<IDirect3DSurface9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DSurface9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DSurface9(void*** value) => new IDirect3DSurface9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DSurface9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DSurface9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DSurface9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DSurface9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DSurface9(nuint value) => new IDirect3DSurface9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DSurface9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DSurface9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DSurface9 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "IDirect3DResource9.FreePrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid) => LpVtbl->FreePrivateData(refguid);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult FreePrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid)
    {
        fixed (Guid* __dsl_refguid = refguid)
        {
            return (HResult)FreePrivateData(__dsl_refguid);
        }
    }

    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.GetContainer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetContainer([NativeTypeName("const IID &")] Guid* riid, void** ppContainer) => LpVtbl->GetContainer(riid, ppContainer);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetContainer([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppContainer)
    {
        fixed (void** __dsl_ppContainer = ppContainer)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetContainer(__dsl_riid, __dsl_ppContainer);
        }
    }

    [VtblIndex(11)]
    [Transformed]
    public HResult GetContainer<TCom>(out TCom ppContainer)
        where TCom : unmanaged, IComVtbl
    {
        ppContainer = default;
        return GetContainer(TCom.NativeGuid, ppContainer.GetAddressOf());
    }

    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.GetDC"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult GetDC(HDC* phdc) => LpVtbl->GetDC(phdc);
    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDC(Ref<HDC> phdc)
    {
        fixed (HDC* __dsl_phdc = phdc)
        {
            return (HResult)GetDC(__dsl_phdc);
        }
    }

    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult GetDesc(D3DsurfaceDesc* pDesc) => LpVtbl->GetDesc(pDesc);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<D3DsurfaceDesc> pDesc)
    {
        fixed (D3DsurfaceDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IDirect3DResource9.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetDevice(IDirect3DDevice9* ppDevice) => LpVtbl->GetDevice(ppDevice);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice(Ref<IDirect3DDevice9> ppDevice)
    {
        fixed (IDirect3DDevice9* __dsl_ppDevice = ppDevice)
        {
            return (HResult)GetDevice(__dsl_ppDevice);
        }
    }

    /// <inheritdoc cref = "IDirect3DResource9.GetPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("DWORD")]
    public uint GetPriority() => LpVtbl->GetPriority();
    /// <inheritdoc cref = "IDirect3DResource9.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData) => LpVtbl->GetPrivateData(refguid, pData, pSizeOfData);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, Ref pData, [NativeTypeName("DWORD *")] Ref<uint> pSizeOfData)
    {
        fixed (uint* __dsl_pSizeOfData = pSizeOfData)
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_refguid = refguid)
        {
            return (HResult)GetPrivateData(__dsl_refguid, __dsl_pData, __dsl_pSizeOfData);
        }
    }

    /// <inheritdoc cref = "IDirect3DResource9.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public new D3Dresourcetype GetType() => LpVtbl->GetType();
    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.LockRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult LockRect(D3DlockedRect* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->LockRect(pLockedRect, pRect, Flags);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LockRect(Ref<D3DlockedRect> pLockedRect, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("DWORD")] uint Flags)
    {
        fixed (RECT* __dsl_pRect = pRect)
        fixed (D3DlockedRect* __dsl_pLockedRect = pLockedRect)
        {
            return (HResult)LockRect(__dsl_pLockedRect, __dsl_pRect, Flags);
        }
    }

    /// <inheritdoc cref = "IDirect3DResource9.PreLoad"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void PreLoad() => LpVtbl->PreLoad();
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
    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.ReleaseDC"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult ReleaseDC(HDC hdc) => LpVtbl->ReleaseDC(hdc);
    /// <inheritdoc cref = "IDirect3DResource9.SetPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew) => LpVtbl->SetPriority(PriorityNew);
    /// <inheritdoc cref = "IDirect3DResource9.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->SetPrivateData(refguid, pData, SizeOfData, Flags);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> refguid, [NativeTypeName("const void *")] Ref pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_refguid = refguid)
        {
            return (HResult)SetPrivateData(__dsl_refguid, __dsl_pData, SizeOfData, Flags);
        }
    }

    /// <include file='IDirect3DSurface9.xml' path='doc/member[@name="IDirect3DSurface9.UnlockRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult UnlockRect() => LpVtbl->UnlockRect();
}