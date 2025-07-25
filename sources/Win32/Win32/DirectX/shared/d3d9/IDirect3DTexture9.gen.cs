// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9"]/*'/>
[Guid("85C31227-3DE5-4F00-9B3A-F11AC38C18B5")]
[NativeTypeName("struct IDirect3DTexture9 : IDirect3DBaseTexture9")]
[NativeInheritance("IDirect3DBaseTexture9")]
public unsafe partial struct IDirect3DTexture9 : IDirect3DTexture9.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DTexture9));

    public interface Interface : IDirect3DBaseTexture9.Interface
    {
        [VtblIndex(21)]
        HResult AddDirtyRect([NativeTypeName("const RECT *")] RECT* pDirtyRect);
        [VtblIndex(21)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult AddDirtyRect([NativeTypeName("const RECT *")] Ref<RECT> pDirtyRect);
        [VtblIndex(17)]
        HResult GetLevelDesc(uint Level, D3DsurfaceDesc* pDesc);
        [VtblIndex(17)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetLevelDesc(uint Level, Ref<D3DsurfaceDesc> pDesc);
        [VtblIndex(18)]
        HResult GetSurfaceLevel(uint Level, IDirect3DSurface9* ppSurfaceLevel);
        [VtblIndex(18)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetSurfaceLevel(uint Level, Ref<IDirect3DSurface9> ppSurfaceLevel);
        [VtblIndex(19)]
        HResult LockRect(uint Level, D3DlockedRect* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(19)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult LockRect(uint Level, Ref<D3DlockedRect> pLockedRect, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("DWORD")] uint Flags);
        [VtblIndex(20)]
        HResult UnlockRect(uint Level);
    }

    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9"]/*'/>
    [Guid("85C31227-3DE5-4F00-9B3A-F11AC38C18B5")]
    [NativeTypeName("struct IDirect3DTexture9 : IDirect3DBaseTexture9")]
    [NativeInheritance("IDirect3DBaseTexture9")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDirect3DTexture9));

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
            [NativeTypeName("DWORD (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint> SetLOD;
            [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetLOD;
            [NativeTypeName("DWORD () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetLevelCount;
            [NativeTypeName("HRESULT (D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dtexturefiltertype, HResult> SetAutoGenFilterType;
            [NativeTypeName("D3DTEXTUREFILTERTYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3Dtexturefiltertype> GetAutoGenFilterType;
            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> GenerateMipSubLevels;
            [NativeTypeName("HRESULT (UINT, D3DSURFACE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3DsurfaceDesc*, HResult> GetLevelDesc;
            [NativeTypeName("HRESULT (UINT, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, IDirect3DSurface9.Native**, HResult> GetSurfaceLevel;
            [NativeTypeName("HRESULT (UINT, D3DLOCKED_RECT *, const RECT *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3DlockedRect*, RECT*, uint, HResult> LockRect;
            [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> UnlockRect;
            [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> AddDirtyRect;
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.AddDirtyRect"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HResult AddDirtyRect([NativeTypeName("const RECT *")] RECT* pDirtyRect)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, RECT*, HResult> )(lpVtbl[21]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), pDirtyRect);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult AddDirtyRect([NativeTypeName("const RECT *")] Ref<RECT> pDirtyRect)
        {
            fixed (RECT* __dsl_pDirtyRect = pDirtyRect)
            {
                return (HResult)AddDirtyRect(__dsl_pDirtyRect);
            }
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint> )(lpVtbl[1]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DResource9.FreePrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult FreePrivateData([NativeTypeName("const GUID &")] Guid* refguid)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, Guid*, HResult> )(lpVtbl[6]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), refguid);
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

        /// <inheritdoc cref = "IDirect3DBaseTexture9.GenerateMipSubLevels"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void GenerateMipSubLevels()
        {
            ((delegate* unmanaged<IDirect3DTexture9.Native*, void> )(lpVtbl[16]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DBaseTexture9.GetAutoGenFilterType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public D3Dtexturefiltertype GetAutoGenFilterType()
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, D3Dtexturefiltertype> )(lpVtbl[15]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetDevice(IDirect3DDevice9* ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, IDirect3DDevice9.Native**, HResult> )(lpVtbl[3]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), &ppDevice->LpVtbl);
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

        /// <inheritdoc cref = "IDirect3DBaseTexture9.GetLevelCount"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("DWORD")]
        public uint GetLevelCount()
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint> )(lpVtbl[13]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.GetLevelDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult GetLevelDesc(uint Level, D3DsurfaceDesc* pDesc)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint, D3DsurfaceDesc*, HResult> )(lpVtbl[17]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), Level, pDesc);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetLevelDesc(uint Level, Ref<D3DsurfaceDesc> pDesc)
        {
            fixed (D3DsurfaceDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetLevelDesc(Level, __dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IDirect3DBaseTexture9.GetLOD"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("DWORD")]
        public uint GetLOD()
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint> )(lpVtbl[12]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetPriority"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("DWORD")]
        public uint GetPriority()
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint> )(lpVtbl[8]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, void* pData, [NativeTypeName("DWORD *")] uint* pSizeOfData)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, Guid*, void*, uint*, HResult> )(lpVtbl[5]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), refguid, pData, pSizeOfData);
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

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.GetSurfaceLevel"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HResult GetSurfaceLevel(uint Level, IDirect3DSurface9* ppSurfaceLevel)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint, IDirect3DSurface9.Native**, HResult> )(lpVtbl[18]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), Level, &ppSurfaceLevel->LpVtbl);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetSurfaceLevel(uint Level, Ref<IDirect3DSurface9> ppSurfaceLevel)
        {
            fixed (IDirect3DSurface9* __dsl_ppSurfaceLevel = ppSurfaceLevel)
            {
                return (HResult)GetSurfaceLevel(Level, __dsl_ppSurfaceLevel);
            }
        }

        /// <inheritdoc cref = "IDirect3DResource9.GetType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public new D3Dresourcetype GetType()
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, D3Dresourcetype> )(lpVtbl[10]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.LockRect"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HResult LockRect(uint Level, D3DlockedRect* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint, D3DlockedRect*, RECT*, uint, HResult> )(lpVtbl[19]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), Level, pLockedRect, pRect, Flags);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LockRect(uint Level, Ref<D3DlockedRect> pLockedRect, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("DWORD")] uint Flags)
        {
            fixed (RECT* __dsl_pRect = pRect)
            fixed (D3DlockedRect* __dsl_pLockedRect = pLockedRect)
            {
                return (HResult)LockRect(Level, __dsl_pLockedRect, __dsl_pRect, Flags);
            }
        }

        /// <inheritdoc cref = "IDirect3DResource9.PreLoad"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void PreLoad()
        {
            ((delegate* unmanaged<IDirect3DTexture9.Native*, void> )(lpVtbl[9]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint> )(lpVtbl[2]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IDirect3DBaseTexture9.SetAutoGenFilterType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult SetAutoGenFilterType(D3Dtexturefiltertype FilterType)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, D3Dtexturefiltertype, HResult> )(lpVtbl[14]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), FilterType);
        }

        /// <inheritdoc cref = "IDirect3DBaseTexture9.SetLOD"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("DWORD")]
        public uint SetLOD([NativeTypeName("DWORD")] uint LODNew)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint, uint> )(lpVtbl[11]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), LODNew);
        }

        /// <inheritdoc cref = "IDirect3DResource9.SetPriority"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        public uint SetPriority([NativeTypeName("DWORD")] uint PriorityNew)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint, uint> )(lpVtbl[7]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), PriorityNew);
        }

        /// <inheritdoc cref = "IDirect3DResource9.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* refguid, [NativeTypeName("const void *")] void* pData, [NativeTypeName("DWORD")] uint SizeOfData, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, Guid*, void*, uint, uint, HResult> )(lpVtbl[4]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), refguid, pData, SizeOfData, Flags);
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

        /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.UnlockRect"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HResult UnlockRect(uint Level)
        {
            return ((delegate* unmanaged<IDirect3DTexture9.Native*, uint, HResult> )(lpVtbl[20]))((IDirect3DTexture9.Native*)Unsafe.AsPointer(ref this), Level);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DTexture9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DTexture9(Ptr3D vtbl) => LpVtbl = (IDirect3DTexture9.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDirect3DTexture9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DTexture9(Ptr<IDirect3DTexture9.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "IDirect3DTexture9.Native"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9.Native"/> instance to be converted </param>
    public static implicit operator IDirect3DTexture9(IDirect3DTexture9.Native* value) => new IDirect3DTexture9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DTexture9"/> to <see cref = "IDirect3DTexture9.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator IDirect3DTexture9.Native*(IDirect3DTexture9 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator IDirect3DTexture9(Ptr3D value) => new IDirect3DTexture9(value);
    /// <summary>casts <see cref = "IDirect3DTexture9"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator Ptr3D(IDirect3DTexture9 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator IDirect3DTexture9(Ptr<IDirect3DTexture9.Native> value) => new IDirect3DTexture9(value);
    /// <summary>casts <see cref = "IDirect3DTexture9"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator Ptr<IDirect3DTexture9.Native>(IDirect3DTexture9 value) => (Ptr<IDirect3DTexture9.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator IDirect3DTexture9(void*** value) => new IDirect3DTexture9((Ptr<Native>)value);
    /// <summary>casts <see cref = "IDirect3DTexture9"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator void***(IDirect3DTexture9 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDirect3DTexture9"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator IDirect3DTexture9(nuint value) => new IDirect3DTexture9((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "IDirect3DTexture9"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDirect3DTexture9"/> instance to be converted </param>
    public static implicit operator nuint(IDirect3DTexture9 value) => (nuint)value.LpVtbl;
    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.AddDirtyRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HResult AddDirtyRect([NativeTypeName("const RECT *")] RECT* pDirtyRect) => LpVtbl->AddDirtyRect(pDirtyRect);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult AddDirtyRect([NativeTypeName("const RECT *")] Ref<RECT> pDirtyRect)
    {
        fixed (RECT* __dsl_pDirtyRect = pDirtyRect)
        {
            return (HResult)AddDirtyRect(__dsl_pDirtyRect);
        }
    }

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

    /// <inheritdoc cref = "IDirect3DBaseTexture9.GenerateMipSubLevels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void GenerateMipSubLevels() => LpVtbl->GenerateMipSubLevels();
    /// <inheritdoc cref = "IDirect3DBaseTexture9.GetAutoGenFilterType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public D3Dtexturefiltertype GetAutoGenFilterType() => LpVtbl->GetAutoGenFilterType();
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

    /// <inheritdoc cref = "IDirect3DBaseTexture9.GetLevelCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("DWORD")]
    public uint GetLevelCount() => LpVtbl->GetLevelCount();
    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.GetLevelDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult GetLevelDesc(uint Level, D3DsurfaceDesc* pDesc) => LpVtbl->GetLevelDesc(Level, pDesc);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetLevelDesc(uint Level, Ref<D3DsurfaceDesc> pDesc)
    {
        fixed (D3DsurfaceDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetLevelDesc(Level, __dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IDirect3DBaseTexture9.GetLOD"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("DWORD")]
    public uint GetLOD() => LpVtbl->GetLOD();
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

    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.GetSurfaceLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HResult GetSurfaceLevel(uint Level, IDirect3DSurface9* ppSurfaceLevel) => LpVtbl->GetSurfaceLevel(Level, ppSurfaceLevel);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetSurfaceLevel(uint Level, Ref<IDirect3DSurface9> ppSurfaceLevel)
    {
        fixed (IDirect3DSurface9* __dsl_ppSurfaceLevel = ppSurfaceLevel)
        {
            return (HResult)GetSurfaceLevel(Level, __dsl_ppSurfaceLevel);
        }
    }

    /// <inheritdoc cref = "IDirect3DResource9.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public new D3Dresourcetype GetType() => LpVtbl->GetType();
    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.LockRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HResult LockRect(uint Level, D3DlockedRect* pLockedRect, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("DWORD")] uint Flags) => LpVtbl->LockRect(Level, pLockedRect, pRect, Flags);
    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LockRect(uint Level, Ref<D3DlockedRect> pLockedRect, [NativeTypeName("const RECT *")] Ref<RECT> pRect, [NativeTypeName("DWORD")] uint Flags)
    {
        fixed (RECT* __dsl_pRect = pRect)
        fixed (D3DlockedRect* __dsl_pLockedRect = pLockedRect)
        {
            return (HResult)LockRect(Level, __dsl_pLockedRect, __dsl_pRect, Flags);
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
    /// <inheritdoc cref = "IDirect3DBaseTexture9.SetAutoGenFilterType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult SetAutoGenFilterType(D3Dtexturefiltertype FilterType) => LpVtbl->SetAutoGenFilterType(FilterType);
    /// <inheritdoc cref = "IDirect3DBaseTexture9.SetLOD"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("DWORD")]
    public uint SetLOD([NativeTypeName("DWORD")] uint LODNew) => LpVtbl->SetLOD(LODNew);
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

    /// <include file='IDirect3DTexture9.xml' path='doc/member[@name="IDirect3DTexture9.UnlockRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HResult UnlockRect(uint Level) => LpVtbl->UnlockRect(Level);
}